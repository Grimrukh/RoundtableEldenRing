using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class MENU_COMMON_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float soloPlayDeath_ToFadeOutTime
        {
            get => (float)row["soloPlayDeath_ToFadeOutTime"].Value;
            set => row["soloPlayDeath_ToFadeOutTime"].Value = value;
        }

        // Unknown.
        public float partyGhostDeath_ToFadeOutTime
        {
            get => (float)row["partyGhostDeath_ToFadeOutTime"].Value;
            set => row["partyGhostDeath_ToFadeOutTime"].Value = value;
        }

        // Unknown.
        public int playerMaxHpLimit
        {
            get => (int)row["playerMaxHpLimit"].Value;
            set => row["playerMaxHpLimit"].Value = value;
        }

        // Unknown.
        public int playerMaxMpLimit
        {
            get => (int)row["playerMaxMpLimit"].Value;
            set => row["playerMaxMpLimit"].Value = value;
        }

        // Unknown.
        public int playerMaxSpLimit
        {
            get => (int)row["playerMaxSpLimit"].Value;
            set => row["playerMaxSpLimit"].Value = value;
        }

        // Unknown.
        public float actionPanelChangeThreshold_Vel
        {
            get => (float)row["actionPanelChangeThreshold_Vel"].Value;
            set => row["actionPanelChangeThreshold_Vel"].Value = value;
        }

        // Unknown.
        public float actionPanelChangeThreshold_PassTime
        {
            get => (float)row["actionPanelChangeThreshold_PassTime"].Value;
            set => row["actionPanelChangeThreshold_PassTime"].Value = value;
        }

        // Unknown.
        public int kgIconVspace
        {
            get => (int)row["kgIconVspace"].Value;
            set => row["kgIconVspace"].Value = value;
        }

        // Unknown.
        public float worldMapCursorSelectRadius
        {
            get => (float)row["worldMapCursorSelectRadius"].Value;
            set => row["worldMapCursorSelectRadius"].Value = value;
        }

        // Unknown.
        public int decalPosOffsetX
        {
            get => (int)row["decalPosOffsetX"].Value;
            set => row["decalPosOffsetX"].Value = value;
        }

        // Unknown.
        public int decalPosOffsetY
        {
            get => (int)row["decalPosOffsetY"].Value;
            set => row["decalPosOffsetY"].Value = value;
        }

        // Unknown.
        public float targetStateSearchDurationTime
        {
            get => (float)row["targetStateSearchDurationTime"].Value;
            set => row["targetStateSearchDurationTime"].Value = value;
        }

        // Unknown.
        public float targetStateBattleDurationTime
        {
            get => (float)row["targetStateBattleDurationTime"].Value;
            set => row["targetStateBattleDurationTime"].Value = value;
        }

        // Unknown.
        public float worldMapCursorSpeed
        {
            get => (float)row["worldMapCursorSpeed"].Value;
            set => row["worldMapCursorSpeed"].Value = value;
        }

        // Unknown.
        public float worldMapCursorFirstDistance
        {
            get => (float)row["worldMapCursorFirstDistance"].Value;
            set => row["worldMapCursorFirstDistance"].Value = value;
        }

        // Unknown.
        public float worldMapCursorFirstDelay
        {
            get => (float)row["worldMapCursorFirstDelay"].Value;
            set => row["worldMapCursorFirstDelay"].Value = value;
        }

        // Unknown.
        public float worldMapCursorWaitTime
        {
            get => (float)row["worldMapCursorWaitTime"].Value;
            set => row["worldMapCursorWaitTime"].Value = value;
        }

        // Unknown.
        public float worldMapCursorSnapRadius
        {
            get => (float)row["worldMapCursorSnapRadius"].Value;
            set => row["worldMapCursorSnapRadius"].Value = value;
        }

        // Unknown.
        public float worldMapCursorSnapTime
        {
            get => (float)row["worldMapCursorSnapTime"].Value;
            set => row["worldMapCursorSnapTime"].Value = value;
        }

        // Unknown.
        public float itemGetLogAliveTime
        {
            get => (float)row["itemGetLogAliveTime"].Value;
            set => row["itemGetLogAliveTime"].Value = value;
        }

        // Unknown.
        public int playerMaxSaLimit
        {
            get => (int)row["playerMaxSaLimit"].Value;
            set => row["playerMaxSaLimit"].Value = value;
        }

        // Unknown.
        public uint worldMap_IsChangeableLayerEventFlagId
        {
            get => (uint)row["worldMap_IsChangeableLayerEventFlagId"].Value;
            set => row["worldMap_IsChangeableLayerEventFlagId"].Value = value;
        }

        // Unknown.
        public float worldMap_TravelMargin
        {
            get => (float)row["worldMap_TravelMargin"].Value;
            set => row["worldMap_TravelMargin"].Value = value;
        }

        // Unknown.
        public float systemAnnounceScrollBufferTime
        {
            get => (float)row["systemAnnounceScrollBufferTime"].Value;
            set => row["systemAnnounceScrollBufferTime"].Value = value;
        }

        // Unknown.
        public int systemAnnounceScrollSpeed
        {
            get => (int)row["systemAnnounceScrollSpeed"].Value;
            set => row["systemAnnounceScrollSpeed"].Value = value;
        }

        // Unknown.
        public float systemAnnounceNoScrollWaitTime
        {
            get => (float)row["systemAnnounceNoScrollWaitTime"].Value;
            set => row["systemAnnounceNoScrollWaitTime"].Value = value;
        }

        // Unknown.
        public byte systemAnnounceScrollCount
        {
            get => (byte)row["systemAnnounceScrollCount"].Value;
            set => row["systemAnnounceScrollCount"].Value = value;
        }

        // Unknown.
        public float compassMemoDispDistance
        {
            get => (float)row["compassMemoDispDistance"].Value;
            set => row["compassMemoDispDistance"].Value = value;
        }

        // Unknown.
        public float compassBonfireDispDistance
        {
            get => (float)row["compassBonfireDispDistance"].Value;
            set => row["compassBonfireDispDistance"].Value = value;
        }

        // Unknown.
        public float markerGoalThreshold
        {
            get => (float)row["markerGoalThreshold"].Value;
            set => row["markerGoalThreshold"].Value = value;
        }

        // Unknown.
        public float svSliderStep
        {
            get => (float)row["svSliderStep"].Value;
            set => row["svSliderStep"].Value = value;
        }

        // Unknown.
        public float preOpeningMovie_WaitSec
        {
            get => (float)row["preOpeningMovie_WaitSec"].Value;
            set => row["preOpeningMovie_WaitSec"].Value = value;
        }

        // Unknown.
        public float kgIconScale
        {
            get => (float)row["kgIconScale"].Value;
            set => row["kgIconScale"].Value = value;
        }

        // Unknown.
        public float kgIconScale_forTable
        {
            get => (float)row["kgIconScale_forTable"].Value;
            set => row["kgIconScale_forTable"].Value = value;
        }

        // Unknown.
        public int kgIconVspace_forTable
        {
            get => (int)row["kgIconVspace_forTable"].Value;
            set => row["kgIconVspace_forTable"].Value = value;
        }

        // Unknown.
        public float kgIconScale_forConfig
        {
            get => (float)row["kgIconScale_forConfig"].Value;
            set => row["kgIconScale_forConfig"].Value = value;
        }

        // Unknown.
        public int kgIconVspace_forConfig
        {
            get => (int)row["kgIconVspace_forConfig"].Value;
            set => row["kgIconVspace_forConfig"].Value = value;
        }

        // Unknown.
        public float worldMap_SearchRadius
        {
            get => (float)row["worldMap_SearchRadius"].Value;
            set => row["worldMap_SearchRadius"].Value = value;
        }

        // Unknown.
        public float tutorialDisplayTime
        {
            get => (float)row["tutorialDisplayTime"].Value;
            set => row["tutorialDisplayTime"].Value = value;
        }

        // Unknown.
        public float compassFriendHostInnerDistance
        {
            get => (float)row["compassFriendHostInnerDistance"].Value;
            set => row["compassFriendHostInnerDistance"].Value = value;
        }

        // Unknown.
        public float compassEnemyHostInnerDistance
        {
            get => (float)row["compassEnemyHostInnerDistance"].Value;
            set => row["compassEnemyHostInnerDistance"].Value = value;
        }

        // Unknown.
        public float compassFriendGuestInnerDistance
        {
            get => (float)row["compassFriendGuestInnerDistance"].Value;
            set => row["compassFriendGuestInnerDistance"].Value = value;
        }

        // Unknown.
        public float cutsceneKeyGuideAliveTime
        {
            get => (float)row["cutsceneKeyGuideAliveTime"].Value;
            set => row["cutsceneKeyGuideAliveTime"].Value = value;
        }

        // Unknown.
        public float autoHideHpThresholdRatio
        {
            get => (float)row["autoHideHpThresholdRatio"].Value;
            set => row["autoHideHpThresholdRatio"].Value = value;
        }

        // Unknown.
        public int autoHideHpThresholdValue
        {
            get => (int)row["autoHideHpThresholdValue"].Value;
            set => row["autoHideHpThresholdValue"].Value = value;
        }

        // Unknown.
        public float autoHideMpThresholdRatio
        {
            get => (float)row["autoHideMpThresholdRatio"].Value;
            set => row["autoHideMpThresholdRatio"].Value = value;
        }

        // Unknown.
        public int autoHideMpThresholdValue
        {
            get => (int)row["autoHideMpThresholdValue"].Value;
            set => row["autoHideMpThresholdValue"].Value = value;
        }

        // Unknown.
        public float autoHideSpThresholdRatio
        {
            get => (float)row["autoHideSpThresholdRatio"].Value;
            set => row["autoHideSpThresholdRatio"].Value = value;
        }

        // Unknown.
        public int autoHideSpThresholdValue
        {
            get => (int)row["autoHideSpThresholdValue"].Value;
            set => row["autoHideSpThresholdValue"].Value = value;
        }

        // Unknown.
        public float worldMapZoomAnimationTime
        {
            get => (float)row["worldMapZoomAnimationTime"].Value;
            set => row["worldMapZoomAnimationTime"].Value = value;
        }

        // Unknown.
        public float worldMapIconScaleMin
        {
            get => (float)row["worldMapIconScaleMin"].Value;
            set => row["worldMapIconScaleMin"].Value = value;
        }

        // Unknown.
        public float worldMap_TravelMargin_Point
        {
            get => (float)row["worldMap_TravelMargin_Point"].Value;
            set => row["worldMap_TravelMargin_Point"].Value = value;
        }

        // Unknown.
        public ushort enemyTagSafeLeft
        {
            get => (ushort)row["enemyTagSafeLeft"].Value;
            set => row["enemyTagSafeLeft"].Value = value;
        }

        // Unknown.
        public ushort enemyTagSafeRight
        {
            get => (ushort)row["enemyTagSafeRight"].Value;
            set => row["enemyTagSafeRight"].Value = value;
        }

        // Unknown.
        public ushort enemyTagSafeTop
        {
            get => (ushort)row["enemyTagSafeTop"].Value;
            set => row["enemyTagSafeTop"].Value = value;
        }

        // Unknown.
        public ushort enemyTagSafeBottom
        {
            get => (ushort)row["enemyTagSafeBottom"].Value;
            set => row["enemyTagSafeBottom"].Value = value;
        }

        // Unknown.
        public uint pcHorseHpRecoverDispThreshold
        {
            get => (uint)row["pcHorseHpRecoverDispThreshold"].Value;
            set => row["pcHorseHpRecoverDispThreshold"].Value = value;
        }

        public object this[string fieldName]
        {
            get => row[fieldName].Value;
            set => row[fieldName].Value = value;
        }
    }
    
    /// <summary>
    /// Construct from a standard `PARAM` read from disk.
    /// </summary>
    public MENU_COMMON_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public MENU_COMMON_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
