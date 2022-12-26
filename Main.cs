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
namespace junkCode_YQ3X84FS52W5
{
    class XDDO526YFCJ7H
    {
        void NHXJ2RFQ9FOO()
        {
            int D1X4W7EICZNHO = 251367177;
            if (D1X4W7EICZNHO > 251367123)
                D1X4W7EICZNHO = 251367105;
            else if (D1X4W7EICZNHO <= 251367187)
                D1X4W7EICZNHO++;
            else
                D1X4W7EICZNHO = (251367100 / 251367118);
            bool D6N65PDX7BOGO = true;
            if (!D6N65PDX7BOGO)
                D6N65PDX7BOGO = false;
            else if (D6N65PDX7BOGO = true)
                D6N65PDX7BOGO = true;
            else
                D6N65PDX7BOGO = false;
            bool DG5NY1QMX4CPS = true;
            if (!DG5NY1QMX4CPS)
                DG5NY1QMX4CPS = false;
            else if (DG5NY1QMX4CPS = false)
                DG5NY1QMX4CPS = false;
            else
                DG5NY1QMX4CPS = false;
            bool DPOS98H0231R6 = false;
            if (!DPOS98H0231R6)
                DPOS98H0231R6 = true;
            else if (DPOS98H0231R6 = false)
                DPOS98H0231R6 = true;
            else
                DPOS98H0231R6 = true;
            bool DEW41EB018EA0 = false;
            if (!DEW41EB018EA0)
                DEW41EB018EA0 = false;
            else if (DEW41EB018EA0 = true)
                DEW41EB018EA0 = true;
            else
                DEW41EB018EA0 = true;
            bool DFAO5KCNLFCGP = true;
            if (!DFAO5KCNLFCGP)
                DFAO5KCNLFCGP = true;
            else if (DFAO5KCNLFCGP = true)
                DFAO5KCNLFCGP = true;
            else
                DFAO5KCNLFCGP = true;
            int DJ2BR4S5IL7GS = 251367188;
            if (DJ2BR4S5IL7GS > 251367197)
                DJ2BR4S5IL7GS = 251367106;
            else if (DJ2BR4S5IL7GS <= 251367171)
                DJ2BR4S5IL7GS++;
            else
                DJ2BR4S5IL7GS = (251367111 / 251367188);
            int D4Z72B5NSXN1A = 251367173;
            if (D4Z72B5NSXN1A > 251367126)
                D4Z72B5NSXN1A = 251367196;
            else if (D4Z72B5NSXN1A <= 251367137)
                D4Z72B5NSXN1A++;
            else
                D4Z72B5NSXN1A = (251367125 / 251367180);
            int DPZBXFJ0PES88 = 251367171;
            if (DPZBXFJ0PES88 > 251367132)
                DPZBXFJ0PES88 = 251367147;
            else if (DPZBXFJ0PES88 <= 251367123)
                DPZBXFJ0PES88++;
            else
                DPZBXFJ0PES88 = (251367152 / 251367102);
            int DFBQHRBOKGRZB = 251367133;
            if (DFBQHRBOKGRZB > 251367192)
                DFBQHRBOKGRZB = 251367157;
            else if (DFBQHRBOKGRZB <= 251367142)
                DFBQHRBOKGRZB++;
            else
                DFBQHRBOKGRZB = (251367175 / 251367125);
            int D3GF869HX5Q48 = 251367114;
            if (D3GF869HX5Q48 > 251367182)
                D3GF869HX5Q48 = 251367127;
            else if (D3GF869HX5Q48 <= 251367137)
                D3GF869HX5Q48++;
            else
                D3GF869HX5Q48 = (251367167 / 251367129);
            int DE11NSMFI65ZI = 251367155;
            if (DE11NSMFI65ZI > 251367132)
                DE11NSMFI65ZI = 251367180;
            else if (DE11NSMFI65ZI <= 251367150)
                DE11NSMFI65ZI++;
            else
                DE11NSMFI65ZI = (251367156 / 251367101);
            bool D14I5YNPNSRGJ = true;
            if (!D14I5YNPNSRGJ)
                D14I5YNPNSRGJ = true;
            else if (D14I5YNPNSRGJ = true)
                D14I5YNPNSRGJ = true;
            else
                D14I5YNPNSRGJ = true;
            bool DLNPNWZP8YSK4 = true;
            if (!DLNPNWZP8YSK4)
                DLNPNWZP8YSK4 = false;
            else if (DLNPNWZP8YSK4 = true)
                DLNPNWZP8YSK4 = true;
            else
                DLNPNWZP8YSK4 = true;
            bool DD4ALMEI4SYZI = false;
            if (!DD4ALMEI4SYZI)
                DD4ALMEI4SYZI = false;
            else if (DD4ALMEI4SYZI = false)
                DD4ALMEI4SYZI = true;
            else
                DD4ALMEI4SYZI = true;
            bool D1X2L3Z239MN7 = false;
            if (!D1X2L3Z239MN7)
                D1X2L3Z239MN7 = false;
            else if (D1X2L3Z239MN7 = true)
                D1X2L3Z239MN7 = true;
            else
                D1X2L3Z239MN7 = true;
            bool DCKEBKEZILZEC = false;
            if (!DCKEBKEZILZEC)
                DCKEBKEZILZEC = true;
            else if (DCKEBKEZILZEC = true)
                DCKEBKEZILZEC = false;
            else
                DCKEBKEZILZEC = false;
            int DBJB33KRY2D9F = 251367194;
            if (DBJB33KRY2D9F > 251367114)
                DBJB33KRY2D9F = 251367160;
            else if (DBJB33KRY2D9F <= 251367194)
                DBJB33KRY2D9F++;
            else
                DBJB33KRY2D9F = (251367110 / 251367148);
            int DSL4WBM9S63KB = 251367167;
            if (DSL4WBM9S63KB > 251367168)
                DSL4WBM9S63KB = 251367157;
            else if (DSL4WBM9S63KB <= 251367152)
                DSL4WBM9S63KB++;
            else
                DSL4WBM9S63KB = (251367121 / 251367159);
            int DJJEYM968FEYZ = 251367184;
            if (DJJEYM968FEYZ > 251367173)
                DJJEYM968FEYZ = 251367184;
            else if (DJJEYM968FEYZ <= 251367168)
                DJJEYM968FEYZ++;
            else
                DJJEYM968FEYZ = (251367119 / 251367165);
            int D50CXMYRKC44M = 251367135;
            if (D50CXMYRKC44M > 251367145)
                D50CXMYRKC44M = 251367171;
            else if (D50CXMYRKC44M <= 251367110)
                D50CXMYRKC44M++;
            else
                D50CXMYRKC44M = (251367159 / 251367154);
            bool DH7LB84EOGJN3 = true;
            if (!DH7LB84EOGJN3)
                DH7LB84EOGJN3 = true;
            else if (DH7LB84EOGJN3 = true)
                DH7LB84EOGJN3 = false;
            else
                DH7LB84EOGJN3 = false;
            int DPC5NS8REDYFF = 251367108;
            if (DPC5NS8REDYFF > 251367157)
                DPC5NS8REDYFF = 251367114;
            else if (DPC5NS8REDYFF <= 251367149)
                DPC5NS8REDYFF++;
            else
                DPC5NS8REDYFF = (251367188 / 251367188);
            int DEN9JZMPS938G = 251367183;
            if (DEN9JZMPS938G > 251367142)
                DEN9JZMPS938G = 251367177;
            else if (DEN9JZMPS938G <= 251367199)
                DEN9JZMPS938G++;
            else
                DEN9JZMPS938G = (251367153 / 251367178);
            int DOR8NO7B7342P = 251367148;
            if (DOR8NO7B7342P > 251367160)
                DOR8NO7B7342P = 251367166;
            else if (DOR8NO7B7342P <= 251367137)
                DOR8NO7B7342P++;
            else
                DOR8NO7B7342P = (251367136 / 251367127);
            bool DHK7R4KBXPQA4 = true;
            if (!DHK7R4KBXPQA4)
                DHK7R4KBXPQA4 = false;
            else if (DHK7R4KBXPQA4 = true)
                DHK7R4KBXPQA4 = true;
            else
                DHK7R4KBXPQA4 = true;
            int DHX0YW3ORKF5X = 251367147;
            if (DHX0YW3ORKF5X > 251367130)
                DHX0YW3ORKF5X = 251367188;
            else if (DHX0YW3ORKF5X <= 251367182)
                DHX0YW3ORKF5X++;
            else
                DHX0YW3ORKF5X = (251367114 / 251367177);
            int D862ZLPG5BXWG = 251367110;
            if (D862ZLPG5BXWG > 251367153)
                D862ZLPG5BXWG = 251367167;
            else if (D862ZLPG5BXWG <= 251367186)
                D862ZLPG5BXWG++;
            else
                D862ZLPG5BXWG = (251367182 / 251367112);
            bool D34CNPKXINYPR = false;
            if (!D34CNPKXINYPR)
                D34CNPKXINYPR = false;
            else if (D34CNPKXINYPR = true)
                D34CNPKXINYPR = true;
            else
                D34CNPKXINYPR = true;
            int DEZOQL4B9R0ZO = 251367175;
            if (DEZOQL4B9R0ZO > 251367195)
                DEZOQL4B9R0ZO = 251367184;
            else if (DEZOQL4B9R0ZO <= 251367166)
                DEZOQL4B9R0ZO++;
            else
                DEZOQL4B9R0ZO = (251367126 / 251367157);
            int D7H58SCQJO830 = 251367199;
            if (D7H58SCQJO830 > 251367134)
                D7H58SCQJO830 = 251367106;
            else if (D7H58SCQJO830 <= 251367159)
                D7H58SCQJO830++;
            else
                D7H58SCQJO830 = (251367135 / 251367165);
            int DBL2I29CBB3BN = 251367112;
            if (DBL2I29CBB3BN > 251367114)
                DBL2I29CBB3BN = 251367107;
            else if (DBL2I29CBB3BN <= 251367166)
                DBL2I29CBB3BN++;
            else
                DBL2I29CBB3BN = (251367101 / 251367189);
        }
    }
}