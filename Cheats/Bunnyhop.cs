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
    public class Bunnyhop
    {
        static void SendInputWithAPI()
        {
            Memory.INPUT[] Inputs = new Memory.INPUT[1];
            Memory.INPUT Input = new Memory.INPUT();

            Input.type = 1; // 1 = Keyboard Input
            Input.U.ki.wScan = Memory.ScanCodeShort.SPACE;
            Input.U.ki.dwFlags = Memory.KEYEVENTF.SCANCODE;
            Inputs[0] = Input;

            Memory.SendInput(1, Inputs, Memory.INPUT.Size);

            Random time = new Random();

            int randTime = time.Next(1, Main.S.BunnyhopAccuracy*2);

            Thread.Sleep(randTime/2);

            Input.type = 1;
            Input.U.ki.dwFlags = Memory.KEYEVENTF.KEYUP | Memory.KEYEVENTF.SCANCODE;
            Inputs[0] = Input;

            Memory.SendInput(1, Inputs, Memory.INPUT.Size);

            Thread.Sleep(randTime/2);
        }
        public static void Run()
        {
            while (true)
            {
                if (Main.S.BunnyhopEnabled) // make sure the cheats enabled in the menu
                {
                    if (Tools.HoldingKey(Keys.VK_C)) // while holding space
                    {
                        // Flags show if you are on the ground or not. 257 is standing on the ground, and 263 is crouching on the ground.


                        //if ((G.Engine.LocalPlayer.Flags == 257 || G.Engine.LocalPlayer.Flags == 263) && G.Engine.LocalPlayer.Velocity > 10)
                        if (G.Engine.LocalPlayer.Velocity > 10)
                        {
                            //G.Engine.Jump();
                            SendInputWithAPI();



                        }

                    }
                }
                int iSeed = 10;
                Random ro = new Random(10);
                long tick = DateTime.Now.Ticks;
                Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
                int iResult;
                iResult = ro.Next(1,2);
                Thread.Sleep(iResult); //reduce cpu usage
            }
        }

    }
}
