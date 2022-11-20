using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZBase.Classes;
using ZBase.Utilities;
using Math = ZBase.Classes.Maths;

namespace ZBase.Cheats
{
    public class Aimassistant
    {

        public static void Run()
        {
            int UserSens = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwSensitivity);
            while (true)
            {
                   if (Main.S.AimEnabled){
                    //for (int i = 0; i < Engine.MaxPlayer; i++)
                    //{
                        int EntityInCrossID = Memory.ReadMemory<int>(Engine.LocalPlayerPtr + Main.O.netvars.m_iCrosshairId);
                        if (EntityInCrossID > 0 && EntityInCrossID <= 64)
                        {
                        int EntityBase = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwEntityList + (EntityInCrossID - 1) * 0x10);
                        int EntityTeam = Memory.ReadMemory<int>(EntityBase + Main.O.netvars.m_iTeamNum);
                        //int PlayerTeam = Memory.ReadMemory<int>(Structs.LocalPlayer.Base + Main.O.netvars.m_iTeamNum);
                        if (EntityTeam != Engine.Team)
                        {
                                    Memory.WriteMemory<int>((int)Memory.Client + Main.O.signatures.dwSensitivity, 531155266);
                        }
                            
                        }
                        else
                        {
                            Memory.WriteMemory<int>((int)Memory.Client + Main.O.signatures.dwSensitivity, UserSens);
                        }
                    //}
                }
            }
        }
    }
}