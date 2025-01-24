using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class HIT_EFFECT_SE_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int Iron_Slash_S
        {
            get => (int)row["Iron_Slash_S"].Value;
            set => row["Iron_Slash_S"].Value = value;
        }

        // Unknown.
        public int Iron_Slash_L
        {
            get => (int)row["Iron_Slash_L"].Value;
            set => row["Iron_Slash_L"].Value = value;
        }

        // Unknown.
        public int Iron_Slash_LL
        {
            get => (int)row["Iron_Slash_LL"].Value;
            set => row["Iron_Slash_LL"].Value = value;
        }

        // Unknown.
        public int Iron_Thrust_S
        {
            get => (int)row["Iron_Thrust_S"].Value;
            set => row["Iron_Thrust_S"].Value = value;
        }

        // Unknown.
        public int Iron_Thrust_L
        {
            get => (int)row["Iron_Thrust_L"].Value;
            set => row["Iron_Thrust_L"].Value = value;
        }

        // Unknown.
        public int Iron_Thrust_LL
        {
            get => (int)row["Iron_Thrust_LL"].Value;
            set => row["Iron_Thrust_LL"].Value = value;
        }

        // Unknown.
        public int Iron_Blow_S
        {
            get => (int)row["Iron_Blow_S"].Value;
            set => row["Iron_Blow_S"].Value = value;
        }

        // Unknown.
        public int Iron_Blow_L
        {
            get => (int)row["Iron_Blow_L"].Value;
            set => row["Iron_Blow_L"].Value = value;
        }

        // Unknown.
        public int Iron_Blow_LL
        {
            get => (int)row["Iron_Blow_LL"].Value;
            set => row["Iron_Blow_LL"].Value = value;
        }

        // Unknown.
        public int Fire_Slash_S
        {
            get => (int)row["Fire_Slash_S"].Value;
            set => row["Fire_Slash_S"].Value = value;
        }

        // Unknown.
        public int Fire_Slash_L
        {
            get => (int)row["Fire_Slash_L"].Value;
            set => row["Fire_Slash_L"].Value = value;
        }

        // Unknown.
        public int Fire_Slash_LL
        {
            get => (int)row["Fire_Slash_LL"].Value;
            set => row["Fire_Slash_LL"].Value = value;
        }

        // Unknown.
        public int Fire_Thrust_S
        {
            get => (int)row["Fire_Thrust_S"].Value;
            set => row["Fire_Thrust_S"].Value = value;
        }

        // Unknown.
        public int Fire_Thrust_L
        {
            get => (int)row["Fire_Thrust_L"].Value;
            set => row["Fire_Thrust_L"].Value = value;
        }

        // Unknown.
        public int Fire_Thrust_LL
        {
            get => (int)row["Fire_Thrust_LL"].Value;
            set => row["Fire_Thrust_LL"].Value = value;
        }

        // Unknown.
        public int Fire_Blow_S
        {
            get => (int)row["Fire_Blow_S"].Value;
            set => row["Fire_Blow_S"].Value = value;
        }

        // Unknown.
        public int Fire_Blow_L
        {
            get => (int)row["Fire_Blow_L"].Value;
            set => row["Fire_Blow_L"].Value = value;
        }

        // Unknown.
        public int Fire_Blow_LL
        {
            get => (int)row["Fire_Blow_LL"].Value;
            set => row["Fire_Blow_LL"].Value = value;
        }

        // Unknown.
        public int Wood_Slash_S
        {
            get => (int)row["Wood_Slash_S"].Value;
            set => row["Wood_Slash_S"].Value = value;
        }

        // Unknown.
        public int Wood_Slash_L
        {
            get => (int)row["Wood_Slash_L"].Value;
            set => row["Wood_Slash_L"].Value = value;
        }

        // Unknown.
        public int Wood_Slash_LL
        {
            get => (int)row["Wood_Slash_LL"].Value;
            set => row["Wood_Slash_LL"].Value = value;
        }

        // Unknown.
        public int Wood_Thrust_S
        {
            get => (int)row["Wood_Thrust_S"].Value;
            set => row["Wood_Thrust_S"].Value = value;
        }

        // Unknown.
        public int Wood_Thrust_L
        {
            get => (int)row["Wood_Thrust_L"].Value;
            set => row["Wood_Thrust_L"].Value = value;
        }

        // Unknown.
        public int Wood_Thrust_LL
        {
            get => (int)row["Wood_Thrust_LL"].Value;
            set => row["Wood_Thrust_LL"].Value = value;
        }

        // Unknown.
        public int Wood_Blow_S
        {
            get => (int)row["Wood_Blow_S"].Value;
            set => row["Wood_Blow_S"].Value = value;
        }

        // Unknown.
        public int Wood_Blow_L
        {
            get => (int)row["Wood_Blow_L"].Value;
            set => row["Wood_Blow_L"].Value = value;
        }

        // Unknown.
        public int Wood_Blow_LL
        {
            get => (int)row["Wood_Blow_LL"].Value;
            set => row["Wood_Blow_LL"].Value = value;
        }

        // Unknown.
        public int Body_Slash_S
        {
            get => (int)row["Body_Slash_S"].Value;
            set => row["Body_Slash_S"].Value = value;
        }

        // Unknown.
        public int Body_Slash_L
        {
            get => (int)row["Body_Slash_L"].Value;
            set => row["Body_Slash_L"].Value = value;
        }

        // Unknown.
        public int Body_Slash_LL
        {
            get => (int)row["Body_Slash_LL"].Value;
            set => row["Body_Slash_LL"].Value = value;
        }

        // Unknown.
        public int Body_Thrust_S
        {
            get => (int)row["Body_Thrust_S"].Value;
            set => row["Body_Thrust_S"].Value = value;
        }

        // Unknown.
        public int Body_Thrust_L
        {
            get => (int)row["Body_Thrust_L"].Value;
            set => row["Body_Thrust_L"].Value = value;
        }

        // Unknown.
        public int Body_Thrust_LL
        {
            get => (int)row["Body_Thrust_LL"].Value;
            set => row["Body_Thrust_LL"].Value = value;
        }

        // Unknown.
        public int Body_Blow_S
        {
            get => (int)row["Body_Blow_S"].Value;
            set => row["Body_Blow_S"].Value = value;
        }

        // Unknown.
        public int Body_Blow_L
        {
            get => (int)row["Body_Blow_L"].Value;
            set => row["Body_Blow_L"].Value = value;
        }

        // Unknown.
        public int Body_Blow_LL
        {
            get => (int)row["Body_Blow_LL"].Value;
            set => row["Body_Blow_LL"].Value = value;
        }

        // Unknown.
        public int Eclipse_Slash_S
        {
            get => (int)row["Eclipse_Slash_S"].Value;
            set => row["Eclipse_Slash_S"].Value = value;
        }

        // Unknown.
        public int Eclipse_Slash_L
        {
            get => (int)row["Eclipse_Slash_L"].Value;
            set => row["Eclipse_Slash_L"].Value = value;
        }

        // Unknown.
        public int Eclipse_Slash_LL
        {
            get => (int)row["Eclipse_Slash_LL"].Value;
            set => row["Eclipse_Slash_LL"].Value = value;
        }

        // Unknown.
        public int Eclipse_Thrust_S
        {
            get => (int)row["Eclipse_Thrust_S"].Value;
            set => row["Eclipse_Thrust_S"].Value = value;
        }

        // Unknown.
        public int Eclipse_Thrust_L
        {
            get => (int)row["Eclipse_Thrust_L"].Value;
            set => row["Eclipse_Thrust_L"].Value = value;
        }

        // Unknown.
        public int Eclipse_Thrust_LL
        {
            get => (int)row["Eclipse_Thrust_LL"].Value;
            set => row["Eclipse_Thrust_LL"].Value = value;
        }

        // Unknown.
        public int Eclipse_Blow_S
        {
            get => (int)row["Eclipse_Blow_S"].Value;
            set => row["Eclipse_Blow_S"].Value = value;
        }

        // Unknown.
        public int Eclipse_Blow_L
        {
            get => (int)row["Eclipse_Blow_L"].Value;
            set => row["Eclipse_Blow_L"].Value = value;
        }

        // Unknown.
        public int Eclipse_Blow_LL
        {
            get => (int)row["Eclipse_Blow_LL"].Value;
            set => row["Eclipse_Blow_LL"].Value = value;
        }

        // Unknown.
        public int Energy_Slash_S
        {
            get => (int)row["Energy_Slash_S"].Value;
            set => row["Energy_Slash_S"].Value = value;
        }

        // Unknown.
        public int Energy_Slash_L
        {
            get => (int)row["Energy_Slash_L"].Value;
            set => row["Energy_Slash_L"].Value = value;
        }

        // Unknown.
        public int Energy_Slash_LL
        {
            get => (int)row["Energy_Slash_LL"].Value;
            set => row["Energy_Slash_LL"].Value = value;
        }

        // Unknown.
        public int Energy_Thrust_S
        {
            get => (int)row["Energy_Thrust_S"].Value;
            set => row["Energy_Thrust_S"].Value = value;
        }

        // Unknown.
        public int Energy_Thrust_L
        {
            get => (int)row["Energy_Thrust_L"].Value;
            set => row["Energy_Thrust_L"].Value = value;
        }

        // Unknown.
        public int Energy_Thrust_LL
        {
            get => (int)row["Energy_Thrust_LL"].Value;
            set => row["Energy_Thrust_LL"].Value = value;
        }

        // Unknown.
        public int Energy_Blow_S
        {
            get => (int)row["Energy_Blow_S"].Value;
            set => row["Energy_Blow_S"].Value = value;
        }

        // Unknown.
        public int Energy_Blow_L
        {
            get => (int)row["Energy_Blow_L"].Value;
            set => row["Energy_Blow_L"].Value = value;
        }

        // Unknown.
        public int Energy_Blow_LL
        {
            get => (int)row["Energy_Blow_LL"].Value;
            set => row["Energy_Blow_LL"].Value = value;
        }

        // Unknown.
        public int None_Slash_S
        {
            get => (int)row["None_Slash_S"].Value;
            set => row["None_Slash_S"].Value = value;
        }

        // Unknown.
        public int None_Slash_L
        {
            get => (int)row["None_Slash_L"].Value;
            set => row["None_Slash_L"].Value = value;
        }

        // Unknown.
        public int None_Slash_LL
        {
            get => (int)row["None_Slash_LL"].Value;
            set => row["None_Slash_LL"].Value = value;
        }

        // Unknown.
        public int None_Thrust_S
        {
            get => (int)row["None_Thrust_S"].Value;
            set => row["None_Thrust_S"].Value = value;
        }

        // Unknown.
        public int None_Thrust_L
        {
            get => (int)row["None_Thrust_L"].Value;
            set => row["None_Thrust_L"].Value = value;
        }

        // Unknown.
        public int None_Thrust_LL
        {
            get => (int)row["None_Thrust_LL"].Value;
            set => row["None_Thrust_LL"].Value = value;
        }

        // Unknown.
        public int None_Blow_S
        {
            get => (int)row["None_Blow_S"].Value;
            set => row["None_Blow_S"].Value = value;
        }

        // Unknown.
        public int None_Blow_L
        {
            get => (int)row["None_Blow_L"].Value;
            set => row["None_Blow_L"].Value = value;
        }

        // Unknown.
        public int None_Blow_LL
        {
            get => (int)row["None_Blow_LL"].Value;
            set => row["None_Blow_LL"].Value = value;
        }

        // Unknown.
        public int Dmy1_Slash_S
        {
            get => (int)row["Dmy1_Slash_S"].Value;
            set => row["Dmy1_Slash_S"].Value = value;
        }

        // Unknown.
        public int Dmy1_Slash_L
        {
            get => (int)row["Dmy1_Slash_L"].Value;
            set => row["Dmy1_Slash_L"].Value = value;
        }

        // Unknown.
        public int Dmy1_Slash_LL
        {
            get => (int)row["Dmy1_Slash_LL"].Value;
            set => row["Dmy1_Slash_LL"].Value = value;
        }

        // Unknown.
        public int Dmy1_Thrust_S
        {
            get => (int)row["Dmy1_Thrust_S"].Value;
            set => row["Dmy1_Thrust_S"].Value = value;
        }

        // Unknown.
        public int Dmy1_Thrust_L
        {
            get => (int)row["Dmy1_Thrust_L"].Value;
            set => row["Dmy1_Thrust_L"].Value = value;
        }

        // Unknown.
        public int Dmy1_Thrust_LL
        {
            get => (int)row["Dmy1_Thrust_LL"].Value;
            set => row["Dmy1_Thrust_LL"].Value = value;
        }

        // Unknown.
        public int Dmy1_Blow_S
        {
            get => (int)row["Dmy1_Blow_S"].Value;
            set => row["Dmy1_Blow_S"].Value = value;
        }

        // Unknown.
        public int Dmy1_Blow_L
        {
            get => (int)row["Dmy1_Blow_L"].Value;
            set => row["Dmy1_Blow_L"].Value = value;
        }

        // Unknown.
        public int Dmy1_Blow_LL
        {
            get => (int)row["Dmy1_Blow_LL"].Value;
            set => row["Dmy1_Blow_LL"].Value = value;
        }

        // Unknown.
        public int Dmy2_Slash_S
        {
            get => (int)row["Dmy2_Slash_S"].Value;
            set => row["Dmy2_Slash_S"].Value = value;
        }

        // Unknown.
        public int Dmy2_Slash_L
        {
            get => (int)row["Dmy2_Slash_L"].Value;
            set => row["Dmy2_Slash_L"].Value = value;
        }

        // Unknown.
        public int Dmy2_Slash_LL
        {
            get => (int)row["Dmy2_Slash_LL"].Value;
            set => row["Dmy2_Slash_LL"].Value = value;
        }

        // Unknown.
        public int Dmy2_Thrust_S
        {
            get => (int)row["Dmy2_Thrust_S"].Value;
            set => row["Dmy2_Thrust_S"].Value = value;
        }

        // Unknown.
        public int Dmy2_Thrust_L
        {
            get => (int)row["Dmy2_Thrust_L"].Value;
            set => row["Dmy2_Thrust_L"].Value = value;
        }

        // Unknown.
        public int Dmy2_Thrust_LL
        {
            get => (int)row["Dmy2_Thrust_LL"].Value;
            set => row["Dmy2_Thrust_LL"].Value = value;
        }

        // Unknown.
        public int Dmy2_Blow_S
        {
            get => (int)row["Dmy2_Blow_S"].Value;
            set => row["Dmy2_Blow_S"].Value = value;
        }

        // Unknown.
        public int Dmy2_Blow_L
        {
            get => (int)row["Dmy2_Blow_L"].Value;
            set => row["Dmy2_Blow_L"].Value = value;
        }

        // Unknown.
        public int Dmy2_Blow_LL
        {
            get => (int)row["Dmy2_Blow_LL"].Value;
            set => row["Dmy2_Blow_LL"].Value = value;
        }

        // Unknown.
        public int Dmy3_Slash_S
        {
            get => (int)row["Dmy3_Slash_S"].Value;
            set => row["Dmy3_Slash_S"].Value = value;
        }

        // Unknown.
        public int Dmy3_Slash_L
        {
            get => (int)row["Dmy3_Slash_L"].Value;
            set => row["Dmy3_Slash_L"].Value = value;
        }

        // Unknown.
        public int Dmy3_Slash_LL
        {
            get => (int)row["Dmy3_Slash_LL"].Value;
            set => row["Dmy3_Slash_LL"].Value = value;
        }

        // Unknown.
        public int Dmy3_Thrust_S
        {
            get => (int)row["Dmy3_Thrust_S"].Value;
            set => row["Dmy3_Thrust_S"].Value = value;
        }

        // Unknown.
        public int Dmy3_Thrust_L
        {
            get => (int)row["Dmy3_Thrust_L"].Value;
            set => row["Dmy3_Thrust_L"].Value = value;
        }

        // Unknown.
        public int Dmy3_Thrust_LL
        {
            get => (int)row["Dmy3_Thrust_LL"].Value;
            set => row["Dmy3_Thrust_LL"].Value = value;
        }

        // Unknown.
        public int Dmy3_Blow_S
        {
            get => (int)row["Dmy3_Blow_S"].Value;
            set => row["Dmy3_Blow_S"].Value = value;
        }

        // Unknown.
        public int Dmy3_Blow_L
        {
            get => (int)row["Dmy3_Blow_L"].Value;
            set => row["Dmy3_Blow_L"].Value = value;
        }

        // Unknown.
        public int Dmy3_Blow_LL
        {
            get => (int)row["Dmy3_Blow_LL"].Value;
            set => row["Dmy3_Blow_LL"].Value = value;
        }

        // Unknown.
        public int Maggot_Slash_S
        {
            get => (int)row["Maggot_Slash_S"].Value;
            set => row["Maggot_Slash_S"].Value = value;
        }

        // Unknown.
        public int Maggot_Slash_L
        {
            get => (int)row["Maggot_Slash_L"].Value;
            set => row["Maggot_Slash_L"].Value = value;
        }

        // Unknown.
        public int Maggot_Slash_LL
        {
            get => (int)row["Maggot_Slash_LL"].Value;
            set => row["Maggot_Slash_LL"].Value = value;
        }

        // Unknown.
        public int Maggot_Thrust_S
        {
            get => (int)row["Maggot_Thrust_S"].Value;
            set => row["Maggot_Thrust_S"].Value = value;
        }

        // Unknown.
        public int Maggot_Thrust_L
        {
            get => (int)row["Maggot_Thrust_L"].Value;
            set => row["Maggot_Thrust_L"].Value = value;
        }

        // Unknown.
        public int Maggot_Thrust_LL
        {
            get => (int)row["Maggot_Thrust_LL"].Value;
            set => row["Maggot_Thrust_LL"].Value = value;
        }

        // Unknown.
        public int Maggot_Blow_S
        {
            get => (int)row["Maggot_Blow_S"].Value;
            set => row["Maggot_Blow_S"].Value = value;
        }

        // Unknown.
        public int Maggot_Blow_L
        {
            get => (int)row["Maggot_Blow_L"].Value;
            set => row["Maggot_Blow_L"].Value = value;
        }

        // Unknown.
        public int Maggot_Blow_LL
        {
            get => (int)row["Maggot_Blow_LL"].Value;
            set => row["Maggot_Blow_LL"].Value = value;
        }

        // Unknown.
        public int Wax_Slash_S
        {
            get => (int)row["Wax_Slash_S"].Value;
            set => row["Wax_Slash_S"].Value = value;
        }

        // Unknown.
        public int Wax_Slash_L
        {
            get => (int)row["Wax_Slash_L"].Value;
            set => row["Wax_Slash_L"].Value = value;
        }

        // Unknown.
        public int Wax_Slash_LL
        {
            get => (int)row["Wax_Slash_LL"].Value;
            set => row["Wax_Slash_LL"].Value = value;
        }

        // Unknown.
        public int Wax_Thrust_S
        {
            get => (int)row["Wax_Thrust_S"].Value;
            set => row["Wax_Thrust_S"].Value = value;
        }

        // Unknown.
        public int Wax_Thrust_L
        {
            get => (int)row["Wax_Thrust_L"].Value;
            set => row["Wax_Thrust_L"].Value = value;
        }

        // Unknown.
        public int Wax_Thrust_LL
        {
            get => (int)row["Wax_Thrust_LL"].Value;
            set => row["Wax_Thrust_LL"].Value = value;
        }

        // Unknown.
        public int Wax_Blow_S
        {
            get => (int)row["Wax_Blow_S"].Value;
            set => row["Wax_Blow_S"].Value = value;
        }

        // Unknown.
        public int Wax_Blow_L
        {
            get => (int)row["Wax_Blow_L"].Value;
            set => row["Wax_Blow_L"].Value = value;
        }

        // Unknown.
        public int Wax_Blow_LL
        {
            get => (int)row["Wax_Blow_LL"].Value;
            set => row["Wax_Blow_LL"].Value = value;
        }

        // Unknown.
        public int FireFlame_Slash_S
        {
            get => (int)row["FireFlame_Slash_S"].Value;
            set => row["FireFlame_Slash_S"].Value = value;
        }

        // Unknown.
        public int FireFlame_Slash_L
        {
            get => (int)row["FireFlame_Slash_L"].Value;
            set => row["FireFlame_Slash_L"].Value = value;
        }

        // Unknown.
        public int FireFlame_Slash_LL
        {
            get => (int)row["FireFlame_Slash_LL"].Value;
            set => row["FireFlame_Slash_LL"].Value = value;
        }

        // Unknown.
        public int FireFlame_Thrust_S
        {
            get => (int)row["FireFlame_Thrust_S"].Value;
            set => row["FireFlame_Thrust_S"].Value = value;
        }

        // Unknown.
        public int FireFlame_Thrust_L
        {
            get => (int)row["FireFlame_Thrust_L"].Value;
            set => row["FireFlame_Thrust_L"].Value = value;
        }

        // Unknown.
        public int FireFlame_Thrust_LL
        {
            get => (int)row["FireFlame_Thrust_LL"].Value;
            set => row["FireFlame_Thrust_LL"].Value = value;
        }

        // Unknown.
        public int FireFlame_Blow_S
        {
            get => (int)row["FireFlame_Blow_S"].Value;
            set => row["FireFlame_Blow_S"].Value = value;
        }

        // Unknown.
        public int FireFlame_Blow_L
        {
            get => (int)row["FireFlame_Blow_L"].Value;
            set => row["FireFlame_Blow_L"].Value = value;
        }

        // Unknown.
        public int FireFlame_Blow_LL
        {
            get => (int)row["FireFlame_Blow_LL"].Value;
            set => row["FireFlame_Blow_LL"].Value = value;
        }

        // Unknown.
        public int EclipseGas_Slash_S
        {
            get => (int)row["EclipseGas_Slash_S"].Value;
            set => row["EclipseGas_Slash_S"].Value = value;
        }

        // Unknown.
        public int EclipseGas_Slash_L
        {
            get => (int)row["EclipseGas_Slash_L"].Value;
            set => row["EclipseGas_Slash_L"].Value = value;
        }

        // Unknown.
        public int EclipseGas_Slash_LL
        {
            get => (int)row["EclipseGas_Slash_LL"].Value;
            set => row["EclipseGas_Slash_LL"].Value = value;
        }

        // Unknown.
        public int EclipseGas_Thrust_S
        {
            get => (int)row["EclipseGas_Thrust_S"].Value;
            set => row["EclipseGas_Thrust_S"].Value = value;
        }

        // Unknown.
        public int EclipseGas_Thrust_L
        {
            get => (int)row["EclipseGas_Thrust_L"].Value;
            set => row["EclipseGas_Thrust_L"].Value = value;
        }

        // Unknown.
        public int EclipseGas_Thrust_LL
        {
            get => (int)row["EclipseGas_Thrust_LL"].Value;
            set => row["EclipseGas_Thrust_LL"].Value = value;
        }

        // Unknown.
        public int EclipseGas_Blow_S
        {
            get => (int)row["EclipseGas_Blow_S"].Value;
            set => row["EclipseGas_Blow_S"].Value = value;
        }

        // Unknown.
        public int EclipseGas_Blow_L
        {
            get => (int)row["EclipseGas_Blow_L"].Value;
            set => row["EclipseGas_Blow_L"].Value = value;
        }

        // Unknown.
        public int EclipseGas_Blow_LL
        {
            get => (int)row["EclipseGas_Blow_LL"].Value;
            set => row["EclipseGas_Blow_LL"].Value = value;
        }

        // Unknown.
        public int EnergyStrong_Slash_S
        {
            get => (int)row["EnergyStrong_Slash_S"].Value;
            set => row["EnergyStrong_Slash_S"].Value = value;
        }

        // Unknown.
        public int EnergyStrong_Slash_L
        {
            get => (int)row["EnergyStrong_Slash_L"].Value;
            set => row["EnergyStrong_Slash_L"].Value = value;
        }

        // Unknown.
        public int EnergyStrong_Slash_LL
        {
            get => (int)row["EnergyStrong_Slash_LL"].Value;
            set => row["EnergyStrong_Slash_LL"].Value = value;
        }

        // Unknown.
        public int EnergyStrong_Thrust_S
        {
            get => (int)row["EnergyStrong_Thrust_S"].Value;
            set => row["EnergyStrong_Thrust_S"].Value = value;
        }

        // Unknown.
        public int EnergyStrong_Thrust_L
        {
            get => (int)row["EnergyStrong_Thrust_L"].Value;
            set => row["EnergyStrong_Thrust_L"].Value = value;
        }

        // Unknown.
        public int EnergyStrong_Thrust_LL
        {
            get => (int)row["EnergyStrong_Thrust_LL"].Value;
            set => row["EnergyStrong_Thrust_LL"].Value = value;
        }

        // Unknown.
        public int EnergyStrong_Blow_S
        {
            get => (int)row["EnergyStrong_Blow_S"].Value;
            set => row["EnergyStrong_Blow_S"].Value = value;
        }

        // Unknown.
        public int EnergyStrong_Blow_L
        {
            get => (int)row["EnergyStrong_Blow_L"].Value;
            set => row["EnergyStrong_Blow_L"].Value = value;
        }

        // Unknown.
        public int EnergyStrong_Blow_LL
        {
            get => (int)row["EnergyStrong_Blow_LL"].Value;
            set => row["EnergyStrong_Blow_LL"].Value = value;
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
    public HIT_EFFECT_SE_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public HIT_EFFECT_SE_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
