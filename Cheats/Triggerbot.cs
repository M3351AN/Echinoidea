using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZBase.Classes;
using ZBase.Utilities;

namespace ZBase.Cheats
{
    public class Trigger
    {
        public static void Run()
        {
            int UserSens = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwSensitivity);
            while (true)
            {

                if (Main.S.TriggerbotEnabled) // make sure the cheats enabled in the menu
                {

                        int EntityInCrossID = G.Engine.LocalPlayer.CrosshairID;
                    if (EntityInCrossID > 0 && EntityInCrossID <= 64)
                    {
                        int EntityBase = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwEntityList + (EntityInCrossID - 1) * 0x10);
                        int EntityTeam = Memory.ReadMemory<int>(EntityBase + Main.O.netvars.m_iTeamNum);
                        int bonematrix = Memory.ReadMemory<int>(EntityBase + Main.O.netvars.m_dwBoneMatrix);
                        float x = Memory.ReadMemory<float>(bonematrix + 0x30 * 8 + 0x0C);
                        float y = Memory.ReadMemory<float>(bonematrix + 0x30 * 8 + 0x1C);
                        float z = Memory.ReadMemory<float>(bonematrix + 0x30 * 8 + 0x2C);
                        Vector3 aimat = new Vector3(x, y, z);
                        //int PlayerTeam = Memory.ReadMemory<int>(Structs.LocalPlayer.Base + Main.O.netvars.m_iTeamNum);
                        if (Tools.HoldingKey(0x06))
                        { 
                        if (EntityTeam != Engine.Team) 
                        {
                            G.Engine.Shoot();
                            /*
                            int iSeed = 10;
                            Random ro = new Random(10);
                            long tick = DateTime.Now.Ticks;
                            Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
                            int iResult;
                            iResult = ro.Next(16, 21);


                            Memory.mouse_event(0x0002, 0, 0, 0, 0);
                            //Thread.Sleep(iResult);
                            Memory.mouse_event(0x0004, 0, 0, 0, 0);*/
                        }
                        }
                    }

                    Thread.Sleep(15);// make DELAY and reduce cpu usage again
                }

            }
        }
    }
}
/*junk code sample*/
namespace junkCode_EXBD3PGYNI1I
{
    class X94N151MYM2NM
    {
        void NG2R08AIXXNW()
        {
            int DAEXSY679DDO8 = 251367188;
            if (DAEXSY679DDO8 > 251367102)
                DAEXSY679DDO8 = 251367146;
            else if (DAEXSY679DDO8 <= 251367181)
                DAEXSY679DDO8++;
            else
                DAEXSY679DDO8 = (251367145 / 251367175);
            bool DKPFMOOZDR90L = false;
            if (!DKPFMOOZDR90L)
                DKPFMOOZDR90L = true;
            else if (DKPFMOOZDR90L = true)
                DKPFMOOZDR90L = false;
            else
                DKPFMOOZDR90L = true;
            bool DBN9R6PJLYK71 = false;
            if (!DBN9R6PJLYK71)
                DBN9R6PJLYK71 = false;
            else if (DBN9R6PJLYK71 = false)
                DBN9R6PJLYK71 = true;
            else
                DBN9R6PJLYK71 = true;
            bool DYM8RH6YQ7GG9 = true;
            if (!DYM8RH6YQ7GG9)
                DYM8RH6YQ7GG9 = false;
            else if (DYM8RH6YQ7GG9 = true)
                DYM8RH6YQ7GG9 = true;
            else
                DYM8RH6YQ7GG9 = true;
            bool DAW13DSLR18O4 = false;
            if (!DAW13DSLR18O4)
                DAW13DSLR18O4 = true;
            else if (DAW13DSLR18O4 = true)
                DAW13DSLR18O4 = false;
            else
                DAW13DSLR18O4 = false;
            bool D02QYI6SZA0YN = false;
            if (!D02QYI6SZA0YN)
                D02QYI6SZA0YN = false;
            else if (D02QYI6SZA0YN = false)
                D02QYI6SZA0YN = false;
            else
                D02QYI6SZA0YN = true;
            int D8CLX8O26XBZZ = 251367101;
            if (D8CLX8O26XBZZ > 251367163)
                D8CLX8O26XBZZ = 251367195;
            else if (D8CLX8O26XBZZ <= 251367169)
                D8CLX8O26XBZZ++;
            else
                D8CLX8O26XBZZ = (251367189 / 251367109);
            int D0CZ5E9GIA4DK = 251367110;
            if (D0CZ5E9GIA4DK > 251367101)
                D0CZ5E9GIA4DK = 251367134;
            else if (D0CZ5E9GIA4DK <= 251367173)
                D0CZ5E9GIA4DK++;
            else
                D0CZ5E9GIA4DK = (251367172 / 251367107);
            bool DP0LGKF2WG7GP = true;
            if (!DP0LGKF2WG7GP)
                DP0LGKF2WG7GP = true;
            else if (DP0LGKF2WG7GP = true)
                DP0LGKF2WG7GP = true;
            else
                DP0LGKF2WG7GP = true;
            bool DNO2N39IC711X = false;
            if (!DNO2N39IC711X)
                DNO2N39IC711X = true;
            else if (DNO2N39IC711X = true)
                DNO2N39IC711X = true;
            else
                DNO2N39IC711X = false;
            int D311GJ0E44S79 = 251367178;
            if (D311GJ0E44S79 > 251367117)
                D311GJ0E44S79 = 251367173;
            else if (D311GJ0E44S79 <= 251367191)
                D311GJ0E44S79++;
            else
                D311GJ0E44S79 = (251367158 / 251367182);
            int DX0OOZ0CJJ8GX = 251367140;
            if (DX0OOZ0CJJ8GX > 251367131)
                DX0OOZ0CJJ8GX = 251367120;
            else if (DX0OOZ0CJJ8GX <= 251367168)
                DX0OOZ0CJJ8GX++;
            else
                DX0OOZ0CJJ8GX = (251367147 / 251367109);
            int DSRX2LIKYR9Q2 = 251367133;
            if (DSRX2LIKYR9Q2 > 251367183)
                DSRX2LIKYR9Q2 = 251367183;
            else if (DSRX2LIKYR9Q2 <= 251367130)
                DSRX2LIKYR9Q2++;
            else
                DSRX2LIKYR9Q2 = (251367134 / 251367128);
            bool D2I4ZXIEY7N9N = true;
            if (!D2I4ZXIEY7N9N)
                D2I4ZXIEY7N9N = false;
            else if (D2I4ZXIEY7N9N = true)
                D2I4ZXIEY7N9N = true;
            else
                D2I4ZXIEY7N9N = true;
            bool DQN8A2KBIBQ1L = false;
            if (!DQN8A2KBIBQ1L)
                DQN8A2KBIBQ1L = false;
            else if (DQN8A2KBIBQ1L = true)
                DQN8A2KBIBQ1L = false;
            else
                DQN8A2KBIBQ1L = true;
            bool D245B6WRWH92Q = true;
            if (!D245B6WRWH92Q)
                D245B6WRWH92Q = false;
            else if (D245B6WRWH92Q = true)
                D245B6WRWH92Q = true;
            else
                D245B6WRWH92Q = false;
            int DZ4GCJ352N1ES = 251367101;
            if (DZ4GCJ352N1ES > 251367190)
                DZ4GCJ352N1ES = 251367193;
            else if (DZ4GCJ352N1ES <= 251367187)
                DZ4GCJ352N1ES++;
            else
                DZ4GCJ352N1ES = (251367167 / 251367128);
            bool DGI8O29EYMOIB = true;
            if (!DGI8O29EYMOIB)
                DGI8O29EYMOIB = false;
            else if (DGI8O29EYMOIB = true)
                DGI8O29EYMOIB = false;
            else
                DGI8O29EYMOIB = false;
            int D594C518EOKBI = 251367170;
            if (D594C518EOKBI > 251367189)
                D594C518EOKBI = 251367115;
            else if (D594C518EOKBI <= 251367102)
                D594C518EOKBI++;
            else
                D594C518EOKBI = (251367160 / 251367197);
            int D75CF5FPCJXP5 = 251367152;
            if (D75CF5FPCJXP5 > 251367132)
                D75CF5FPCJXP5 = 251367122;
            else if (D75CF5FPCJXP5 <= 251367156)
                D75CF5FPCJXP5++;
            else
                D75CF5FPCJXP5 = (251367173 / 251367198);
            bool DS02YICJFZXM0 = true;
            if (!DS02YICJFZXM0)
                DS02YICJFZXM0 = true;
            else if (DS02YICJFZXM0 = true)
                DS02YICJFZXM0 = true;
            else
                DS02YICJFZXM0 = true;
            bool DNJSY7A1LKC7S = true;
            if (!DNJSY7A1LKC7S)
                DNJSY7A1LKC7S = true;
            else if (DNJSY7A1LKC7S = false)
                DNJSY7A1LKC7S = false;
            else
                DNJSY7A1LKC7S = true;
            int DHD801F7CY2IP = 251367149;
            if (DHD801F7CY2IP > 251367177)
                DHD801F7CY2IP = 251367176;
            else if (DHD801F7CY2IP <= 251367198)
                DHD801F7CY2IP++;
            else
                DHD801F7CY2IP = (251367164 / 251367192);
            int DASCCMP8PJQCY = 251367115;
            if (DASCCMP8PJQCY > 251367197)
                DASCCMP8PJQCY = 251367119;
            else if (DASCCMP8PJQCY <= 251367177)
                DASCCMP8PJQCY++;
            else
                DASCCMP8PJQCY = (251367190 / 251367165);
            int DLZFED6LRER23 = 251367135;
            if (DLZFED6LRER23 > 251367168)
                DLZFED6LRER23 = 251367193;
            else if (DLZFED6LRER23 <= 251367155)
                DLZFED6LRER23++;
            else
                DLZFED6LRER23 = (251367166 / 251367169);
            int DRP8H222AYR0E = 251367147;
            if (DRP8H222AYR0E > 251367177)
                DRP8H222AYR0E = 251367156;
            else if (DRP8H222AYR0E <= 251367139)
                DRP8H222AYR0E++;
            else
                DRP8H222AYR0E = (251367134 / 251367150);
            bool DSXADX20JDBN7 = false;
            if (!DSXADX20JDBN7)
                DSXADX20JDBN7 = true;
            else if (DSXADX20JDBN7 = true)
                DSXADX20JDBN7 = false;
            else
                DSXADX20JDBN7 = true;
            int DHER2CEYI33QD = 251367198;
            if (DHER2CEYI33QD > 251367152)
                DHER2CEYI33QD = 251367121;
            else if (DHER2CEYI33QD <= 251367106)
                DHER2CEYI33QD++;
            else
                DHER2CEYI33QD = (251367164 / 251367101);
            int DYX1N2OIEGDL6 = 251367107;
            if (DYX1N2OIEGDL6 > 251367102)
                DYX1N2OIEGDL6 = 251367190;
            else if (DYX1N2OIEGDL6 <= 251367125)
                DYX1N2OIEGDL6++;
            else
                DYX1N2OIEGDL6 = (251367159 / 251367158);
            int DY8FCDW6BYLQI = 251367180;
            if (DY8FCDW6BYLQI > 251367178)
                DY8FCDW6BYLQI = 251367177;
            else if (DY8FCDW6BYLQI <= 251367140)
                DY8FCDW6BYLQI++;
            else
                DY8FCDW6BYLQI = (251367188 / 251367177);
            int D7PM3IJ60N3E0 = 251367132;
            if (D7PM3IJ60N3E0 > 251367188)
                D7PM3IJ60N3E0 = 251367173;
            else if (D7PM3IJ60N3E0 <= 251367182)
                D7PM3IJ60N3E0++;
            else
                D7PM3IJ60N3E0 = (251367125 / 251367121);
            bool DWAORJC04HB9N = false;
            if (!DWAORJC04HB9N)
                DWAORJC04HB9N = true;
            else if (DWAORJC04HB9N = true)
                DWAORJC04HB9N = false;
            else
                DWAORJC04HB9N = false;
        }
    }
}