using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoulsFormats
{
    /// <summary>
    /// A map layout file used in AC6. Extension: .msb
    /// </summary>
    public partial class MSB_AC6 : SoulsFile<MSB_AC6>, IMsb
    {
        /// <summary>
        /// Model files that are available for parts to use.
        /// </summary>
        public ModelParam Models { get; set; }
        IMsbParam<IMsbModel> IMsb.Models => Models;

        /// <summary>
        /// Dynamic or interactive systems such as item pickups, levers, enemy spawners, etc.
        /// </summary>
        public EventParam Events { get; set; }
        IMsbParam<IMsbEvent> IMsb.Events => Events;

        // <summary>
        /// Points or areas of space that trigger some sort of behavior.
        /// </summary>
        public PointParam Regions { get; set; }
        IMsbParam<IMsbRegion> IMsb.Regions => Regions;

        /// <summary>
        /// Unknown, but related to muffling regions somehow.
        /// </summary>
        public RouteParam Routes { get; set; }

        /// <summary>
        /// Layers in this MSB.
        /// </summary>
        public LayerParam Layers { get; set; }

        /// <summary>
        /// Instances of actual things in the map.
        /// </summary>
        public PartsParam Parts { get; set; }
        IMsbParam<IMsbPart> IMsb.Parts => Parts;

        /// <summary>
        /// Creates an MSBS with nothing in it.
        /// </summary>
        public MSB_AC6()
        {
            Models = new ModelParam();
            Events = new EventParam();
            Regions = new PointParam();
            Routes = new RouteParam();
            Layers = new LayerParam();
            Parts = new PartsParam();
        }

        /// <summary>
        /// Checks whether the data appears to be a file of this format.
        /// </summary>
        protected override bool Is(BinaryReaderEx br)
        {
            if (br.Length < 4)
                return false;

            string magic = br.GetASCII(0, 4);
            return magic == "MSB ";
        }

        /// <summary>
        /// Deserializes file data from a stream.
        /// </summary>
        protected override void Read(BinaryReaderEx br)
        {
            br.BigEndian = false;
            MSB.AssertHeader(br);

            Models = new ModelParam();
            var models = Models.Read(br);
            Events = new EventParam();
            var events = Events.Read(br);
            Regions = new PointParam();
            var regions = Regions.Read(br);
            Routes = new RouteParam();
            var routes = Routes.Read(br);
            Layers = new LayerParam();
            var layers = Layers.Read(br);
            Parts = new PartsParam();
            var parts = Parts.Read(br);

            if (br.Position != 0)
                throw new InvalidDataException("The next param offset of the final param should be 0, but it wasn't.");

            MSB.DisambiguateNames(models);
            MSB.DisambiguateNames(events);
            MSB.DisambiguateNames(regions);
            MSB.DisambiguateNames(parts);
            
            Entries entries = new(models, events, Events.PatrolInfo, regions, routes, layers, parts, Parts.Collisions);

            foreach (Event evt in entries.Events)
                evt.GetNames(this, entries);

            foreach (Region region in entries.Regions)
                region.GetNames(entries);

            foreach (Part part in entries.Parts)
                part.GetNames(entries);
        }

        /// <summary>
        /// Serializes file data to a stream.
        /// </summary>
        protected override void Write(BinaryWriterEx bw)
        {
            Entries entries = new(this);

            var modelCounts = entries.CountModelInstances();
            foreach (Model model in entries.Models)
                model.CountInstances(modelCounts);

            foreach (Event evt in entries.Events)
                evt.GetIndices(this, entries);

            foreach (Region region in entries.Regions)
                region.GetIndices(entries);

            foreach (Part part in entries.Parts)
                part.GetIndices(entries);

            bw.BigEndian = false;
            MSB.WriteHeader(bw);

            Models.Write(bw, entries.Models.Items);
            bw.FillInt64("NextParamOffset", bw.Position);
            Events.Write(bw, entries.Events.Items);
            bw.FillInt64("NextParamOffset", bw.Position);
            Regions.Write(bw, entries.Regions.Items);
            bw.FillInt64("NextParamOffset", bw.Position);
            Routes.Write(bw, entries.Routes.Items);
            bw.FillInt64("NextParamOffset", bw.Position);
            Layers.Write(bw, entries.Layers.Items);
            bw.FillInt64("NextParamOffset", bw.Position);
            Parts.Write(bw, entries.Parts.Items);
            bw.FillInt64("NextParamOffset", 0);
        }

        internal class Entries
        {
            public EntryCollection<Model> Models { get; private set; }
            public EntryCollection<Event> Events { get; private set; }
            public EntryCollection<Event.PatrolInfo> PatrolInfos { get; private set; }
            public EntryCollection<Region> Regions { get; private set; }
            public EntryCollection<Route> Routes { get; private set; }
            public EntryCollection<Layer> Layers { get; private set; }
            public EntryCollection<Part> Parts { get; private set; }
            public EntryCollection<Part.Collision> Collisions { get; private set; }

            public Entries(
                List<Model> models, List<Event> events, List<Event.PatrolInfo> patrolInfos, 
                List<Region> regions, List<Route> routes, List<Layer> layers, List<Part> parts,
                List<Part.Collision> collisions)
            {
                Models = new EntryCollection<Model>(models);
                Events = new EntryCollection<Event>(events);
                PatrolInfos = new EntryCollection<Event.PatrolInfo>(patrolInfos);
                Regions = new EntryCollection<Region>(regions);
                Routes = new EntryCollection<Route>(routes);
                Layers = new EntryCollection<Layer>(layers);
                Parts = new EntryCollection<Part>(parts);
                Collisions = new EntryCollection<Part.Collision>(collisions);
            }

            public Entries(MSB_AC6 msb)
            {
                Models = new EntryCollection<Model>(msb.Models.GetEntries());
                Events = new EntryCollection<Event>(msb.Events.GetEntries());
                PatrolInfos = new EntryCollection<Event.PatrolInfo>(msb.Events.PatrolInfo.ToList());
                Regions = new EntryCollection<Region>(msb.Regions.GetEntries());
                Routes = new EntryCollection<Route>(msb.Routes.GetEntries());
                Layers = new EntryCollection<Layer>(msb.Layers.GetEntries());
                Parts = new EntryCollection<Part>(msb.Parts.GetEntries());
                Collisions = new EntryCollection<Part.Collision>(msb.Parts.Collisions.ToList());
            }
            
            public Dictionary<string, int> CountModelInstances()
            {
                Dictionary<string, int> modelCounts = new();
                foreach (Part part in Parts)
                {
                    if (!string.IsNullOrEmpty(part.ModelName) && !modelCounts.TryAdd(part.ModelName, 1))
                        modelCounts[part.ModelName]++;
                }

                return modelCounts;
            }
        }

        /// <summary>
        /// A generic group of entries in an MSB.
        /// </summary>
        public abstract class Param<T> where T : Entry
        {
            /// <summary>
            /// Unknown; probably some kind of version number.
            /// </summary>
            public int Version { get; set; }

            private protected string Name { get; }

            internal Param(int version, string name)
            {
                Version = version;
                Name = name;
            }

            internal List<T> Read(BinaryReaderEx br)
            {
                Version = br.ReadInt32();
                int offsetCount = br.ReadInt32();
                long nameOffset = br.ReadInt64();
                long[] entryOffsets = br.ReadInt64s(offsetCount - 1);
                long nextParamOffset = br.ReadInt64();

                string name = br.GetUTF16(nameOffset);
                if (name != Name)
                    throw new InvalidDataException($"Expected param \"{Name}\", got param \"{name}\"");

                var entries = new List<T>(offsetCount - 1);
                foreach (long offset in entryOffsets)
                {
                    br.Position = offset;

                    // CheckEntry will eventually be removed
                    // Currently it filters out the unmapped Part/Model/Region/Event types
                    //if (CheckEntry(br))
                    entries.Add(ReadEntry(br, Version));
                }
                br.Position = nextParamOffset;
                return entries;
            }

            internal abstract T ReadEntry(BinaryReaderEx br, int Version);

            internal virtual void Write(BinaryWriterEx bw, List<T> entries)
            {
                bw.WriteInt32(Version);
                bw.WriteInt32(entries.Count + 1);
                bw.ReserveInt64("ParamNameOffset");
                for (int i = 0; i < entries.Count; i++)
                    bw.ReserveInt64($"EntryOffset{i}");
                bw.ReserveInt64("NextParamOffset");

                bw.FillInt64("ParamNameOffset", bw.Position);
                bw.WriteUTF16(Name, true);
                bw.Pad(8);

                int id = 0;
                Type type = null;
                for (int i = 0; i < entries.Count; i++)
                {
                    if (type != entries[i].GetType())
                    {
                        type = entries[i].GetType();
                        id = 0;
                    }

                    bw.FillInt64($"EntryOffset{i}", bw.Position);
                    entries[i].Write(bw, id);
                    id++;
                }
            }

            /// <summary>
            /// Returns all of the entries in this param, in the order they will be written to the file.
            /// </summary>
            public abstract List<T> GetEntries();

            /// <summary>
            /// Returns the version number and name of the param as a string.
            /// </summary>
            public override string ToString()
            {
                return $"0x{Version:X2} {Name}";
            }
        }

        /// <summary>
        /// A generic entry in an MSB param.
        /// </summary>
        public abstract class Entry : IMsbEntry
        {
            /// <summary>
            /// The name of this entry.
            /// </summary>
            public string Name { get; set; }

            internal abstract void Write(BinaryWriterEx bw, int id);
        }

        /// <summary>
        /// A generic entry in an MSB param that has a name.
        /// </summary>
        public abstract class NamedEntry : Entry, IMsbEntry
        {
            /// <summary>
            /// The name of this entry; should generally be unique.
            /// </summary>
            public abstract string Name { get; set; }
        }
    }
}
