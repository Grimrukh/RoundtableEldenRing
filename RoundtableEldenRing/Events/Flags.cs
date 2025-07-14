using System.Diagnostics.CodeAnalysis;

namespace RoundtableEldenRing.Events;

/// <summary>
/// Vanilla game flags checked/changed by the mod.
///
/// Most of these are boss death flags and major progression flags.
///
/// For ALL dungeon bosses, their entity ID is also their death flag (with the 'first' member of any multi-enemy boss
/// fights counting as their entity ID).
///
/// However, for overworld bosses, their entity ID can start with 10 if they're in a small tile MSB or 12 if they're in
/// a large tile MSB (enemies that tend to roam more, I believe). Their death flag will always start with 12, so it
/// will only match for enemies loaded in a large tile. Standard format:
///     12XXZZ0800
/// </summary>
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class VanillaFlags
{
    #region Important Boss Flags
    public const int GodrickBattleStarted = 10002805;
    public const int RennalaPhaseTwoStarted = 14002803;
    public const int MorgottBattleStarted = 11002805;
    public const int RadahnBattleStarted = 1052382805;
    public const int AstelBattleStarted = 12042805;
    public const int MohgBattleStarted = 12052805;
    public const int MaleniaBattleStarted = 15002805;
    public const int EldenBeastBattleStarted = 19002803;
    #endregion
    
    #region Boss Reward Request Flags (Non-Generic)
    public const int MargitReward = 9100;
    public const int GodrickReward = 9101;
    // 9102 is unused.
    public const int GraftedScionReward = 9103;
    public const int MorgottReward = 9104;
    public const int GodfreyPhantomReward = 9105;
    public const int GideonOfnirReward = 9106;
    public const int HoarahLouxReward = 9107;
    public const int AstelReward = 9108;
    public const int DragonkinSoldierOfNokstellaReward = 9109;
    public const int ValiantGargoylesReward = 9110;
    public const int LichdragonFortissaxReward = 9111;
    public const int MohgLordOfBloodReward = 9112;
    // 9113 is unused.
    public const int GodskinDuoReward = 9114;
    public const int DragonlordPlacidusaxReward = 9115;
    public const int MalikethReward = 9116;
    public const int RedWolfOfRadagonReward = 9117;
    public const int RennalaReward = 9118;
    public const int LorettaHaligtreeReward = 9119;
    public const int MaleniaReward = 9120;
    public const int ManorGodskinNobleReward = 9121;
    public const int RykardReward = 9122;
    public const int EldenBeastReward = 9123;
    // 9124 is unused.
    public const int MohgTheOmenReward = 9125;
    public const int MagmaWyrmMakarReward = 9126;
    // 9127 is unused.
    public const int FringefolkUlceratedTreeSpiritReward = 9128;
    public const int AbductorVirginsReward = 9129;
    public const int RadahnReward = 9130;
    public const int FireGiantReward = 9131;
    public const int AncestorSpiritReward = 9132;
    public const int RegalAncestorSpiritReward = 9133;
    public const int StrayMimicTearReward = 9134;
    public const int FiasChampionsReward = 9135;

    public const int DivineTowerOfCaelidGodskinApostleReward = 9173;
    public const int FellTwinsReward = 9174;
    
    public const int MorneLeonineMisbegottenReward = 9180;
    public const int LorettaCariaReward = 9181;
    public const int ElemerReward = 9182;
    public const int RedmaneDuoReward = 9183;
    public const int CommanderONeilReward = 9184;
    #endregion
    
    // NOTE: Generic dungeon boss reward request flags are handled by `Index` of `GenericDungeonInfo` per region.
    
    #region Boss Death Flags (Dungeons)
    public const int MargitDead = 10000850;
    public const int GodrickDead = 10000800;
    
    public const int ChapelGraftedScionDead = 10010800;
    
    public const int MorgottDead = 11000800;
    public const int GodfreyPhantomDead = 11000850;
    
    public const int GideonOfnirDead = 11050850;
    public const int HoarahLouxDead = 11050800;
    
    public const int DragonkinSolderOfNokstellaDead = 12010800;
    public const int LakeOfRotBossDead = 12010850;  // FACTIONAL

    public const int SiofraDragonkinSoldierDead = 12020830;  // FACTIONAL
    public const int MimicTearDead = 12020850;
    public const int ValiantGargoylesDead = 12020800;

    public const int DeeprootDepthsCliffsideBossDead = 12030390;  // FACTIONAL
    public const int FiasChampionsDead = 12030800;
    public const int LichdragonFortissaxDead = 12030850;
    
    public const int AstelDead = 12040800;
    
    public const int MohgLordOfBloodDead = 12050800;
    
    public const int AncestorSpiritDead = 12080800;
    
    public const int RegalAncestorSpiritDead = 12090800;
    
    public const int GodskinDuoDead = 13000850;
    public const int MalikethDead = 13000800;
    public const int PlacidusaxDead = 13000830;

    public const int RedWolfOfRadagonDead = 14000850;
    public const int RennalaDead = 14000800;
    
    public const int LorettaHaligtreeDead = 15000850;
    public const int MaleniaDead = 15000800;

    public const int ManorGodskinNobleDead = 16000850;
    public const int AbductorVirginsDead = 16000860;
    public const int RykardDead = 16000800;
    
    public const int SoldierOfGodrickDead = 18000850;
    
    public const int RadagonEldenBeastDead = 19000800;

    public const int MohgTheOmenDead = 35000800;
    public const int EsgarDead = 35000850;

    public const int MagmaWyrmMakarDead = 39200800;
    #endregion
    
    #region Boss Death Flags (Generic)
    // These bosses are the same the first time, but others can move in after. When that happens, this flag will be
    // reset, but the EMEVD and MSB will be different.
    public const int FringefolkHerosGraveBossDead = 18000800;  // Ulcerated Tree Spirit
    public const int TombswardCatacombsBossDead = 30000800;  // Cemetery Shade
    public const int ImpalersCatacombsBossDead = 30010800;  // Erdtree Burial Watchdog
    public const int StormfootCatacombsBossDead = 30020800;  // Erdtree Burial Watchdog
    public const int RoadsEndCatacombsBossDead = 30030800;  // Spirit-Caller Snail
    public const int MurkwaterCatacombsBossDead = 30040800;  // Grave Warden Duelist
    public const int BlackKnifeCatacombsBossDead = 30050800;  // Cemetery Shade
    public const int BlackKnifeCatacombsAssassinDead = 30050850;  // Black Knife Assassin
    public const int CliffbottomCatacombsBossDead = 30060800;  // Erdtree Burial Watchdog
    public const int WyndhamCatacombsBossDead = 30070800;  // Erdtree Burial Watchdog
    public const int SaintedHerosGraveBossDead = 30080800;  // Ancient Hero of Zamor
    public const int GelmirHerosGraveBossDead = 30090800;  // Red Wolf of the Champion
    public const int AurizaHerosGraveBossDead = 30100800;  // Crucible Knight Ordovis and Crucible Knight (Tree Spear)
    public const int DeathtouchedCatacombsBossDead = 30110800;  // Black Knife Assassin
    public const int UnsightlyCatacombsBossDead = 30120800;  // Misbegotten Warrior and Perfumer Tricia
    public const int AurizaSideTombBossDead = 30130800;  // Grave Warden Duelist
    public const int MinorErdtreeCatacombsBossDead = 30140800;  // Erdtree Burial Watchdog
    public const int CaelidCatacombsBossDead = 30150800;  // Cemetery Shade
    public const int WarDeadCatacombsBossDead = 30160800;  // Putrid Tree Spirit
    public const int GiantConqueringHerosGraveBossDead = 30170800;  // Ancient Hero of Zamor
    public const int GiantsMountaintopCatacombsBossDead = 30180800;  // Ulcerated Tree Sprit
    public const int ConsecratedSnowfieldCatacombsBossDead = 30190800;  // Putrid Grave Warden Duelist
    public const int HiddenPathToHaligtreeBossDead = 30200800;  // Stray Mimic Tear
    
    public const int PatchesBossDead = 31000800;
    public const int EarthboreCaveBossDead = 31010800;  // Runebear
    public const int TombswardCaveBossDead = 31020800;  // Miranda the Blighted Bloom
    public const int GrovesideCaveBossDead = 31030800;  // Beastman of Farum Azula
    public const int StillwaterCaveBossDead = 31040800;  // Cleanrot Knight
    public const int LakesideCrystalCaveBossDead = 31050800;  // Bloodhound Knight
    public const int AcademyCrystalCaveBossDead = 31060800;  // Crystalians
    public const int SeethewaterCaveBossDead = 31070800;  // Kindred of Rot
    public const int VolcanoCaveBossDead = 31090800;  // Demi-Human Queen Margot
    public const int DragonbarrowCaveBossDead = 31100800;  // Beastman of Farum Azula
    public const int SelliaHideawayCaveBossDead = 31110800;  // Putrid Crystalians
    public const int CaveOfTheForlornBossDead = 31120800;  // Misbegotten Crusader
    public const int CoastalCaveBossDead = 31150800;  // Demi-Human Chief
    public const int HighroadCaveBossDead = 31170800;  // Guardian Golem
    public const int PerfumersGrottoBossDead = 31180800;  // Miranda the Blighted Bloom
    public const int SagesCaveBossDead = 31190800;  // Black Knife Assassin
    public const int NecromancerGarrisDead = 31190850;
    public const int AbandonedCaveBossDead = 31200800;  // Cleanrot Knight
    public const int GaolCaveBossDead = 31210800;  // Frenzied Duelist
    public const int SpiritcallersCaveBossDead = 31220800;  // Spirit-Caller Snail
    
    public const int MorneTunnelBossDead = 32000800;  // Scaly Misbegotten
    public const int LimgraveTunnelsBossDead = 32010800;  // Stonedigger Troll
    public const int RayaLucariaCrystalTunnelBossDead = 32020800;  // Crystalian (Ringblade)
    public const int OldAltusTunnelBossDead = 32040800;  // Stonedigger Troll
    public const int AltusTunnelBossDead = 32050800;  // Crystalian (Ringblade) and Crystalian (Spear)
    public const int GaelTunnelBossDead = 32070800;  // Magma Wyrm
    public const int SelliaCrystalTunnelBossDead = 32080800;  // Fallingstar Beast
    public const int YeloughAnixTunnelBossDead = 32110800;  // Astel, Stars of Darkness

    // NOTE: The Godskin Noble in the Divine Tower of Liurnia isn't considered a boss.
    // NOTE: Sealed Tunnel == Divine Tower of West Altus.
    public const int SealedTunnelBossDead = 34120800;  // Onyx Lord
    public const int DivineTowerOfCaelidBossDead = 34130800;  // Godskin Apostle
    public const int FellTwinsDead = 34140850;  // NOTE: no +800 boss in this map
    #endregion
    
    #region Boss Death Flags (Overworld Non-Field)
    public const int MorneLeonineMisbegottenDead = 1043300800;
    public const int GlintstoneDragonAdulaRannisRiseDefeated = 1034500800;
    public const int GlintstoneDragonAdulaDead = 1034420800;
    public const int RoyalKnightLorettaDead = 1035500800;
    public const int ElemerDead = 1039540800;
    public const int CommanderONeilDead = 1049380800;
    public const int SelliaNoxDuoDead = 1049390800;
    public const int SummonwaterVillageTibiaMarinerDead = 1045390800;
    public const int WyndhamRuinsTibiaMarinerDead = 1038520340;
    public const int JarburgTibiaMarinerDead = 1039440800;
    public const int AncientDragonLansseaxDead = 1041520800;
    public const int CommanderNiallDead = 1051570800;
    public const int RadahnDead = 1052380800;
    public const int FireGiantDead = 1052520800;
    #endregion
    
    #region Boss Death Flags (Evergaols)
    public const int RingleadersEvergaolBossDead = 1033420800;  // Alecto, Black Knife Ringleader
    public const int CuckoosEvergaolBossDead = 1033450800;  // Bols, Carian Knight
    public const int RoyalGraveEvergaolBossDead = 1036500800;  // Onyx Lord
    public const int MalefactorsEvergaolBossDead = 1038410800;  // Adan, Thief of Fire
    public const int GoldenLineageEvergaolBossDead = 1039500800;  // Godefroy the Grafted
    public const int WeepingEvergaolBossDead = 1042330800;  // Ancient Hero of Zamor
    public const int StormhillEvergaolBossDead = 1042370800;  // Crucible Knight
    public const int ForlornHoundEvergaolBossDead = 1044350800;  // Bloodhound Knight
    public const int LordContendersEvergaolBossDead = 1053560800;  // Roundtable Knight Vyke
    #endregion
    
    #region Boss Death Flags (Overworld Field)
    public const int RevengersShackBossDead = 1033480800;  // Erdtree Avatar
    public const int MeetingPlaceBossDead = 1034450800;  // Glintstone Dragon Smarag
    public const int KingsrealmRuinsBossDead = 1034480800;  // Royal Revenant
    public const int VillageOfTheAlbinauricsBossDead = 1035420800;  // Omenkiller
    public const int SeethewaterTerminusBossDead = 1035530800;  // Magma Wyrm
    public const int GateTownNorthwestBossDead = 1036450340;  // Death Rite Bird
    public const int EastRayaLucariaGateBossDead = 1036480340;  // Night's Cavalry
    public const int CraterBossDead = 1036540800;  // Full-Grown Fallingstar Beast
    public const int LaskyarRuinsBossDead = 1037420340;  // Death Rite Bird
    public const int ChurchOfVowsBossDead = 1037460800;  // Bell Bearing Hunter
    public const int AbandonedCoffinBossDead = 1037510800;  // Lansseax appearance
    public const int PrimevalSorcererAzurBossDead = 1037530800;  // Demi-Human Queen
    public const int MinorErdtreeMtGelmirBossDead = 1037540810;  // Ulcerated Tree Spirit
    public const int MinorErdtreeLiurniaBossDead = 1038480800;  // Erdtree Avatar
    public const int LuxRuinsBossDead = 1038510800;  // Demi-Human Queen
    public const int LiurniaHighwayFarNorthBossDead = 1039430340;  // Night's Cavalry
    public const int AltusHighwayJunctionBossDead = 1039510800;  // Night's Cavalry
    public const int SaintedHerosGraveEntranceBossDead = 1040520800;  // Black Knife Assassin
    public const int WrithebloodRuinsBossDead = 1040530800;  // Sanguine Noble
    public const int SouthOfTreeSentinelDuoBossDead = 1041500800;  // Fallingstar Beast
    public const int TreeSentinelDuoBossDead = 1041510800;  // Tree Sentinels
    public const int WoodfolkRuinsBossDead = 1041530800;  // Wormface
    public const int ChurchOfEllehBossDead = 1042360800;  // Tree Sentinel
    public const int StormgateBossDead = 1042380800;  // Death Rite Bird
    public const int WarmastersShackBossDead = 1042380850;  // Bell Bearing Hunter
    public const int WindmillHeightsBossDead = 1042550800;  // Godskin Apostle
    public const int LakeAgheelBossDead = 1043360800;  // Flying Dragon Agheel
    public const int AgheelLakeNorthBossDead = 1043370340;  // Night's Cavalry
    public const int HermitMerchantsShackBossDead = 1043530800;  // Bell Bearing Hunter
    public const int CastleMorneApproachBossDead = 1044320340;  // Death Rite Bird
    public const int WaypointRuinsBossDead = 1044360800;  // Mad Pumpkin Head
    public const int MinorErdtreeCapitalOutskirtsBossDead = 1044530800;  // Death Rite Bird
    public const int CapitalRampartBossDead = 1045520800;  // Draconic Tree Sentinel
    public const int MinorErdtreeCaelidBossDead = 1047400800;  // Putrid Avatar
    public const int CaelidHighwaySouthBossDead = 1048370800;  // Decaying Ekzykes
    public const int SouthwestCaelidHighwaySouthBossDead = 1048400800;  // Monstrous Dog
    public const int IsolatedMerchantsShackBossDead = 1048410800;  // Bell Bearing Hunter
    public const int ForbiddenLandsBossDead = 1048510800;  // Night's Cavalry
    public const int OrdinaLiturgicalTownBossDead = 1048570800;  // Death Rite Bird
    public const int SouthernAeoniaSwampBankBoss0Dead = 1049370800;  // Night's Cavalry
    public const int SouthernAeoniaSwampBankBoss1Dead = 1049370850;  // Death Rite Bird
    public const int SelliaCrystalTunnelEntranceBossDead = 1049390850;  // Battlemage Hugues
    public const int BeforeGrandLiftOfRoldBossDead = 1049520800;  // Black Blade Kindred
    public const int AlbinauricRiseBossDead = 1050560800;  // Great Wyrm Theodorix
    public const int WestOfCastleSoDeathRiteBirdDead = 1050570800;  // Death Rite Bird
    public const int MinorErdtreeSnowfieldBossDead = 1050570850;  // Putrid Avatar
    public const int RedmaneCastleDuoDead = 1051360800;  // Leonine Misbegotten
    public const int DragonbarrowForkBossDead = 1051400800;  // Putrid Avatar
    public const int BestialSanctumBossDead = 1051430800;  // Black Blade Kindred
    public const int DragonbarrowBossDead = 1052410800;  // Flying Dragon Greyll
    public const int NightCaveBossDead = 1052410850;  // Night's Cavalry
    public const int MinorErdtreeMountaintopsBossDead = 1052560800;  // Erdtree Avatar
    public const int FreezingFieldsBossDead = 1054560800;  // Borealis the Freezing Fog
    public const int SourthwestMountaintopsBossDead = 1248550800;  // Night's Cavalry Duo
    #endregion
}


