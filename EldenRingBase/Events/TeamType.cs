namespace EldenRingBase.Events;

public enum TeamType : byte
{
    None = 0,  // not aggressive toward anyone
    Human = 1,
    WhitePhantom = 2,  // used by Melina, Blaidd, Alexander (and probably all c0000 summons)
    BlackPhantom = 3,
    Hollow = 4,
    Vagrant = 5,  // used by animals in Regal Ancestor Spirit boss battle
    Enemy = 6,  // most common
    Boss = 7,
    Ally = 8,  // seems unused in Elden Ring ('FriendlyNPC' 26 preferred)
    HostileAlly = 9,  // used by numerous enemies, so probably NOT targeted by enemies in general
    Decoy = 10,
    Dragon = 11,  // formerly 'DecoyLike' in older games
    FightingAlly = 12,  // Targets Enemy/Boss, targeted by Enemy/Boss.
    Intruder = 13,  // Targets and targeted by Human/WhitePhantom/Hollow
    Neutral = 14,
    Charmed = 15,
    Invader16 = 16,
    Invader17 = 17,
    Invader18 = 18,
    Host = 19,
    Coop = 20,
    Hostile = 21,
    WanderingPhantom = 22,
    Enemy23 = 23,
    Enemy24 = 24,  // used by some Giant Flying Ants, one Cemetery Shade boss in Caelid Catacombs, Great Wyrm Theodorix
    StrongEnemy25 = 25,  // unused in ER
    FriendlyNPC = 26,
    HostileNPC = 27,
    CoopNPC = 28,
    Indiscriminate = 29,  // could be useful?
    Object = 30,  // for weapons
    CoopMadPhantom = 31,
    InvaderMadPhantom = 32,
    ArchEnemyTeam = 33,  // used by some bosses (e.g. Tibia Mariner, BKA) and a few enemies like Omen
    
    // Unknown team types that appear in Elden Ring. They do seem to be used at sites of intended NPC battles. It would
    // take a while to figure out which were aggressive toward which, though. Or maybe they're just aggressive toward
    // everyone else, and the different teams are just to prevent accidental overlaps.

    // Used by Godrick, Cuckoo, Leyndell, and Redmane soldiers (NOT Haligtree, though they never appear in the
    // overworld). Also used by a few Mad Pumpkin-Heads and a few Demi-Humans outside the Cave of the Forlorn.
    // Opposes team 60 at the very least, which we know because of the Mad Pumpkin-Head in Castle Morne.
    Military = 48,

    // Used by exactly one Stonedigger Troll in Redmane Castle (the one with the flaming sword that jumps down in front
    // of the closed gate). Purpose unclear.
    RedmaneCastleTroll = 49,

    // Used by both of the Erdtree Burial Watchdogs in the Minor Erdtree Catacombs. Possibly to enable them to attack
    // each other when confused by Crystal Darts.
    ErdtreeBurialWatchdogDuo = 50,

    // Used by:
    //  Cleanrot Knights in Aeonia and the War-Dead Catacombs
    //  Commander O'Neil and his summon mobs (likely to prevent the Cleanrot Knights from attacking them)
    //  Giant Bats in the Mountaintops (both wing patterns)
    //  Kindred of Rot, Rot Sorcerers, and small/large rotted Strays in Caelid
    //  Bleed dogs at Second Church of Marika (Altus)
    //  Small Living Masses in Wyndham Catacombs
    //  Possibly ALL Albinauric Frogs in Liurnia
    //  Possibly ALL Small Crab Crystals in Liurnia
    //  Possibly ALL Demi-Humans in Limgrave
    Unknown51 = 51,

    // Used by:
    //  Monstrous Crows and Dogs in Caelid
    //  Large Snow Crabs in Liurnia
    Unknown52 = 52,

    // Used by:
    //  Marionettes at Mt. Gelmir
    //  Wandering Nobles in north Liurnia (frenzy?)
    Unknown54 = 54,

    // Used by:
    //  Carian Troll Knight in north Liurnia (NOT in Caria Manor)
    //  Abductor Virgins at the base of Mt. Gelmir
    // Likely opposes `Military` team.
    Unknown55 = 55,

    // Used by all non-caravan Snow Trolls (near Flame Peak).
    // Likely opposes team 59 (Mountaintops Monstrous Crows/Dogs).
    FreeSnowTrolls = 56,

    // Used by 'Deracine' slugs in Altus and Erdtree Guardians near the Altus Minor Erdtree.
    AltusDeracine = 57,
    
    // Used by Runebears in Limgrave.
    LimgraveRunebears = 58,

    // Used by Monstrous Crows and Dogs in Mountaintops, and all normal/giant Wormfaces in Altus.
    // Likely opposes team 56 (FreeSnowTrolls), but not sure about who opposes the Wormfaces.
    MountaintopsMonsters_AltusWormfaces = 59, 
    
    // Used by:
    //  Misbegotten in Castle Morne (including boss) and Weeping Peninsula (NOT Cave of the Forlorn)
    //  Possibly ALL Nobles/Pages in Gelmir Hero's Grave and Capital Outskirts
    //  Direwolf mounts for Albinauric Archers near Ordina (not sure if any non-mount wolves are there)
    // Definitely actively opposes team 48 because of the Mad Pumpkin-Head in Castle Morne.
    Unknown60 = 60,
    
    // Wandering Nobles?
    Unknown63 = 63,
    
    // Used by some Guardian Golems:
    //  Capital Outskirts, north Liurnia, Mt. Gelmir
    GuardianGolems = 65,

    // Used by Fire Monks, Fire Prelates, and Bloodthorn Exiles at Mt. Gelmir (Fort Laeidd).
    // Unsure who they oppose here. Maybe nearby Jellyfish? The nearby Flame Chariot is already team `Boss` and should
    // be able to hurt them.
    MtGelmirFireMonks = 66,
}