using SoulsFormats;

namespace EldenRingBase.Events;


public enum CommonFuncID : uint
{
    EnterBossFog = 9005800,
    EnterBossFogAsSummon = 9005801,
    ConditionalGrace = 9005810,
    ControlBossFogAppearance = 9005811,
    ControlBossFogAppearance_RearFog = 9005812,
    ControlBossFogAppearance_MultiplayerAfter = 9005813,
    ControlBossMusic = 9005822,

    Anim_DamageRegionBattle = 90005200,
    Anim_DamageRadiusBattle = 90005201,
    Anim_DamageRadiusANDRegionBattle = 90005210,
    Anim_DamageRadiusORRegionBattle = 90005211,
    Anim_DamageRadiusORRegionBattle_ChrEndStandby = 90005213,
    Anim_DamageBattle = 90005220,

    AI_DamageRegion = 90005250,
    AI_DamageRadius = 90005251,
    AI_DamageRadiusANDRegion = 90005260,
    AI_DamageRadiusORRegion = 90005261,
    AI_DamageOnly = 90005271,

    NonRespawningCharacter = 90005300,

    ConnectToCaravan = 90005420,
    AllowCaravanChestAccess = 90005421,
    CaravanTreasure = 90005422,
    DisconnectFromCaravan = 90005423,
    CaravanDestruction = 90005424,

    FieldBossDeath = 90005860,
    FieldBossDeath_DragonWyrm = 90005861,
    ControlFieldBossHealthBar = 90005870,
    ControlFieldBossMusicHeatup = 90005872,
}


/// <summary>
/// Manually-parsed argument enum for a couple of field boss Common Funcs.
/// </summary>
public enum FieldBossBannerRank : uint
{
    Enemy = 0,
    GreatEnemy = 1,
    Demigod = 2,
    Legend = 3,
}


public static class CommonFuncs
{
    static EMEVD.Instruction RunCommonEvent(CommonFuncID id, params object[] args)
        => EMEDF.RunCommonEvent(0, (uint)id, args);
    
    #region 90058XX Range
    
    public static EMEVD.Instruction EnterBossFog(
        uint bossDeadFlag, uint fogAssetEntityID, uint bossTriggerRegionID, uint battleStartedFlag, uint bossGroupEntityID,
        int actionButtonParamID = 10000, uint optionalRequiredFlag = 0, uint optionalRequiredRegionID = 0)
    {
        return RunCommonEvent(CommonFuncID.EnterBossFog, bossDeadFlag, fogAssetEntityID, bossTriggerRegionID, battleStartedFlag,
            bossGroupEntityID, actionButtonParamID, optionalRequiredFlag, optionalRequiredRegionID);
    }
    
    public static EMEVD.Instruction EnterBossFogAsSummon(
        uint bossDeadFlag, uint fogAssetEntityID, uint bossTriggerRegionID, uint battleStartedFlag, uint summonBattleStartedFlag,
        int actionButtonParamID = 10000)
    {
        return RunCommonEvent(CommonFuncID.EnterBossFogAsSummon, bossDeadFlag, fogAssetEntityID, bossTriggerRegionID, battleStartedFlag,
            summonBattleStartedFlag, actionButtonParamID);
    }
    
    public static EMEVD.Instruction ControlBossFogAppearance(
        uint bossDeadFlag, uint fogAssetEntityID, int fogVFX, uint forceAppearFlag = 0)
    {
        return RunCommonEvent(CommonFuncID.ControlBossFogAppearance, bossDeadFlag, fogAssetEntityID, fogVFX, forceAppearFlag);
    }
    
    /// <summary>
    /// Used to simply disable 'rear fog' (non-prompt fog) for bosses with multiple arena exits.
    ///
    /// Has some weird invasion stuff in it at the end that doesn't seem functional due to a Restart() call. 
    /// </summary>
    public static EMEVD.Instruction ControlBossFogAppearance_RearFog(
        uint bossDeadFlag, uint fogAssetEntityID, int fogVFX, uint forceAppearFlag = 0, int fogMultiplayerVFX = 0)
    {
        return RunCommonEvent(CommonFuncID.ControlBossFogAppearance_RearFog, bossDeadFlag, fogAssetEntityID, fogVFX, forceAppearFlag,
            fogMultiplayerVFX);
    }

    /// <summary>
    /// Used to control 'rear fog' (non-prompt fog) for bosses with multiple arena exits, but the fog also acts as
    /// a multiplayer barrier fog after the boss is dead. 
    /// </summary>
    public static EMEVD.Instruction ControlBossFogAppearance_MultiplayerAfter(
        uint bossDeadFlag, uint fogAssetEntityID, int fogVFX, uint forceAppearFlag = 0, int fogMultiplayerVFX = 0)
    {
        return RunCommonEvent(CommonFuncID.ControlBossFogAppearance_MultiplayerAfter, bossDeadFlag, fogAssetEntityID, fogVFX,
            forceAppearFlag, fogMultiplayerVFX);
    }
    