/// <summary>
/// Complete documentation of all the instructions that take at least one event flag (or flag range) parameter, and the
/// offset of those argument(s).
/// </summary>
public static class InstructionFlagOffsets
{
    public static readonly Dictionary<(int bank, int id), int[]> FLAGS = new()
    {
        [(3, 0)] = [4],  // IfFlagState
        [(3, 12)] = [4],  // IfEventValueComparison
        [(1003, 0)] = [4],  // AwaitFlagState
        [(1003, 1)] = [4],  // SkipLinesIfFlagState
        [(1003, 2)] = [4],  // ReturnIfFlagState
        [(2003, 9)] = [0],  // InvertFlag
        [(2004, 76)] = [0],  // Unknown_2004_76
        [(2003, 25)] = [12, 16],  // PlaceSummonSign
        [(2003, 31)] = [0],  // IncrementEventValue
        [(2003, 32)] = [0],  // ClearEventValue
        [(2003, 41)] = [0, 12],  // EventValueOperation
        [(2005, 9)] = [0],  // CreateHazard
        [(2005, 12)] = [0],  // RemoveAssetFlag
        [(2009, 0)] = [0, 4],  // RegisterLadder
        [(2009, 3)] = [0],  // RegisterGrace
        [(1003, 101)] = [4],  // GotoIfFlagState
        [(2003, 42)] = [8],  // StoreItemAmountSpecifiedByFlagValue
        [(2003, 43)] = [8],  // GivePlayerItemAmountSpecifiedByFlagValue
        [(2003, 66)] = [4],  // SetFlagState
        [(2005, 20)] = [0],  // CreateBigHazardousAsset
        [(2007, 10)] = [16, 20, 24],  // AwaitDialogResponse
    };
    
    public static readonly Dictionary<(int bank, int id), (int first, int last)> FLAG_RANGES = new()
    {
        [(3, 1)] = (4, 8),  // IfFlagRangeState
        [(3, 10)] = (4, 8),  // IfEnabledFlagCountComparison
        [(1003, 3)] = (4, 8),  // SkipLinesIfFlagRangeState
        [(1003, 4)] = (4, 8),  // ReturnIfFlagRangeState
        [(2003, 17)] = (0, 4),  // SetRandomFlagInRange
        [(2003, 22)] = (0, 4),  // SetFlagRangeState
        [(1003, 103)] = (4, 8),  // GotoIfFlagRangeState
        [(2003, 63)] = (0, 4),  // SetNetworkConnectedFlagRangeState
    };

}