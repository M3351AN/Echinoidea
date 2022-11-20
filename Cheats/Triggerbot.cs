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

                        if (EntityTeam != Engine.Team)
                        {
                            int iSeed = 10;
                            Random ro = new Random(10);
                            long tick = DateTime.Now.Ticks;
                            Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
                            int iResult;
                            iResult = ro.Next(16, 21);
                            //G.Engine.Shoot();

                            Memory.mouse_event(0x0002, 0, 0, 0, 0);
                            //Thread.Sleep(iResult);
                            Memory.mouse_event(0x0004, 0, 0, 0, 0);
                        }
                    }

                    Thread.Sleep(2);// make DELAY and reduce cpu usage again
                }

            }
        }
    }
}