    /// <summary>
    /// Controls boss music state and heat-up.
    ///
    /// There are other variants of this (9005823, 9005824) in CommonFunc but they are never called.
    ///
    /// Users of 'alternate stop type' suggest that it is a dramatic or long fade-out:
    ///     - Godrick
    ///     - Radahn
    ///     - Mohg the Omen
    ///     - Fire Giant
    ///     - Hoarah Loux
    ///     - Elden Beast
    ///     - Maliketh
    ///     - Dragonlord Placidusax
    ///     - Malenia
    /// </summary>
    public static EMEVD.Instruction ControlBossMusic(
        uint bossDeadFlag, int bgmBossConvParamID, uint battleStartedFlag, uint summonBattleStartedFlag,
        uint optionalRequiredFlag = 0, uint phaseTwoFlag = 0, bool useLongFadeOut = false)
    {
        return RunCommonEvent(CommonFuncID.ControlBossMusic, bossDeadFlag, bgmBossConvParamID, battleStartedFlag,
            summonBattleStartedFlag, optionalRequiredFlag, phaseTwoFlag, 0, useLongFadeOut ? 1 : 0);
    }
    
    #endregion
    
    #region Enemy Animation/Gravity/Collision Triggers
    
    public static EMEVD.Instruction Anim_DamageRegionBattle(
        uint characterEntityID,
        int standbyAnimation,
        int cancelAnimation,
        uint region,
        float delaySeconds = 0f,
        bool handleGravityCollision = false,
        bool onlyInBattleState = false,
        bool onlyInAIState5 = false,
        bool onlyInAIState6 = false)
    {
        return RunCommonEvent(
            CommonFuncID.Anim_DamageRegionBattle,
            characterEntityID, standbyAnimation, cancelAnimation,
            region, delaySeconds,
            handleGravityCollision ? 1U : 0U,
            onlyInBattleState ? 1U : 0U,
            onlyInAIState5 ? 1U : 0U,
            onlyInAIState6 ? 1U : 0U);
    }
    
    public static EMEVD.Instruction Anim_DamageRadiusBattle(
        uint characterEntityID,
        int standbyAnimation,
        int cancelAnimation,
        float radius,
        float delaySeconds = 0f,
        bool handleGravityCollision = false,
        bool onlyInBattleState = false,
        bool onlyInAIState5 = false,
        bool onlyInAIState6 = false)
    {
        return RunCommonEvent(
            CommonFuncID.Anim_DamageRadiusBattle,
            characterEntityID, standbyAnimation, cancelAnimation,
            radius, delaySeconds,
            handleGravityCollision ? 1U : 0U,
            onlyInBattleState ? 1U : 0U,
            onlyInAIState5 ? 1U : 0U,
            onlyInAIState6 ? 1U : 0U);
    }
    
    /// <summary>
    /// Catch-all, common trigger event for enemies. To be triggered, an enemy must be attacked/damaged (see 90005271) or
    /// all of these must be true:
    ///     - player is a compatible player type
    ///     - player is within the specified radius OR, if given, inside the specified region
    ///     - enemy is in any of the given AI states IF any are given
    ///
    /// NOTE: Does not disable or enable AI. Just controls animation and, optionally, gravity + collision.
    /// </summary>
    public static EMEVD.Instruction Anim_DamageRadiusANDRegionBattle(
        uint characterEntityID,
        int standbyAnimation,
        int cancelAnimation,
        uint region = 0,
        float radius = 0,
        float delaySeconds = 0f,
        bool handleGravityCollision = false,
        bool onlyInBattleState = false,
        bool onlyInAIState5 = false,
        bool onlyInAIState6 = false)
    {
        return RunCommonEvent(
            CommonFuncID.Anim_DamageRadiusANDRegionBattle,
            characterEntityID, standbyAnimation, cancelAnimation,
            region, radius, delaySeconds,
            handleGravityCollision ? 1U : 0U,
            onlyInBattleState ? 1U : 0U,
            onlyInAIState5 ? 1U : 0U,
            onlyInAIState6 ? 1U : 0U);
    }
    
