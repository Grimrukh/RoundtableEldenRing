using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class NPC_AI_BEHAVIOR_PROBABILITY_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public short param000
        {
            get => (short)row["param000"].Value;
            set => row["param000"].Value = value;
        }

        // Unknown.
        public short param001
        {
            get => (short)row["param001"].Value;
            set => row["param001"].Value = value;
        }

        // Unknown.
        public short param002
        {
            get => (short)row["param002"].Value;
            set => row["param002"].Value = value;
        }

        // Unknown.
        public short param003
        {
            get => (short)row["param003"].Value;
            set => row["param003"].Value = value;
        }

        // Unknown.
        public short param004
        {
            get => (short)row["param004"].Value;
            set => row["param004"].Value = value;
        }

        // Unknown.
        public short param005
        {
            get => (short)row["param005"].Value;
            set => row["param005"].Value = value;
        }

        // Unknown.
        public short param006
        {
            get => (short)row["param006"].Value;
            set => row["param006"].Value = value;
        }

        // Unknown.
        public short param007
        {
            get => (short)row["param007"].Value;
            set => row["param007"].Value = value;
        }

        // Unknown.
        public short param008
        {
            get => (short)row["param008"].Value;
            set => row["param008"].Value = value;
        }

        public short param009
        {
            get => (short)row["param009"].Value;
            set => row["param009"].Value = value;
        }

        // Unknown.
        public short param010
        {
            get => (short)row["param010"].Value;
            set => row["param010"].Value = value;
        }

        // Unknown.
        public short param011
        {
            get => (short)row["param011"].Value;
            set => row["param011"].Value = value;
        }

        public short param012
        {
            get => (short)row["param012"].Value;
            set => row["param012"].Value = value;
        }

        // Unknown.
        public short param013
        {
            get => (short)row["param013"].Value;
            set => row["param013"].Value = value;
        }

        // Unknown.
        public short param014
        {
            get => (short)row["param014"].Value;
            set => row["param014"].Value = value;
        }

        // Unknown.
        public short param015
        {
            get => (short)row["param015"].Value;
            set => row["param015"].Value = value;
        }

        // Unknown.
        public short param016
        {
            get => (short)row["param016"].Value;
            set => row["param016"].Value = value;
        }

        // Unknown.
        public short param017
        {
            get => (short)row["param017"].Value;
            set => row["param017"].Value = value;
        }

        public short param018
        {
            get => (short)row["param018"].Value;
            set => row["param018"].Value = value;
        }

        public short param019
        {
            get => (short)row["param019"].Value;
            set => row["param019"].Value = value;
        }

        // Unknown.
        public short param020
        {
            get => (short)row["param020"].Value;
            set => row["param020"].Value = value;
        }

        // Unknown.
        public short param021
        {
            get => (short)row["param021"].Value;
            set => row["param021"].Value = value;
        }

        // Unknown.
        public short param022
        {
            get => (short)row["param022"].Value;
            set => row["param022"].Value = value;
        }

        // Unknown.
        public short param023
        {
            get => (short)row["param023"].Value;
            set => row["param023"].Value = value;
        }

        // Unknown.
        public short param024
        {
            get => (short)row["param024"].Value;
            set => row["param024"].Value = value;
        }

        // Unknown.
        public short param025
        {
            get => (short)row["param025"].Value;
            set => row["param025"].Value = value;
        }

        // Unknown.
        public short param026
        {
            get => (short)row["param026"].Value;
            set => row["param026"].Value = value;
        }

        // Unknown.
        public short param027
        {
            get => (short)row["param027"].Value;
            set => row["param027"].Value = value;
        }

        // Unknown.
        public short param028
        {
            get => (short)row["param028"].Value;
            set => row["param028"].Value = value;
        }

        public short param029
        {
            get => (short)row["param029"].Value;
            set => row["param029"].Value = value;
        }

        // Unknown.
        public short param030
        {
            get => (short)row["param030"].Value;
            set => row["param030"].Value = value;
        }

        // Unknown.
        public short param031
        {
            get => (short)row["param031"].Value;
            set => row["param031"].Value = value;
        }

        public short param032
        {
            get => (short)row["param032"].Value;
            set => row["param032"].Value = value;
        }

        public short param033
        {
            get => (short)row["param033"].Value;
            set => row["param033"].Value = value;
        }

        public short param034
        {
            get => (short)row["param034"].Value;
            set => row["param034"].Value = value;
        }

        // Unknown.
        public short param035
        {
            get => (short)row["param035"].Value;
            set => row["param035"].Value = value;
        }

        // Unknown.
        public short param036
        {
            get => (short)row["param036"].Value;
            set => row["param036"].Value = value;
        }

        // Unknown.
        public short param037
        {
            get => (short)row["param037"].Value;
            set => row["param037"].Value = value;
        }

        public short param038
        {
            get => (short)row["param038"].Value;
            set => row["param038"].Value = value;
        }

        public short param039
        {
            get => (short)row["param039"].Value;
            set => row["param039"].Value = value;
        }

        // Unknown.
        public short param040
        {
            get => (short)row["param040"].Value;
            set => row["param040"].Value = value;
        }

        // Unknown.
        public short param041
        {
            get => (short)row["param041"].Value;
            set => row["param041"].Value = value;
        }

        // Unknown.
        public short param042
        {
            get => (short)row["param042"].Value;
            set => row["param042"].Value = value;
        }

        // Unknown.
        public short param043
        {
            get => (short)row["param043"].Value;
            set => row["param043"].Value = value;
        }

        // Unknown.
        public short param044
        {
            get => (short)row["param044"].Value;
            set => row["param044"].Value = value;
        }

        // Unknown.
        public short param045
        {
            get => (short)row["param045"].Value;
            set => row["param045"].Value = value;
        }

        // Unknown.
        public short param046
        {
            get => (short)row["param046"].Value;
            set => row["param046"].Value = value;
        }

        // Unknown.
        public short param047
        {
            get => (short)row["param047"].Value;
            set => row["param047"].Value = value;
        }

        // Unknown.
        public short param048
        {
            get => (short)row["param048"].Value;
            set => row["param048"].Value = value;
        }

        // Unknown.
        public short param049
        {
            get => (short)row["param049"].Value;
            set => row["param049"].Value = value;
        }

        // Unknown.
        public short param050
        {
            get => (short)row["param050"].Value;
            set => row["param050"].Value = value;
        }

        // Unknown.
        public short param051
        {
            get => (short)row["param051"].Value;
            set => row["param051"].Value = value;
        }

        public short param052
        {
            get => (short)row["param052"].Value;
            set => row["param052"].Value = value;
        }

        // Unknown.
        public short param053
        {
            get => (short)row["param053"].Value;
            set => row["param053"].Value = value;
        }

        // Unknown.
        public short param054
        {
            get => (short)row["param054"].Value;
            set => row["param054"].Value = value;
        }

        // Unknown.
        public short param055
        {
            get => (short)row["param055"].Value;
            set => row["param055"].Value = value;
        }

        // Unknown.
        public short param056
        {
            get => (short)row["param056"].Value;
            set => row["param056"].Value = value;
        }

        public short param057
        {
            get => (short)row["param057"].Value;
            set => row["param057"].Value = value;
        }

        public short param058
        {
            get => (short)row["param058"].Value;
            set => row["param058"].Value = value;
        }

        public short param059
        {
            get => (short)row["param059"].Value;
            set => row["param059"].Value = value;
        }

        // Unknown.
        public short param060
        {
            get => (short)row["param060"].Value;
            set => row["param060"].Value = value;
        }

        // Unknown.
        public short param061
        {
            get => (short)row["param061"].Value;
            set => row["param061"].Value = value;
        }

        // Unknown.
        public short param062
        {
            get => (short)row["param062"].Value;
            set => row["param062"].Value = value;
        }

        // Unknown.
        public short param063
        {
            get => (short)row["param063"].Value;
            set => row["param063"].Value = value;
        }

        // Unknown.
        public short param064
        {
            get => (short)row["param064"].Value;
            set => row["param064"].Value = value;
        }

        // Unknown.
        public short param065
        {
            get => (short)row["param065"].Value;
            set => row["param065"].Value = value;
        }

        // Unknown.
        public short param066
        {
            get => (short)row["param066"].Value;
            set => row["param066"].Value = value;
        }

        // Unknown.
        public short param067
        {
            get => (short)row["param067"].Value;
            set => row["param067"].Value = value;
        }

        // Unknown.
        public short param068
        {
            get => (short)row["param068"].Value;
            set => row["param068"].Value = value;
        }

        public short param069
        {
            get => (short)row["param069"].Value;
            set => row["param069"].Value = value;
        }

        // Unknown.
        public short param070
        {
            get => (short)row["param070"].Value;
            set => row["param070"].Value = value;
        }

        // Unknown.
        public short param071
        {
            get => (short)row["param071"].Value;
            set => row["param071"].Value = value;
        }

        // Unknown.
        public short param072
        {
            get => (short)row["param072"].Value;
            set => row["param072"].Value = value;
        }

        // Unknown.
        public short param073
        {
            get => (short)row["param073"].Value;
            set => row["param073"].Value = value;
        }

        // Unknown.
        public short param074
        {
            get => (short)row["param074"].Value;
            set => row["param074"].Value = value;
        }

        // Unknown.
        public short param075
        {
            get => (short)row["param075"].Value;
            set => row["param075"].Value = value;
        }

        // Unknown.
        public short param076
        {
            get => (short)row["param076"].Value;
            set => row["param076"].Value = value;
        }

        // Unknown.
        public short param077
        {
            get => (short)row["param077"].Value;
            set => row["param077"].Value = value;
        }

        // Unknown.
        public short param078
        {
            get => (short)row["param078"].Value;
            set => row["param078"].Value = value;
        }

        // Unknown.
        public short param079
        {
            get => (short)row["param079"].Value;
            set => row["param079"].Value = value;
        }

        // Unknown.
        public short param080
        {
            get => (short)row["param080"].Value;
            set => row["param080"].Value = value;
        }

        // Unknown.
        public short param081
        {
            get => (short)row["param081"].Value;
            set => row["param081"].Value = value;
        }

        public short param082
        {
            get => (short)row["param082"].Value;
            set => row["param082"].Value = value;
        }

        public short param083
        {
            get => (short)row["param083"].Value;
            set => row["param083"].Value = value;
        }

        public short param084
        {
            get => (short)row["param084"].Value;
            set => row["param084"].Value = value;
        }

        // Unknown.
        public short param085
        {
            get => (short)row["param085"].Value;
            set => row["param085"].Value = value;
        }

        // Unknown.
        public short param086
        {
            get => (short)row["param086"].Value;
            set => row["param086"].Value = value;
        }

        // Unknown.
        public short param087
        {
            get => (short)row["param087"].Value;
            set => row["param087"].Value = value;
        }

        // Unknown.
        public short param088
        {
            get => (short)row["param088"].Value;
            set => row["param088"].Value = value;
        }

        public short param089
        {
            get => (short)row["param089"].Value;
            set => row["param089"].Value = value;
        }

        // Unknown.
        public short param090
        {
            get => (short)row["param090"].Value;
            set => row["param090"].Value = value;
        }

        public short param091
        {
            get => (short)row["param091"].Value;
            set => row["param091"].Value = value;
        }

        public short param092
        {
            get => (short)row["param092"].Value;
            set => row["param092"].Value = value;
        }

        public short param093
        {
            get => (short)row["param093"].Value;
            set => row["param093"].Value = value;
        }

        public short param094
        {
            get => (short)row["param094"].Value;
            set => row["param094"].Value = value;
        }

        // Unknown.
        public short param095
        {
            get => (short)row["param095"].Value;
            set => row["param095"].Value = value;
        }

        // Unknown.
        public short param096
        {
            get => (short)row["param096"].Value;
            set => row["param096"].Value = value;
        }

        // Unknown.
        public short param097
        {
            get => (short)row["param097"].Value;
            set => row["param097"].Value = value;
        }

        public short param098
        {
            get => (short)row["param098"].Value;
            set => row["param098"].Value = value;
        }

        public short param099
        {
            get => (short)row["param099"].Value;
            set => row["param099"].Value = value;
        }

        // Unknown.
        public short param100
        {
            get => (short)row["param100"].Value;
            set => row["param100"].Value = value;
        }

        // Unknown.
        public short param101
        {
            get => (short)row["param101"].Value;
            set => row["param101"].Value = value;
        }

        // Unknown.
        public short param102
        {
            get => (short)row["param102"].Value;
            set => row["param102"].Value = value;
        }

        // Unknown.
        public short param103
        {
            get => (short)row["param103"].Value;
            set => row["param103"].Value = value;
        }

        // Unknown.
        public short param104
        {
            get => (short)row["param104"].Value;
            set => row["param104"].Value = value;
        }

        // Unknown.
        public short param105
        {
            get => (short)row["param105"].Value;
            set => row["param105"].Value = value;
        }

        // Unknown.
        public short param106
        {
            get => (short)row["param106"].Value;
            set => row["param106"].Value = value;
        }

        public short param107
        {
            get => (short)row["param107"].Value;
            set => row["param107"].Value = value;
        }

        public short param108
        {
            get => (short)row["param108"].Value;
            set => row["param108"].Value = value;
        }

        public short param109
        {
            get => (short)row["param109"].Value;
            set => row["param109"].Value = value;
        }

        // Unknown.
        public short param110
        {
            get => (short)row["param110"].Value;
            set => row["param110"].Value = value;
        }

        // Unknown.
        public short param111
        {
            get => (short)row["param111"].Value;
            set => row["param111"].Value = value;
        }

        // Unknown.
        public short param112
        {
            get => (short)row["param112"].Value;
            set => row["param112"].Value = value;
        }

        // Unknown.
        public short param113
        {
            get => (short)row["param113"].Value;
            set => row["param113"].Value = value;
        }

        // Unknown.
        public short param114
        {
            get => (short)row["param114"].Value;
            set => row["param114"].Value = value;
        }

        // Unknown.
        public short param115
        {
            get => (short)row["param115"].Value;
            set => row["param115"].Value = value;
        }

        // Unknown.
        public short param116
        {
            get => (short)row["param116"].Value;
            set => row["param116"].Value = value;
        }

        // Unknown.
        public short param117
        {
            get => (short)row["param117"].Value;
            set => row["param117"].Value = value;
        }

        // Unknown.
        public short param118
        {
            get => (short)row["param118"].Value;
            set => row["param118"].Value = value;
        }

        public short param119
        {
            get => (short)row["param119"].Value;
            set => row["param119"].Value = value;
        }

        // Unknown.
        public short param120
        {
            get => (short)row["param120"].Value;
            set => row["param120"].Value = value;
        }

        // Unknown.
        public short param121
        {
            get => (short)row["param121"].Value;
            set => row["param121"].Value = value;
        }

        // Unknown.
        public short param122
        {
            get => (short)row["param122"].Value;
            set => row["param122"].Value = value;
        }

        // Unknown.
        public short param123
        {
            get => (short)row["param123"].Value;
            set => row["param123"].Value = value;
        }

        // Unknown.
        public short param124
        {
            get => (short)row["param124"].Value;
            set => row["param124"].Value = value;
        }

        // Unknown.
        public short param125
        {
            get => (short)row["param125"].Value;
            set => row["param125"].Value = value;
        }

        // Unknown.
        public short param126
        {
            get => (short)row["param126"].Value;
            set => row["param126"].Value = value;
        }

        public short param127
        {
            get => (short)row["param127"].Value;
            set => row["param127"].Value = value;
        }

        public short param128
        {
            get => (short)row["param128"].Value;
            set => row["param128"].Value = value;
        }

        public short param129
        {
            get => (short)row["param129"].Value;
            set => row["param129"].Value = value;
        }

        // Unknown.
        public short param130
        {
            get => (short)row["param130"].Value;
            set => row["param130"].Value = value;
        }

        // Unknown.
        public short param131
        {
            get => (short)row["param131"].Value;
            set => row["param131"].Value = value;
        }

        // Unknown.
        public short param132
        {
            get => (short)row["param132"].Value;
            set => row["param132"].Value = value;
        }

        // Unknown.
        public short param133
        {
            get => (short)row["param133"].Value;
            set => row["param133"].Value = value;
        }

        // Unknown.
        public short param134
        {
            get => (short)row["param134"].Value;
            set => row["param134"].Value = value;
        }

        // Unknown.
        public short param135
        {
            get => (short)row["param135"].Value;
            set => row["param135"].Value = value;
        }

        // Unknown.
        public short param136
        {
            get => (short)row["param136"].Value;
            set => row["param136"].Value = value;
        }

        // Unknown.
        public short param137
        {
            get => (short)row["param137"].Value;
            set => row["param137"].Value = value;
        }

        // Unknown.
        public short param138
        {
            get => (short)row["param138"].Value;
            set => row["param138"].Value = value;
        }

        // Unknown.
        public short param139
        {
            get => (short)row["param139"].Value;
            set => row["param139"].Value = value;
        }

        // Unknown.
        public short param140
        {
            get => (short)row["param140"].Value;
            set => row["param140"].Value = value;
        }

        // Unknown.
        public short param141
        {
            get => (short)row["param141"].Value;
            set => row["param141"].Value = value;
        }

        // Unknown.
        public short param142
        {
            get => (short)row["param142"].Value;
            set => row["param142"].Value = value;
        }

        // Unknown.
        public short param143
        {
            get => (short)row["param143"].Value;
            set => row["param143"].Value = value;
        }

        // Unknown.
        public short param144
        {
            get => (short)row["param144"].Value;
            set => row["param144"].Value = value;
        }

        // Unknown.
        public short param145
        {
            get => (short)row["param145"].Value;
            set => row["param145"].Value = value;
        }

        // Unknown.
        public short param146
        {
            get => (short)row["param146"].Value;
            set => row["param146"].Value = value;
        }

        // Unknown.
        public short param147
        {
            get => (short)row["param147"].Value;
            set => row["param147"].Value = value;
        }

        // Unknown.
        public short param148
        {
            get => (short)row["param148"].Value;
            set => row["param148"].Value = value;
        }

        public short param149
        {
            get => (short)row["param149"].Value;
            set => row["param149"].Value = value;
        }

        // Unknown.
        public short param150
        {
            get => (short)row["param150"].Value;
            set => row["param150"].Value = value;
        }

        // Unknown.
        public short param151
        {
            get => (short)row["param151"].Value;
            set => row["param151"].Value = value;
        }

        // Unknown.
        public short param152
        {
            get => (short)row["param152"].Value;
            set => row["param152"].Value = value;
        }

        // Unknown.
        public short param153
        {
            get => (short)row["param153"].Value;
            set => row["param153"].Value = value;
        }

        // Unknown.
        public short param154
        {
            get => (short)row["param154"].Value;
            set => row["param154"].Value = value;
        }

        // Unknown.
        public short param155
        {
            get => (short)row["param155"].Value;
            set => row["param155"].Value = value;
        }

        public short param156
        {
            get => (short)row["param156"].Value;
            set => row["param156"].Value = value;
        }

        public short param157
        {
            get => (short)row["param157"].Value;
            set => row["param157"].Value = value;
        }

        public short param158
        {
            get => (short)row["param158"].Value;
            set => row["param158"].Value = value;
        }

        public short param159
        {
            get => (short)row["param159"].Value;
            set => row["param159"].Value = value;
        }

        public short param160
        {
            get => (short)row["param160"].Value;
            set => row["param160"].Value = value;
        }

        public short param161
        {
            get => (short)row["param161"].Value;
            set => row["param161"].Value = value;
        }

        public short param162
        {
            get => (short)row["param162"].Value;
            set => row["param162"].Value = value;
        }

        public short param163
        {
            get => (short)row["param163"].Value;
            set => row["param163"].Value = value;
        }

        public short param164
        {
            get => (short)row["param164"].Value;
            set => row["param164"].Value = value;
        }

        public short param165
        {
            get => (short)row["param165"].Value;
            set => row["param165"].Value = value;
        }

        public short param166
        {
            get => (short)row["param166"].Value;
            set => row["param166"].Value = value;
        }

        public short param167
        {
            get => (short)row["param167"].Value;
            set => row["param167"].Value = value;
        }

        public short param168
        {
            get => (short)row["param168"].Value;
            set => row["param168"].Value = value;
        }

        public short param169
        {
            get => (short)row["param169"].Value;
            set => row["param169"].Value = value;
        }

        public short param170
        {
            get => (short)row["param170"].Value;
            set => row["param170"].Value = value;
        }

        public short param171
        {
            get => (short)row["param171"].Value;
            set => row["param171"].Value = value;
        }

        public short param172
        {
            get => (short)row["param172"].Value;
            set => row["param172"].Value = value;
        }

        public short param173
        {
            get => (short)row["param173"].Value;
            set => row["param173"].Value = value;
        }

        public short param174
        {
            get => (short)row["param174"].Value;
            set => row["param174"].Value = value;
        }

        public short param175
        {
            get => (short)row["param175"].Value;
            set => row["param175"].Value = value;
        }

        public short param176
        {
            get => (short)row["param176"].Value;
            set => row["param176"].Value = value;
        }

        public short param177
        {
            get => (short)row["param177"].Value;
            set => row["param177"].Value = value;
        }

        public short param178
        {
            get => (short)row["param178"].Value;
            set => row["param178"].Value = value;
        }

        public short param179
        {
            get => (short)row["param179"].Value;
            set => row["param179"].Value = value;
        }

        public short param180
        {
            get => (short)row["param180"].Value;
            set => row["param180"].Value = value;
        }

        public short param181
        {
            get => (short)row["param181"].Value;
            set => row["param181"].Value = value;
        }

        public short param182
        {
            get => (short)row["param182"].Value;
            set => row["param182"].Value = value;
        }

        public short param183
        {
            get => (short)row["param183"].Value;
            set => row["param183"].Value = value;
        }

        public short param184
        {
            get => (short)row["param184"].Value;
            set => row["param184"].Value = value;
        }

        public short param185
        {
            get => (short)row["param185"].Value;
            set => row["param185"].Value = value;
        }

        public short param186
        {
            get => (short)row["param186"].Value;
            set => row["param186"].Value = value;
        }

        public short param187
        {
            get => (short)row["param187"].Value;
            set => row["param187"].Value = value;
        }

        public short param188
        {
            get => (short)row["param188"].Value;
            set => row["param188"].Value = value;
        }

        public short param189
        {
            get => (short)row["param189"].Value;
            set => row["param189"].Value = value;
        }

        public short param190
        {
            get => (short)row["param190"].Value;
            set => row["param190"].Value = value;
        }

        public short param191
        {
            get => (short)row["param191"].Value;
            set => row["param191"].Value = value;
        }

        public short param192
        {
            get => (short)row["param192"].Value;
            set => row["param192"].Value = value;
        }

        public short param193
        {
            get => (short)row["param193"].Value;
            set => row["param193"].Value = value;
        }

        public short param194
        {
            get => (short)row["param194"].Value;
            set => row["param194"].Value = value;
        }

        public short param195
        {
            get => (short)row["param195"].Value;
            set => row["param195"].Value = value;
        }

        public short param196
        {
            get => (short)row["param196"].Value;
            set => row["param196"].Value = value;
        }

        public short param197
        {
            get => (short)row["param197"].Value;
            set => row["param197"].Value = value;
        }

        public short param198
        {
            get => (short)row["param198"].Value;
            set => row["param198"].Value = value;
        }

        public short param199
        {
            get => (short)row["param199"].Value;
            set => row["param199"].Value = value;
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
    public NPC_AI_BEHAVIOR_PROBABILITY_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public NPC_AI_BEHAVIOR_PROBABILITY_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
