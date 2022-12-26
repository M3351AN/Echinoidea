using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZBase.Cheats;
using ZBase.Classes;
using ZBase.Utilities;

namespace ZBase
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (Main.RunStartup())
            { 
                OffsetUpdater.UpdateOffsets();
                #region Start Threads
                // found the process and everything, lets start our cheats in a new thread
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    CheckMenu();
                }).Start();

                Tools.InitializeGlobals();

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Trigger.Run();
                }).Start();
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Visuals v = new Visuals();
                    v.Run();
                }).Start();
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Aimassistant.Run();
                }).Start();
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Bunnyhop.Run();
                }).Start();
                #endregion
            }
        }
        public static string GetRandomMenutitle(int length, bool useNum, bool useLow, bool useUpp, bool useSpe, string custom)
        {
            byte[] b = new byte[4];
            new System.Security.Cryptography.RNGCryptoServiceProvider().GetBytes(b);
            Random r = new Random(BitConverter.ToInt32(b, 0));
            string s = null, str = custom;
            if (useNum == true) { str += "0123456789雲丹"; }
            if (useLow == true) { str += "abcdefghijklmnopqrstuvwxyz"; }
            if (useUpp == true) { str += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; }
            if (useSpe == true) { str += "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~"; }
            for (int i = 0; i < length; i++)
            {
                s += str.Substring(r.Next(0, str.Length - 1), 1);
            }
            return s;
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            TopMost = true; // make this hover over the game, can remove if you want
            Text = "[雲丹Echinoidea] " + GetRandomMenutitle(16, true, true, true, true,"m1tzw");
        }

        public void CheckMenu()
        {
            // Here we make the main variables equal to what our menu checkboxes say
            while (true)
            {
                Main.S.BunnyhopEnabled = BunnyhopCheck.Checked;
                Main.S.BunnyhopAccuracy = BunnyhopInaccuracy.Value;
                
                Main.S.ESP = ESPCheck.Checked;
                Main.S.TriggerbotEnabled = TriggerbotCheck.Checked;
                Main.S.AimEnabled = AimCheck.Checked;
                if ((Memory.GetAsyncKeyState(Keys.VK_INSERT) & 1) > 0)
                    Visible = !Visible;
                Text =DateTime.UtcNow+"[雲丹Echinoidea] " + GetRandomMenutitle(16, true, true, true, true, "m1tzw");
                Thread.Sleep(100); // Greatly reduces cpu usage
            }
        }

        private void GithubBTN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/M3351AN");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ESPCFGBTN_Click(object sender, EventArgs e)
        {
            云丹.Forms.Form1 f = new 云丹.Forms.Form1();
            f.ShowDialog();
        }
    }
}