    /// <summary>
    /// Catch-all, common trigger event for enemies. To be triggered, an enemy must be attacked/damaged (see 90005271) or
    /// all of these must be true:
    ///     - player is a compatible player type
    ///     - player is within the specified radius OR, if given, inside the specified region
    ///     - enemy is in any of the given AI states IF any are given
    ///
    /// NOTE: Does not disable or enable AI. Just controls animation and, optionally, gravity + collision.
    /// </summary>
    public static EMEVD.Instruction Anim_DamageRadiusORRegionBattle(
        uint characterEntityID,
        int standbyAnimation,
        int cancelAnimation,
        uint region = 0,
        float radius = 0,
        float delaySeconds = 0f,
        bool handleGravityCollision = false,
        bool onlyInBattleState = false,
        bool onlyInAIState5 = false,
        bool onlyInAIState6 = false)
    {
        return RunCommonEvent(
            CommonFuncID.Anim_DamageRadiusORRegionBattle,
            characterEntityID, standbyAnimation, cancelAnimation,
            region, radius, delaySeconds,
            handleGravityCollision ? 1U : 0U,
            onlyInBattleState ? 1U : 0U,
            onlyInAIState5 ? 1U : 0U,
            onlyInAIState6 ? 1U : 0U);
    }
    
    /// <summary>
    /// Same as "region OR radius", but also triggers if some other given character's "special standby ended" flag is
    /// enabled, and uses an alternate delay in that case.
    ///
    /// Used by exactly two Haligtree Soldiers who watch each other in Haligtree.
    ///
    /// I've reordered the args since the `watch` character is basically compulsory.
    /// </summary>
    /// <param name="characterEntityID"></param>
    /// <param name="standbyAnimation"></param>
    /// <param name="cancelAnimation"></param>
    /// <param name="watchCharacterEntityID"></param>
    /// <param name="region"></param>
    /// <param name="radius"></param>
    /// <param name="delaySeconds"></param>
    /// <param name="alternateDelaySeconds"></param>
    /// <param name="handleGravityCollision"></param>
    /// <param name="onlyInBattleState"></param>
    /// <param name="onlyInAIState5"></param>
    /// <param name="onlyInAIState6"></param>
    
    /// <returns></returns>
    public static EMEVD.Instruction Anim_DamageRadiusORRegionBattle_ChrEndStandby(
        uint characterEntityID,
        int standbyAnimation,
        int cancelAnimation,
        uint watchCharacterEntityID,
        uint region = 0,
        float radius = 0,
        float delaySeconds = 0f,
        float alternateDelaySeconds = 0f,
        bool handleGravityCollision = false,
        bool onlyInBattleState = false,
        bool onlyInAIState5 = false,
        bool onlyInAIState6 = false)
    {
        return RunCommonEvent(
            CommonFuncID.Anim_DamageRadiusORRegionBattle_ChrEndStandby,
            characterEntityID, standbyAnimation, cancelAnimation,
            region, radius, delaySeconds,
            handleGravityCollision ? 1U : 0U,
            onlyInBattleState ? 1U : 0U,
            onlyInAIState5 ? 1U : 0U,
            onlyInAIState6 ? 1U : 0U,
            watchCharacterEntityID,
            alternateDelaySeconds);
    }
    
    #endregion
    
    #region Enemy AI Triggers

    /// <summary>
    /// Disables enemy AI and re-enables it when an 'active' player (human, blue phantom, white phantom, or black phantom
    /// with effect 3710) enters a trigger region OR the enemy is 'hurt' in any way:
    ///     - getting a status effect they aren't immune to
    ///     - being attacked by anyone
    ///     - getting StateInfo 2, 5, 6, 260, or 436 
    /// </summary>
    public static EMEVD.Instruction AI_DamageRegion(
        uint characterEntityID, uint regionEntityID, float delaySeconds = 0f, int animationID = -1)
    {
        return RunCommonEvent(CommonFuncID.AI_DamageRegion, characterEntityID, regionEntityID, delaySeconds,
            animationID);
    }
    
    /// <summary>
    /// Disables enemy AI and re-enables it when an 'active' player (human, blue phantom, white phantom, or black phantom
    /// with effect 3710) gets close enough OR the enemy is 'hurt' in any way:
    ///     - getting a status effect they aren't immune to
    ///     - being attacked by anyone
    ///     - getting StateInfo 2, 5, 6, 260, or 436 
    /// </summary>
    public static EMEVD.Instruction AI_DamageRadius(
        uint characterEntityID, float radius, float delaySeconds = 0f, int animationID = -1)
    {
        return RunCommonEvent(CommonFuncID.AI_DamageRadius, characterEntityID, radius, delaySeconds, animationID);
    }

    public static EMEVD.Instruction AI_DamageRadiusANDRegion(
        uint characterID, uint regionID, float radius, float delaySeconds = 0f, int animationID = -1)
    {
        return RunCommonEvent(
            CommonFuncID.AI_DamageRadiusANDRegion, characterID, regionID, radius, delaySeconds, animationID);
    }
    
