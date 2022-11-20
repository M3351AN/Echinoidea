using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZBase.Classes;
using ZBase.Utilities;

namespace ZBase
{
    public class Main
    {
        public static Size ScreenSize;
        public static Vector2 MidScreen;
        public static RECT ScreenRect;

        public static RootObject O;
        public static Settings S = new Settings();
        public static bool RunStartup()
        {
            var CSGO = Process.GetProcessesByName("csgo");
            if (CSGO.Length != 0)
            {
                Memory.Process = CSGO[0];
                Memory.ProcessHandle = Memory.OpenProcess(0x0008 | 0x0010 | 0x0020, false, Memory.Process.Id);
                foreach (ProcessModule Module in Memory.Process.Modules)
                {
                    if ((Module.ModuleName == "client.dll"))
                        Memory.Client = Module.BaseAddress;

                    if ((Module.ModuleName == "engine.dll"))
                    {
                        Memory.Engine = Module.BaseAddress;
                        G.Engine = new Engine((int)Module.BaseAddress);
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show("Please start CSGO before Running Echinoidea", "Error", MessageBoxButtons.OK);
                Environment.Exit(1);
                return false;
            }
        }
    }
}
/*junk code sample*/
/*
namespace junkCode_M0W1SG2YZOGI
{
    class X2EOW36W8EC5L
    {
        void GKA2QKP6MQL9()
        {
            int DRM18PAJZ63HM = 251367107;
            if (DRM18PAJZ63HM > 251367189)
                DRM18PAJZ63HM = 251367158;
            else if (DRM18PAJZ63HM <= 251367134)
                DRM18PAJZ63HM++;
            else
                DRM18PAJZ63HM = (251367114 / 251367195);
            int D58RAYNA9BJME = 251367169;
            if (D58RAYNA9BJME > 251367136)
                D58RAYNA9BJME = 251367124;
            else if (D58RAYNA9BJME <= 251367103)
                D58RAYNA9BJME++;
            else
                D58RAYNA9BJME = (251367111 / 251367114);
            bool DAYR0HEHLLPAS = true;
            if (!DAYR0HEHLLPAS)
                DAYR0HEHLLPAS = false;
            else if (DAYR0HEHLLPAS = false)
                DAYR0HEHLLPAS = false;
            else
                DAYR0HEHLLPAS = true;
            int DHB51PLX0PBD8 = 251367133;
            if (DHB51PLX0PBD8 > 251367118)
                DHB51PLX0PBD8 = 251367115;
            else if (DHB51PLX0PBD8 <= 251367163)
                DHB51PLX0PBD8++;
            else
                DHB51PLX0PBD8 = (251367102 / 251367151);
            int DP9IQFW835FEJ = 251367195;
            if (DP9IQFW835FEJ > 251367126)
                DP9IQFW835FEJ = 251367188;
            else if (DP9IQFW835FEJ <= 251367181)
                DP9IQFW835FEJ++;
            else
                DP9IQFW835FEJ = (251367150 / 251367133);
            int D54434IE14RAO = 251367101;
            if (D54434IE14RAO > 251367124)
                D54434IE14RAO = 251367186;
            else if (D54434IE14RAO <= 251367156)
                D54434IE14RAO++;
            else
                D54434IE14RAO = (251367161 / 251367136);
            int DC6KYXISW615A = 251367102;
            if (DC6KYXISW615A > 251367164)
                DC6KYXISW615A = 251367119;
            else if (DC6KYXISW615A <= 251367194)
                DC6KYXISW615A++;
            else
                DC6KYXISW615A = (251367191 / 251367194);
            int D9QB5SYYADBP6 = 251367175;
            if (D9QB5SYYADBP6 > 251367106)
                D9QB5SYYADBP6 = 251367156;
            else if (D9QB5SYYADBP6 <= 251367192)
                D9QB5SYYADBP6++;
            else
                D9QB5SYYADBP6 = (251367112 / 251367133);
            int DXLMZFCP1P7BQ = 251367157;
            if (DXLMZFCP1P7BQ > 251367116)
                DXLMZFCP1P7BQ = 251367130;
            else if (DXLMZFCP1P7BQ <= 251367155)
                DXLMZFCP1P7BQ++;
            else
                DXLMZFCP1P7BQ = (251367190 / 251367119);
            int DPE6MQ4DPD1EA = 251367112;
            if (DPE6MQ4DPD1EA > 251367168)
                DPE6MQ4DPD1EA = 251367113;
            else if (DPE6MQ4DPD1EA <= 251367190)
                DPE6MQ4DPD1EA++;
            else
                DPE6MQ4DPD1EA = (251367111 / 251367175);
            int D0YIY4M6OIB3W = 251367160;
            if (D0YIY4M6OIB3W > 251367127)
                D0YIY4M6OIB3W = 251367131;
            else if (D0YIY4M6OIB3W <= 251367172)
                D0YIY4M6OIB3W++;
            else
                D0YIY4M6OIB3W = (251367180 / 251367103);
            bool DFDL242QFA0B3 = true;
            if (!DFDL242QFA0B3)
                DFDL242QFA0B3 = false;
            else if (DFDL242QFA0B3 = false)
                DFDL242QFA0B3 = true;
            else
                DFDL242QFA0B3 = true;
            int D45F4B0SNEG7Y = 251367197;
            if (D45F4B0SNEG7Y > 251367168)
                D45F4B0SNEG7Y = 251367153;
            else if (D45F4B0SNEG7Y <= 251367159)
                D45F4B0SNEG7Y++;
            else
                D45F4B0SNEG7Y = (251367124 / 251367124);
            bool DGEBIWRXZGZMF = false;
            if (!DGEBIWRXZGZMF)
                DGEBIWRXZGZMF = true;
            else if (DGEBIWRXZGZMF = false)
                DGEBIWRXZGZMF = true;
            else
                DGEBIWRXZGZMF = false;
            int D2KKE681XJ9EL = 251367188;
            if (D2KKE681XJ9EL > 251367152)
                D2KKE681XJ9EL = 251367133;
            else if (D2KKE681XJ9EL <= 251367114)
                D2KKE681XJ9EL++;
            else
                D2KKE681XJ9EL = (251367102 / 251367151);
            bool DFASIHG0A6GRC = true;
            if (!DFASIHG0A6GRC)
                DFASIHG0A6GRC = true;
            else if (DFASIHG0A6GRC = false)
                DFASIHG0A6GRC = false;
            else
                DFASIHG0A6GRC = false;
            int D89L0J0J35PB4 = 251367129;
            if (D89L0J0J35PB4 > 251367123)
                D89L0J0J35PB4 = 251367145;
            else if (D89L0J0J35PB4 <= 251367134)
                D89L0J0J35PB4++;
            else
                D89L0J0J35PB4 = (251367128 / 251367140);
            bool DYYXJYL35795R = false;
            if (!DYYXJYL35795R)
                DYYXJYL35795R = true;
            else if (DYYXJYL35795R = false)
                DYYXJYL35795R = true;
            else
                DYYXJYL35795R = false;
            int D6WYPKHD5LKIZ = 251367174;
            if (D6WYPKHD5LKIZ > 251367123)
                D6WYPKHD5LKIZ = 251367173;
            else if (D6WYPKHD5LKIZ <= 251367181)
                D6WYPKHD5LKIZ++;
            else
                D6WYPKHD5LKIZ = (251367185 / 251367125);
            bool DBLECHHOFZ7B0 = true;
            if (!DBLECHHOFZ7B0)
                DBLECHHOFZ7B0 = true;
            else if (DBLECHHOFZ7B0 = true)
                DBLECHHOFZ7B0 = true;
            else
                DBLECHHOFZ7B0 = false;
            bool DI8EI4M6XWDSY = false;
            if (!DI8EI4M6XWDSY)
                DI8EI4M6XWDSY = false;
            else if (DI8EI4M6XWDSY = false)
                DI8EI4M6XWDSY = false;
            else
                DI8EI4M6XWDSY = false;
            int DB3JP6I21ID5J = 251367192;
            if (DB3JP6I21ID5J > 251367198)
                DB3JP6I21ID5J = 251367130;
            else if (DB3JP6I21ID5J <= 251367173)
                DB3JP6I21ID5J++;
            else
                DB3JP6I21ID5J = (251367109 / 251367122);
            bool DIIZBB4KGAAPX = false;
            if (!DIIZBB4KGAAPX)
                DIIZBB4KGAAPX = true;
            else if (DIIZBB4KGAAPX = true)
                DIIZBB4KGAAPX = true;
            else
                DIIZBB4KGAAPX = false;
            int DIM7QCEBHMCKH = 251367169;
            if (DIM7QCEBHMCKH > 251367143)
                DIM7QCEBHMCKH = 251367175;
            else if (DIM7QCEBHMCKH <= 251367184)
                DIM7QCEBHMCKH++;
            else
                DIM7QCEBHMCKH = (251367140 / 251367131);
            int DBGC522PGWE8E = 251367193;
            if (DBGC522PGWE8E > 251367184)
                DBGC522PGWE8E = 251367147;
            else if (DBGC522PGWE8E <= 251367183)
                DBGC522PGWE8E++;
            else
                DBGC522PGWE8E = (251367148 / 251367134);
            bool DE925XP08SBHF = false;
            if (!DE925XP08SBHF)
                DE925XP08SBHF = false;
            else if (DE925XP08SBHF = false)
                DE925XP08SBHF = false;
            else
                DE925XP08SBHF = true;
            int DRF8K08MIEDR3 = 251367128;
            if (DRF8K08MIEDR3 > 251367182)
                DRF8K08MIEDR3 = 251367198;
            else if (DRF8K08MIEDR3 <= 251367190)
                DRF8K08MIEDR3++;
            else
                DRF8K08MIEDR3 = (251367132 / 251367177);
            bool DLGX05930EARN = true;
            if (!DLGX05930EARN)
                DLGX05930EARN = true;
            else if (DLGX05930EARN = true)
                DLGX05930EARN = true;
            else
                DLGX05930EARN = false;
            bool DX67ZZI1LGE1N = true;
            if (!DX67ZZI1LGE1N)
                DX67ZZI1LGE1N = true;
            else if (DX67ZZI1LGE1N = true)
                DX67ZZI1LGE1N = false;
            else
                DX67ZZI1LGE1N = true;
            int DC0OAQM51FBEL = 251367105;
            if (DC0OAQM51FBEL > 251367115)
                DC0OAQM51FBEL = 251367164;
            else if (DC0OAQM51FBEL <= 251367166)
                DC0OAQM51FBEL++;
            else
                DC0OAQM51FBEL = (251367192 / 251367133);
            int D30HH7O9FDGZX = 251367134;
            if (D30HH7O9FDGZX > 251367120)
                D30HH7O9FDGZX = 251367167;
            else if (D30HH7O9FDGZX <= 251367146)
                D30HH7O9FDGZX++;
            else
                D30HH7O9FDGZX = (251367187 / 251367149);
            bool DME861SNPDW2C = false;
            if (!DME861SNPDW2C)
                DME861SNPDW2C = true;
            else if (DME861SNPDW2C = true)
                DME861SNPDW2C = true;
            else
                DME861SNPDW2C = false;
        }
    }
}*/