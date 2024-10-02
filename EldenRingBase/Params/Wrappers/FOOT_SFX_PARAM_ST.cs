using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class FOOT_SFX_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public uint sfxId_00
        {
            get => (uint)row["sfxId_00"].Value;
            set => row["sfxId_00"].Value = value;
        }

        // Unknown.
        public uint sfxId_01
        {
            get => (uint)row["sfxId_01"].Value;
            set => row["sfxId_01"].Value = value;
        }

        // Unknown.
        public uint sfxId_02
        {
            get => (uint)row["sfxId_02"].Value;
            set => row["sfxId_02"].Value = value;
        }

        // Unknown.
        public uint sfxId_03
        {
            get => (uint)row["sfxId_03"].Value;
            set => row["sfxId_03"].Value = value;
        }

        // Unknown.
        public uint sfxId_04
        {
            get => (uint)row["sfxId_04"].Value;
            set => row["sfxId_04"].Value = value;
        }

        // Unknown.
        public uint sfxId_05
        {
            get => (uint)row["sfxId_05"].Value;
            set => row["sfxId_05"].Value = value;
        }

        // Unknown.
        public uint sfxId_06
        {
            get => (uint)row["sfxId_06"].Value;
            set => row["sfxId_06"].Value = value;
        }

        // Unknown.
        public uint sfxId_07
        {
            get => (uint)row["sfxId_07"].Value;
            set => row["sfxId_07"].Value = value;
        }

        // Unknown.
        public uint sfxId_08
        {
            get => (uint)row["sfxId_08"].Value;
            set => row["sfxId_08"].Value = value;
        }

        // Unknown.
        public uint sfxId_09
        {
            get => (uint)row["sfxId_09"].Value;
            set => row["sfxId_09"].Value = value;
        }

        // Unknown.
        public uint sfxId_10
        {
            get => (uint)row["sfxId_10"].Value;
            set => row["sfxId_10"].Value = value;
        }

        // Unknown.
        public uint sfxId_11
        {
            get => (uint)row["sfxId_11"].Value;
            set => row["sfxId_11"].Value = value;
        }

        // Unknown.
        public uint sfxId_12
        {
            get => (uint)row["sfxId_12"].Value;
            set => row["sfxId_12"].Value = value;
        }

        // Unknown.
        public uint sfxId_13
        {
            get => (uint)row["sfxId_13"].Value;
            set => row["sfxId_13"].Value = value;
        }

        // Unknown.
        public uint sfxId_14
        {
            get => (uint)row["sfxId_14"].Value;
            set => row["sfxId_14"].Value = value;
        }

        // Unknown.
        public uint sfxId_15
        {
            get => (uint)row["sfxId_15"].Value;
            set => row["sfxId_15"].Value = value;
        }

        // Unknown.
        public uint sfxId_16
        {
            get => (uint)row["sfxId_16"].Value;
            set => row["sfxId_16"].Value = value;
        }

        // Unknown.
        public uint sfxId_17
        {
            get => (uint)row["sfxId_17"].Value;
            set => row["sfxId_17"].Value = value;
        }

        // Unknown.
        public uint sfxId_18
        {
            get => (uint)row["sfxId_18"].Value;
            set => row["sfxId_18"].Value = value;
        }

        // Unknown.
        public uint sfxId_19
        {
            get => (uint)row["sfxId_19"].Value;
            set => row["sfxId_19"].Value = value;
        }

        // Unknown.
        public uint sfxId_20
        {
            get => (uint)row["sfxId_20"].Value;
            set => row["sfxId_20"].Value = value;
        }

        // Unknown.
        public uint sfxId_21
        {
            get => (uint)row["sfxId_21"].Value;
            set => row["sfxId_21"].Value = value;
        }

        // Unknown.
        public uint sfxId_22
        {
            get => (uint)row["sfxId_22"].Value;
            set => row["sfxId_22"].Value = value;
        }

        // Unknown.
        public uint sfxId_23
        {
            get => (uint)row["sfxId_23"].Value;
            set => row["sfxId_23"].Value = value;
        }

        // Unknown.
        public uint sfxId_24
        {
            get => (uint)row["sfxId_24"].Value;
            set => row["sfxId_24"].Value = value;
        }

        // Unknown.
        public uint sfxId_25
        {
            get => (uint)row["sfxId_25"].Value;
            set => row["sfxId_25"].Value = value;
        }

        // Unknown.
        public uint sfxId_26
        {
            get => (uint)row["sfxId_26"].Value;
            set => row["sfxId_26"].Value = value;
        }

        // Unknown.
        public uint sfxId_27
        {
            get => (uint)row["sfxId_27"].Value;
            set => row["sfxId_27"].Value = value;
        }

        // Unknown.
        public uint sfxId_28
        {
            get => (uint)row["sfxId_28"].Value;
            set => row["sfxId_28"].Value = value;
        }

        // Unknown.
        public uint sfxId_29
        {
            get => (uint)row["sfxId_29"].Value;
            set => row["sfxId_29"].Value = value;
        }

        // Unknown.
        public uint sfxId_30
        {
            get => (uint)row["sfxId_30"].Value;
            set => row["sfxId_30"].Value = value;
        }

        // Unknown.
        public uint sfxId_31
        {
            get => (uint)row["sfxId_31"].Value;
            set => row["sfxId_31"].Value = value;
        }

        // Unknown.
        public uint sfxId_32
        {
            get => (uint)row["sfxId_32"].Value;
            set => row["sfxId_32"].Value = value;
        }

        // Unknown.
        public uint sfxId_33
        {
            get => (uint)row["sfxId_33"].Value;
            set => row["sfxId_33"].Value = value;
        }

        // Unknown.
        public uint sfxId_34
        {
            get => (uint)row["sfxId_34"].Value;
            set => row["sfxId_34"].Value = value;
        }

        // Unknown.
        public uint sfxId_35
        {
            get => (uint)row["sfxId_35"].Value;
            set => row["sfxId_35"].Value = value;
        }

        // Unknown.
        public uint sfxId_36
        {
            get => (uint)row["sfxId_36"].Value;
            set => row["sfxId_36"].Value = value;
        }

        // Unknown.
        public uint sfxId_37
        {
            get => (uint)row["sfxId_37"].Value;
            set => row["sfxId_37"].Value = value;
        }

        // Unknown.
        public uint sfxId_38
        {
            get => (uint)row["sfxId_38"].Value;
            set => row["sfxId_38"].Value = value;
        }

        // Unknown.
        public uint sfxId_39
        {
            get => (uint)row["sfxId_39"].Value;
            set => row["sfxId_39"].Value = value;
        }

        // Unknown.
        public uint sfxId_40
        {
            get => (uint)row["sfxId_40"].Value;
            set => row["sfxId_40"].Value = value;
        }

        // Unknown.
        public uint sfxId_41
        {
            get => (uint)row["sfxId_41"].Value;
            set => row["sfxId_41"].Value = value;
        }

        // Unknown.
        public uint sfxId_42
        {
            get => (uint)row["sfxId_42"].Value;
            set => row["sfxId_42"].Value = value;
        }

        // Unknown.
        public uint sfxId_43
        {
            get => (uint)row["sfxId_43"].Value;
            set => row["sfxId_43"].Value = value;
        }

        // Unknown.
        public uint sfxId_44
        {
            get => (uint)row["sfxId_44"].Value;
            set => row["sfxId_44"].Value = value;
        }

        // Unknown.
        public uint sfxId_45
        {
            get => (uint)row["sfxId_45"].Value;
            set => row["sfxId_45"].Value = value;
        }

        // Unknown.
        public uint sfxId_46
        {
            get => (uint)row["sfxId_46"].Value;
            set => row["sfxId_46"].Value = value;
        }

        // Unknown.
        public uint sfxId_47
        {
            get => (uint)row["sfxId_47"].Value;
            set => row["sfxId_47"].Value = value;
        }

        // Unknown.
        public uint sfxId_48
        {
            get => (uint)row["sfxId_48"].Value;
            set => row["sfxId_48"].Value = value;
        }

        // Unknown.
        public uint sfxId_49
        {
            get => (uint)row["sfxId_49"].Value;
            set => row["sfxId_49"].Value = value;
        }

        // Unknown.
        public uint sfxId_50
        {
            get => (uint)row["sfxId_50"].Value;
            set => row["sfxId_50"].Value = value;
        }

        // Unknown.
        public uint sfxId_51
        {
            get => (uint)row["sfxId_51"].Value;
            set => row["sfxId_51"].Value = value;
        }

        // Unknown.
        public uint sfxId_52
        {
            get => (uint)row["sfxId_52"].Value;
            set => row["sfxId_52"].Value = value;
        }

        // Unknown.
        public uint sfxId_53
        {
            get => (uint)row["sfxId_53"].Value;
            set => row["sfxId_53"].Value = value;
        }

        // Unknown.
        public uint sfxId_54
        {
            get => (uint)row["sfxId_54"].Value;
            set => row["sfxId_54"].Value = value;
        }

        // Unknown.
        public uint sfxId_55
        {
            get => (uint)row["sfxId_55"].Value;
            set => row["sfxId_55"].Value = value;
        }

        // Unknown.
        public uint sfxId_56
        {
            get => (uint)row["sfxId_56"].Value;
            set => row["sfxId_56"].Value = value;
        }

        // Unknown.
        public uint sfxId_57
        {
            get => (uint)row["sfxId_57"].Value;
            set => row["sfxId_57"].Value = value;
        }

        // Unknown.
        public uint sfxId_58
        {
            get => (uint)row["sfxId_58"].Value;
            set => row["sfxId_58"].Value = value;
        }

        // Unknown.
        public uint sfxId_59
        {
            get => (uint)row["sfxId_59"].Value;
            set => row["sfxId_59"].Value = value;
        }

        // Unknown.
        public uint sfxId_60
        {
            get => (uint)row["sfxId_60"].Value;
            set => row["sfxId_60"].Value = value;
        }

        // Unknown.
        public uint sfxId_61
        {
            get => (uint)row["sfxId_61"].Value;
            set => row["sfxId_61"].Value = value;
        }

        // Unknown.
        public uint sfxId_62
        {
            get => (uint)row["sfxId_62"].Value;
            set => row["sfxId_62"].Value = value;
        }

        // Unknown.
        public uint sfxId_63
        {
            get => (uint)row["sfxId_63"].Value;
            set => row["sfxId_63"].Value = value;
        }

        // Unknown.
        public uint sfxId_64
        {
            get => (uint)row["sfxId_64"].Value;
            set => row["sfxId_64"].Value = value;
        }

        // Unknown.
        public uint sfxId_65
        {
            get => (uint)row["sfxId_65"].Value;
            set => row["sfxId_65"].Value = value;
        }

        // Unknown.
        public uint sfxId_66
        {
            get => (uint)row["sfxId_66"].Value;
            set => row["sfxId_66"].Value = value;
        }

        // Unknown.
        public uint sfxId_67
        {
            get => (uint)row["sfxId_67"].Value;
            set => row["sfxId_67"].Value = value;
        }

        // Unknown.
        public uint sfxId_68
        {
            get => (uint)row["sfxId_68"].Value;
            set => row["sfxId_68"].Value = value;
        }

        // Unknown.
        public uint sfxId_69
        {
            get => (uint)row["sfxId_69"].Value;
            set => row["sfxId_69"].Value = value;
        }

        // Unknown.
        public uint sfxId_70
        {
            get => (uint)row["sfxId_70"].Value;
            set => row["sfxId_70"].Value = value;
        }

        // Unknown.
        public uint sfxId_71
        {
            get => (uint)row["sfxId_71"].Value;
            set => row["sfxId_71"].Value = value;
        }

        // Unknown.
        public uint sfxId_72
        {
            get => (uint)row["sfxId_72"].Value;
            set => row["sfxId_72"].Value = value;
        }

        // Unknown.
        public uint sfxId_73
        {
            get => (uint)row["sfxId_73"].Value;
            set => row["sfxId_73"].Value = value;
        }

        // Unknown.
        public uint sfxId_74
        {
            get => (uint)row["sfxId_74"].Value;
            set => row["sfxId_74"].Value = value;
        }

        // Unknown.
        public uint sfxId_75
        {
            get => (uint)row["sfxId_75"].Value;
            set => row["sfxId_75"].Value = value;
        }

        // Unknown.
        public uint sfxId_76
        {
            get => (uint)row["sfxId_76"].Value;
            set => row["sfxId_76"].Value = value;
        }

        // Unknown.
        public uint sfxId_77
        {
            get => (uint)row["sfxId_77"].Value;
            set => row["sfxId_77"].Value = value;
        }

        // Unknown.
        public uint sfxId_78
        {
            get => (uint)row["sfxId_78"].Value;
            set => row["sfxId_78"].Value = value;
        }

        // Unknown.
        public uint sfxId_79
        {
            get => (uint)row["sfxId_79"].Value;
            set => row["sfxId_79"].Value = value;
        }

        // Unknown.
        public uint sfxId_80
        {
            get => (uint)row["sfxId_80"].Value;
            set => row["sfxId_80"].Value = value;
        }

        // Unknown.
        public uint sfxId_81
        {
            get => (uint)row["sfxId_81"].Value;
            set => row["sfxId_81"].Value = value;
        }

        // Unknown.
        public uint sfxId_82
        {
            get => (uint)row["sfxId_82"].Value;
            set => row["sfxId_82"].Value = value;
        }

        // Unknown.
        public uint sfxId_83
        {
            get => (uint)row["sfxId_83"].Value;
            set => row["sfxId_83"].Value = value;
        }

        // Unknown.
        public uint sfxId_84
        {
            get => (uint)row["sfxId_84"].Value;
            set => row["sfxId_84"].Value = value;
        }

        // Unknown.
        public uint sfxId_85
        {
            get => (uint)row["sfxId_85"].Value;
            set => row["sfxId_85"].Value = value;
        }

        // Unknown.
        public uint sfxId_86
        {
            get => (uint)row["sfxId_86"].Value;
            set => row["sfxId_86"].Value = value;
        }

        // Unknown.
        public uint sfxId_87
        {
            get => (uint)row["sfxId_87"].Value;
            set => row["sfxId_87"].Value = value;
        }

        // Unknown.
        public uint sfxId_88
        {
            get => (uint)row["sfxId_88"].Value;
            set => row["sfxId_88"].Value = value;
        }

        // Unknown.
        public uint sfxId_89
        {
            get => (uint)row["sfxId_89"].Value;
            set => row["sfxId_89"].Value = value;
        }

        // Unknown.
        public uint sfxId_90
        {
            get => (uint)row["sfxId_90"].Value;
            set => row["sfxId_90"].Value = value;
        }

        // Unknown.
        public uint sfxId_91
        {
            get => (uint)row["sfxId_91"].Value;
            set => row["sfxId_91"].Value = value;
        }

        // Unknown.
        public uint sfxId_92
        {
            get => (uint)row["sfxId_92"].Value;
            set => row["sfxId_92"].Value = value;
        }

        // Unknown.
        public uint sfxId_93
        {
            get => (uint)row["sfxId_93"].Value;
            set => row["sfxId_93"].Value = value;
        }

        // Unknown.
        public uint sfxId_94
        {
            get => (uint)row["sfxId_94"].Value;
            set => row["sfxId_94"].Value = value;
        }

        // Unknown.
        public uint sfxId_95
        {
            get => (uint)row["sfxId_95"].Value;
            set => row["sfxId_95"].Value = value;
        }

        // Unknown.
        public uint sfxId_96
        {
            get => (uint)row["sfxId_96"].Value;
            set => row["sfxId_96"].Value = value;
        }

        // Unknown.
        public uint sfxId_97
        {
            get => (uint)row["sfxId_97"].Value;
            set => row["sfxId_97"].Value = value;
        }

        // Unknown.
        public uint sfxId_98
        {
            get => (uint)row["sfxId_98"].Value;
            set => row["sfxId_98"].Value = value;
        }

        // Unknown.
        public uint sfxId_99
        {
            get => (uint)row["sfxId_99"].Value;
            set => row["sfxId_99"].Value = value;
        }

        // Unknown.
        public uint sfxId_100
        {
            get => (uint)row["sfxId_100"].Value;
            set => row["sfxId_100"].Value = value;
        }

        // Unknown.
        public uint sfxId_101
        {
            get => (uint)row["sfxId_101"].Value;
            set => row["sfxId_101"].Value = value;
        }

        // Unknown.
        public uint sfxId_102
        {
            get => (uint)row["sfxId_102"].Value;
            set => row["sfxId_102"].Value = value;
        }

        // Unknown.
        public uint sfxId_103
        {
            get => (uint)row["sfxId_103"].Value;
            set => row["sfxId_103"].Value = value;
        }

        // Unknown.
        public uint sfxId_104
        {
            get => (uint)row["sfxId_104"].Value;
            set => row["sfxId_104"].Value = value;
        }

        // Unknown.
        public uint sfxId_105
        {
            get => (uint)row["sfxId_105"].Value;
            set => row["sfxId_105"].Value = value;
        }

        // Unknown.
        public uint sfxId_106
        {
            get => (uint)row["sfxId_106"].Value;
            set => row["sfxId_106"].Value = value;
        }

        // Unknown.
        public uint sfxId_107
        {
            get => (uint)row["sfxId_107"].Value;
            set => row["sfxId_107"].Value = value;
        }

        // Unknown.
        public uint sfxId_108
        {
            get => (uint)row["sfxId_108"].Value;
            set => row["sfxId_108"].Value = value;
        }

        // Unknown.
        public uint sfxId_109
        {
            get => (uint)row["sfxId_109"].Value;
            set => row["sfxId_109"].Value = value;
        }

        // Unknown.
        public uint sfxId_110
        {
            get => (uint)row["sfxId_110"].Value;
            set => row["sfxId_110"].Value = value;
        }

        // Unknown.
        public uint sfxId_111
        {
            get => (uint)row["sfxId_111"].Value;
            set => row["sfxId_111"].Value = value;
        }

        // Unknown.
        public uint sfxId_112
        {
            get => (uint)row["sfxId_112"].Value;
            set => row["sfxId_112"].Value = value;
        }

        // Unknown.
        public uint sfxId_113
        {
            get => (uint)row["sfxId_113"].Value;
            set => row["sfxId_113"].Value = value;
        }

        // Unknown.
        public uint sfxId_114
        {
            get => (uint)row["sfxId_114"].Value;
            set => row["sfxId_114"].Value = value;
        }

        // Unknown.
        public uint sfxId_115
        {
            get => (uint)row["sfxId_115"].Value;
            set => row["sfxId_115"].Value = value;
        }

        // Unknown.
        public uint sfxId_116
        {
            get => (uint)row["sfxId_116"].Value;
            set => row["sfxId_116"].Value = value;
        }

        // Unknown.
        public uint sfxId_117
        {
            get => (uint)row["sfxId_117"].Value;
            set => row["sfxId_117"].Value = value;
        }

        // Unknown.
        public uint sfxId_118
        {
            get => (uint)row["sfxId_118"].Value;
            set => row["sfxId_118"].Value = value;
        }

        // Unknown.
        public uint sfxId_119
        {
            get => (uint)row["sfxId_119"].Value;
            set => row["sfxId_119"].Value = value;
        }

        // Unknown.
        public uint sfxId_120
        {
            get => (uint)row["sfxId_120"].Value;
            set => row["sfxId_120"].Value = value;
        }

        // Unknown.
        public uint sfxId_121
        {
            get => (uint)row["sfxId_121"].Value;
            set => row["sfxId_121"].Value = value;
        }

        // Unknown.
        public uint sfxId_122
        {
            get => (uint)row["sfxId_122"].Value;
            set => row["sfxId_122"].Value = value;
        }

        // Unknown.
        public uint sfxId_123
        {
            get => (uint)row["sfxId_123"].Value;
            set => row["sfxId_123"].Value = value;
        }

        // Unknown.
        public uint sfxId_124
        {
            get => (uint)row["sfxId_124"].Value;
            set => row["sfxId_124"].Value = value;
        }

        // Unknown.
        public uint sfxId_125
        {
            get => (uint)row["sfxId_125"].Value;
            set => row["sfxId_125"].Value = value;
        }

        // Unknown.
        public uint sfxId_126
        {
            get => (uint)row["sfxId_126"].Value;
            set => row["sfxId_126"].Value = value;
        }

        // Unknown.
        public uint sfxId_127
        {
            get => (uint)row["sfxId_127"].Value;
            set => row["sfxId_127"].Value = value;
        }

        // Unknown.
        public uint sfxId_128
        {
            get => (uint)row["sfxId_128"].Value;
            set => row["sfxId_128"].Value = value;
        }

        // Unknown.
        public uint sfxId_129
        {
            get => (uint)row["sfxId_129"].Value;
            set => row["sfxId_129"].Value = value;
        }

        // Unknown.
        public uint sfxId_130
        {
            get => (uint)row["sfxId_130"].Value;
            set => row["sfxId_130"].Value = value;
        }

        // Unknown.
        public uint sfxId_131
        {
            get => (uint)row["sfxId_131"].Value;
            set => row["sfxId_131"].Value = value;
        }

        // Unknown.
        public uint sfxId_132
        {
            get => (uint)row["sfxId_132"].Value;
            set => row["sfxId_132"].Value = value;
        }

        // Unknown.
        public uint sfxId_133
        {
            get => (uint)row["sfxId_133"].Value;
            set => row["sfxId_133"].Value = value;
        }

        // Unknown.
        public uint sfxId_134
        {
            get => (uint)row["sfxId_134"].Value;
            set => row["sfxId_134"].Value = value;
        }

        // Unknown.
        public uint sfxId_135
        {
            get => (uint)row["sfxId_135"].Value;
            set => row["sfxId_135"].Value = value;
        }

        // Unknown.
        public uint sfxId_136
        {
            get => (uint)row["sfxId_136"].Value;
            set => row["sfxId_136"].Value = value;
        }

        // Unknown.
        public uint sfxId_137
        {
            get => (uint)row["sfxId_137"].Value;
            set => row["sfxId_137"].Value = value;
        }

        // Unknown.
        public uint sfxId_138
        {
            get => (uint)row["sfxId_138"].Value;
            set => row["sfxId_138"].Value = value;
        }

        // Unknown.
        public uint sfxId_139
        {
            get => (uint)row["sfxId_139"].Value;
            set => row["sfxId_139"].Value = value;
        }

        // Unknown.
        public uint sfxId_140
        {
            get => (uint)row["sfxId_140"].Value;
            set => row["sfxId_140"].Value = value;
        }

        // Unknown.
        public uint sfxId_141
        {
            get => (uint)row["sfxId_141"].Value;
            set => row["sfxId_141"].Value = value;
        }

        // Unknown.
        public uint sfxId_142
        {
            get => (uint)row["sfxId_142"].Value;
            set => row["sfxId_142"].Value = value;
        }

        // Unknown.
        public uint sfxId_143
        {
            get => (uint)row["sfxId_143"].Value;
            set => row["sfxId_143"].Value = value;
        }

        // Unknown.
        public uint sfxId_144
        {
            get => (uint)row["sfxId_144"].Value;
            set => row["sfxId_144"].Value = value;
        }

        // Unknown.
        public uint sfxId_145
        {
            get => (uint)row["sfxId_145"].Value;
            set => row["sfxId_145"].Value = value;
        }

        // Unknown.
        public uint sfxId_146
        {
            get => (uint)row["sfxId_146"].Value;
            set => row["sfxId_146"].Value = value;
        }

        // Unknown.
        public uint sfxId_147
        {
            get => (uint)row["sfxId_147"].Value;
            set => row["sfxId_147"].Value = value;
        }

        // Unknown.
        public uint sfxId_148
        {
            get => (uint)row["sfxId_148"].Value;
            set => row["sfxId_148"].Value = value;
        }

        // Unknown.
        public uint sfxId_149
        {
            get => (uint)row["sfxId_149"].Value;
            set => row["sfxId_149"].Value = value;
        }

        // Unknown.
        public uint sfxId_150
        {
            get => (uint)row["sfxId_150"].Value;
            set => row["sfxId_150"].Value = value;
        }

        // Unknown.
        public uint sfxId_151
        {
            get => (uint)row["sfxId_151"].Value;
            set => row["sfxId_151"].Value = value;
        }

        // Unknown.
        public uint sfxId_152
        {
            get => (uint)row["sfxId_152"].Value;
            set => row["sfxId_152"].Value = value;
        }

        // Unknown.
        public uint sfxId_153
        {
            get => (uint)row["sfxId_153"].Value;
            set => row["sfxId_153"].Value = value;
        }

        // Unknown.
        public uint sfxId_154
        {
            get => (uint)row["sfxId_154"].Value;
            set => row["sfxId_154"].Value = value;
        }

        // Unknown.
        public uint sfxId_155
        {
            get => (uint)row["sfxId_155"].Value;
            set => row["sfxId_155"].Value = value;
        }

        // Unknown.
        public uint sfxId_156
        {
            get => (uint)row["sfxId_156"].Value;
            set => row["sfxId_156"].Value = value;
        }

        // Unknown.
        public uint sfxId_157
        {
            get => (uint)row["sfxId_157"].Value;
            set => row["sfxId_157"].Value = value;
        }

        // Unknown.
        public uint sfxId_158
        {
            get => (uint)row["sfxId_158"].Value;
            set => row["sfxId_158"].Value = value;
        }

        // Unknown.
        public uint sfxId_159
        {
            get => (uint)row["sfxId_159"].Value;
            set => row["sfxId_159"].Value = value;
        }

        // Unknown.
        public uint sfxId_160
        {
            get => (uint)row["sfxId_160"].Value;
            set => row["sfxId_160"].Value = value;
        }

        // Unknown.
        public uint sfxId_161
        {
            get => (uint)row["sfxId_161"].Value;
            set => row["sfxId_161"].Value = value;
        }

        // Unknown.
        public uint sfxId_162
        {
            get => (uint)row["sfxId_162"].Value;
            set => row["sfxId_162"].Value = value;
        }

        // Unknown.
        public uint sfxId_163
        {
            get => (uint)row["sfxId_163"].Value;
            set => row["sfxId_163"].Value = value;
        }

        // Unknown.
        public uint sfxId_164
        {
            get => (uint)row["sfxId_164"].Value;
            set => row["sfxId_164"].Value = value;
        }

        // Unknown.
        public uint sfxId_165
        {
            get => (uint)row["sfxId_165"].Value;
            set => row["sfxId_165"].Value = value;
        }

        // Unknown.
        public uint sfxId_166
        {
            get => (uint)row["sfxId_166"].Value;
            set => row["sfxId_166"].Value = value;
        }

        // Unknown.
        public uint sfxId_167
        {
            get => (uint)row["sfxId_167"].Value;
            set => row["sfxId_167"].Value = value;
        }

        // Unknown.
        public uint sfxId_168
        {
            get => (uint)row["sfxId_168"].Value;
            set => row["sfxId_168"].Value = value;
        }

        // Unknown.
        public uint sfxId_169
        {
            get => (uint)row["sfxId_169"].Value;
            set => row["sfxId_169"].Value = value;
        }

        // Unknown.
        public uint sfxId_170
        {
            get => (uint)row["sfxId_170"].Value;
            set => row["sfxId_170"].Value = value;
        }

        // Unknown.
        public uint sfxId_171
        {
            get => (uint)row["sfxId_171"].Value;
            set => row["sfxId_171"].Value = value;
        }

        // Unknown.
        public uint sfxId_172
        {
            get => (uint)row["sfxId_172"].Value;
            set => row["sfxId_172"].Value = value;
        }

        // Unknown.
        public uint sfxId_173
        {
            get => (uint)row["sfxId_173"].Value;
            set => row["sfxId_173"].Value = value;
        }

        // Unknown.
        public uint sfxId_174
        {
            get => (uint)row["sfxId_174"].Value;
            set => row["sfxId_174"].Value = value;
        }

        // Unknown.
        public uint sfxId_175
        {
            get => (uint)row["sfxId_175"].Value;
            set => row["sfxId_175"].Value = value;
        }

        // Unknown.
        public uint sfxId_176
        {
            get => (uint)row["sfxId_176"].Value;
            set => row["sfxId_176"].Value = value;
        }

        // Unknown.
        public uint sfxId_177
        {
            get => (uint)row["sfxId_177"].Value;
            set => row["sfxId_177"].Value = value;
        }

        // Unknown.
        public uint sfxId_178
        {
            get => (uint)row["sfxId_178"].Value;
            set => row["sfxId_178"].Value = value;
        }

        // Unknown.
        public uint sfxId_179
        {
            get => (uint)row["sfxId_179"].Value;
            set => row["sfxId_179"].Value = value;
        }

        // Unknown.
        public uint sfxId_180
        {
            get => (uint)row["sfxId_180"].Value;
            set => row["sfxId_180"].Value = value;
        }

        // Unknown.
        public uint sfxId_181
        {
            get => (uint)row["sfxId_181"].Value;
            set => row["sfxId_181"].Value = value;
        }

        // Unknown.
        public uint sfxId_182
        {
            get => (uint)row["sfxId_182"].Value;
            set => row["sfxId_182"].Value = value;
        }

        // Unknown.
        public uint sfxId_183
        {
            get => (uint)row["sfxId_183"].Value;
            set => row["sfxId_183"].Value = value;
        }

        // Unknown.
        public uint sfxId_184
        {
            get => (uint)row["sfxId_184"].Value;
            set => row["sfxId_184"].Value = value;
        }

        // Unknown.
        public uint sfxId_185
        {
            get => (uint)row["sfxId_185"].Value;
            set => row["sfxId_185"].Value = value;
        }

        // Unknown.
        public uint sfxId_186
        {
            get => (uint)row["sfxId_186"].Value;
            set => row["sfxId_186"].Value = value;
        }

        // Unknown.
        public uint sfxId_187
        {
            get => (uint)row["sfxId_187"].Value;
            set => row["sfxId_187"].Value = value;
        }

        // Unknown.
        public uint sfxId_188
        {
            get => (uint)row["sfxId_188"].Value;
            set => row["sfxId_188"].Value = value;
        }

        // Unknown.
        public uint sfxId_189
        {
            get => (uint)row["sfxId_189"].Value;
            set => row["sfxId_189"].Value = value;
        }

        // Unknown.
        public uint sfxId_190
        {
            get => (uint)row["sfxId_190"].Value;
            set => row["sfxId_190"].Value = value;
        }

        // Unknown.
        public uint sfxId_191
        {
            get => (uint)row["sfxId_191"].Value;
            set => row["sfxId_191"].Value = value;
        }

        // Unknown.
        public uint sfxId_192
        {
            get => (uint)row["sfxId_192"].Value;
            set => row["sfxId_192"].Value = value;
        }

        // Unknown.
        public uint sfxId_193
        {
            get => (uint)row["sfxId_193"].Value;
            set => row["sfxId_193"].Value = value;
        }

        // Unknown.
        public uint sfxId_194
        {
            get => (uint)row["sfxId_194"].Value;
            set => row["sfxId_194"].Value = value;
        }

        // Unknown.
        public uint sfxId_195
        {
            get => (uint)row["sfxId_195"].Value;
            set => row["sfxId_195"].Value = value;
        }

        // Unknown.
        public uint sfxId_196
        {
            get => (uint)row["sfxId_196"].Value;
            set => row["sfxId_196"].Value = value;
        }

        // Unknown.
        public uint sfxId_197
        {
            get => (uint)row["sfxId_197"].Value;
            set => row["sfxId_197"].Value = value;
        }

        // Unknown.
        public uint sfxId_198
        {
            get => (uint)row["sfxId_198"].Value;
            set => row["sfxId_198"].Value = value;
        }

        // Unknown.
        public uint sfxId_199
        {
            get => (uint)row["sfxId_199"].Value;
            set => row["sfxId_199"].Value = value;
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
    public FOOT_SFX_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public FOOT_SFX_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