    public static EMEVD.Instruction AI_DamageRadiusORRegion(
        uint characterID, uint regionID, float radius, float delaySeconds = 0f, int animationID = -1)
    {
        return RunCommonEvent(
            CommonFuncID.AI_DamageRadiusORRegion, characterID, regionID, radius, delaySeconds, animationID);
    }
    
    /// <summary>
    /// Variant of 90005250 without the trigger region or player type check.
    ///
    /// Used for, e.g., sleeping Albinaurics in Mohgwyn Palace. 
    /// </summary>
    public static EMEVD.Instruction AI_DamageOnly(
        uint characterEntityID, float delaySeconds = 0f, int animationID = -1)
    {
        return RunCommonEvent(CommonFuncID.AI_DamageOnly, characterEntityID, delaySeconds, animationID);
    }
    
    #endregion
    
    #region Character Management

    /// <summary>
    /// Disable `character` if `flag` is enabled, or wait for character to die (proportion 1 if a group ID is used) and
    /// enable that flag after waiting `seconds`. Awards `itemLotID` if non-zero, or forces dropped treasure on
    /// character (rather than killing them) if `itemIsDropped` is non-zero, although this is never used.
    ///
    /// Critical and commonly-used, obviously!
    /// </summary>
    public static EMEVD.Instruction NonRespawningCharacter(
        uint deadFlag, uint characterEntityID, int itemLotID = 0, float delaySeconds = 0f, bool itemIsDropped = false)
    {
        return RunCommonEvent(CommonFuncID.NonRespawningCharacter, deadFlag, characterEntityID, itemLotID,
            delaySeconds, itemIsDropped ? 1 : 0);
    }
    
    #endregion
    
    #region Caravans
    
    // TODO:
    // CommonFunc_90005420_ConnectToCaravan
    // CommonFunc_90005423_DisconnectFromCaravan
    
    #endregion
    
    #region Field Bosses

    /// <summary>
    /// Item lot is always awarded, never dropped, and awarded after reload despawn too (if item lot flag off).
    /// The delay argument is non-functional; the event always waits 5 seconds, so we just pass that in to be clear.
    ///
    /// The item lot ID argument is signed in the Award Item Lot instructions. However, since CommonFunc compares them
    /// against 0 to check if they should be used, we force a `uint` parameter here. Obviously this shouldn't matter
    /// unless some gigantic item lot IDs come into play.
    /// </summary>
    /// <param name="deadFlag"></param>
    /// <param name="extraFlag"></param>
    /// <param name="bossEntityID"></param>
    /// <param name="bannerRank"></param>
    /// <param name="itemLotID"></param>
    /// <returns></returns>
    public static EMEVD.Instruction FieldBossDeath(
        uint deadFlag, uint extraFlag, uint bossEntityID, FieldBossBannerRank bannerRank, uint itemLotID)
    {
        return RunCommonEvent(CommonFuncID.FieldBossDeath, deadFlag, extraFlag, bossEntityID, (uint)bannerRank, (int)itemLotID, 5f);
    }

    /// <summary>
    /// NOTE: Not used for Adula or Lansseax, but used for Magma Wyrms (Mt. Gelmir and Theodorix).
    /// </summary>
    public static EMEVD.Instruction FieldBossDeath_DragonWyrm(
        uint flag, uint extraFlag, uint characterEntityID, FieldBossBannerRank bannerRank, int itemLotID, int textID,
        float delaySeconds)
    {
        return RunCommonEvent(CommonFuncID.FieldBossDeath_DragonWyrm, flag, extraFlag, characterEntityID, 
            (uint)bannerRank, itemLotID, textID, delaySeconds);
    }

    /// <summary>
    /// Detects appropriate slot to use (1 to 3) based on threat level priority.
    /// </summary>
    public static EMEVD.Instruction ControlFieldBossHealthBar(
        uint characterEntityID, int nameID, uint threatLevel)
    {
        return RunCommonEvent(CommonFuncID.ControlFieldBossHealthBar, characterEntityID, nameID, threatLevel);
    }
    
    /// <summary>
    /// Enables 'heat up' (generic second phase' of field boss music in `ThreatLevel` slot when the given trigger flag
    /// is enabled or (if zero) boss falls below 55% health. Disables heat-up (and restarts the monitor) as appropriate
    /// when the boss dies or the music is stopped.
    /// </summary>
    public static EMEVD.Instruction ControlFieldBossMusicHeatup(
        uint characterEntityID, uint threatLevel, uint triggerFlag = 0)
    {
        return RunCommonEvent(CommonFuncID.ControlFieldBossMusicHeatup, characterEntityID, threatLevel, triggerFlag);
    }
    
    #endregion
}
