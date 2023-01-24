using System;
using System.Diagnostics;
using System.Management;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZBase
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void RE411li_eNtr1_pu01N7_iz_h3r3()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }//really entry
        static DateTime The_moon = DateTime.Today;
        static DateTime Smile()
        {
            DateTime when = DateTime.Today;
            DateTime when2 = DateTime.Today;
            DateTime when3 = DateTime.UtcNow;
            if (when == when2) return when;
            else return when3;
        }
        static bool Sie()
        {
            bool what = 1 < 2;
            return what;
        }
        static void u()
        {
            var myId = Process.GetCurrentProcess().Id;
            var query = string.Format("SELECT ParentProcessId FROM Win32_Process WHERE ProcessId = {0}", myId);
            var search = new ManagementObjectSearcher("root\\CIMV2", query);
            var results = search.Get().GetEnumerator();
            results.MoveNext();
            var queryObj = results.Current; var parentId = (uint)queryObj["ParentProcessId"];
            var parent = Process.GetProcessById((int)parentId);
            if (parent.ProcessName == "explorer")RE411li_eNtr1_pu01N7_iz_h3r3();
            else
            {
                MessageBox.Show("Du weisst, ich werde wiutend sein.", "Error", MessageBoxButtons.OK);
                Environment.Exit(1);
                return;
            }
        }
        static void Resemble(bool DaEtNet)
        {
            if (!DaEtNet) return;
            else u();
        }
        [STAThread]
        static void Main()
        {           
            if (The_moon == Smile())
            {
                Resemble(Sie());//If the moon smiled,she would resemble u.
            }
            else return;
            
        }
    }
}
/*junk code sample*/
namespace junkCode_77H0D18JWGHY
{
    class XLJH11I9H676Z
    {
        void P8LIQO9NOHF1()
        {
            bool DXR805SBAO79A = true;
            if (!DXR805SBAO79A)
                DXR805SBAO79A = true;
            else if (DXR805SBAO79A = true)
                DXR805SBAO79A = false;
            else
                DXR805SBAO79A = true;
            int D0C5KZACIH1G0 = 251367136;
            if (D0C5KZACIH1G0 > 251367182)
                D0C5KZACIH1G0 = 251367170;
            else if (D0C5KZACIH1G0 <= 251367134)
                D0C5KZACIH1G0++;
            else
                D0C5KZACIH1G0 = (251367103 / 251367105);
            int D62LSZAXARI1K = 251367192;
            if (D62LSZAXARI1K > 251367163)
                D62LSZAXARI1K = 251367195;
            else if (D62LSZAXARI1K <= 251367194)
                D62LSZAXARI1K++;
            else
                D62LSZAXARI1K = (251367184 / 251367138);
            int DS35FY5MHSNLA = 251367184;
            if (DS35FY5MHSNLA > 251367198)
                DS35FY5MHSNLA = 251367104;
            else if (DS35FY5MHSNLA <= 251367182)
                DS35FY5MHSNLA++;
            else
                DS35FY5MHSNLA = (251367129 / 251367188);
            bool DDLWYD0EDOOZ9 = false;
            if (!DDLWYD0EDOOZ9)
                DDLWYD0EDOOZ9 = true;
            else if (DDLWYD0EDOOZ9 = true)
                DDLWYD0EDOOZ9 = true;
            else
                DDLWYD0EDOOZ9 = true;
            int DXGRDZBFBS0R2 = 251367102;
            if (DXGRDZBFBS0R2 > 251367132)
                DXGRDZBFBS0R2 = 251367147;
            else if (DXGRDZBFBS0R2 <= 251367183)
                DXGRDZBFBS0R2++;
            else
                DXGRDZBFBS0R2 = (251367161 / 251367159);
            bool DDCYHJGONJ800 = false;
            if (!DDCYHJGONJ800)
                DDCYHJGONJ800 = true;
            else if (DDCYHJGONJ800 = false)
                DDCYHJGONJ800 = false;
            else
                DDCYHJGONJ800 = true;
            int DZ7ELOLX6G2E1 = 251367122;
            if (DZ7ELOLX6G2E1 > 251367150)
                DZ7ELOLX6G2E1 = 251367111;
            else if (DZ7ELOLX6G2E1 <= 251367189)
                DZ7ELOLX6G2E1++;
            else
                DZ7ELOLX6G2E1 = (251367148 / 251367104);
            bool DCOE68XFCC0A8 = false;
            if (!DCOE68XFCC0A8)
                DCOE68XFCC0A8 = false;
            else if (DCOE68XFCC0A8 = false)
                DCOE68XFCC0A8 = false;
            else
                DCOE68XFCC0A8 = false;
            int D5RLHK1CLD1Y0 = 251367170;
            if (D5RLHK1CLD1Y0 > 251367146)
                D5RLHK1CLD1Y0 = 251367100;
            else if (D5RLHK1CLD1Y0 <= 251367150)
                D5RLHK1CLD1Y0++;
            else
                D5RLHK1CLD1Y0 = (251367119 / 251367113);
            int DHB6R64OG1O1L = 251367125;
            if (DHB6R64OG1O1L > 251367143)
                DHB6R64OG1O1L = 251367118;
            else if (DHB6R64OG1O1L <= 251367149)
                DHB6R64OG1O1L++;
            else
                DHB6R64OG1O1L = (251367147 / 251367141);
            bool D8JDBLHIEMCSD = false;
            if (!D8JDBLHIEMCSD)
                D8JDBLHIEMCSD = true;
            else if (D8JDBLHIEMCSD = true)
                D8JDBLHIEMCSD = true;
            else
                D8JDBLHIEMCSD = false;
            int D2EO54DF5XFIW = 251367180;
            if (D2EO54DF5XFIW > 251367191)
                D2EO54DF5XFIW = 251367193;
            else if (D2EO54DF5XFIW <= 251367137)
                D2EO54DF5XFIW++;
            else
                D2EO54DF5XFIW = (251367157 / 251367190);
            bool DFHQHNYB5CL21 = true;
            if (!DFHQHNYB5CL21)
                DFHQHNYB5CL21 = false;
            else if (DFHQHNYB5CL21 = true)
                DFHQHNYB5CL21 = true;
            else
                DFHQHNYB5CL21 = false;
            int DHLBOW4BR2CYC = 251367111;
            if (DHLBOW4BR2CYC > 251367129)
                DHLBOW4BR2CYC = 251367141;
            else if (DHLBOW4BR2CYC <= 251367173)
                DHLBOW4BR2CYC++;
            else
                DHLBOW4BR2CYC = (251367149 / 251367113);
            bool DS75A10SAQYRN = true;
            if (!DS75A10SAQYRN)
                DS75A10SAQYRN = false;
            else if (DS75A10SAQYRN = true)
                DS75A10SAQYRN = false;
            else
                DS75A10SAQYRN = false;
            int D4OD8IMY8OBJC = 251367178;
            if (D4OD8IMY8OBJC > 251367198)
                D4OD8IMY8OBJC = 251367180;
            else if (D4OD8IMY8OBJC <= 251367127)
                D4OD8IMY8OBJC++;
            else
                D4OD8IMY8OBJC = (251367150 / 251367192);
            bool D1O553B2BSZ3Y = false;
            if (!D1O553B2BSZ3Y)
                D1O553B2BSZ3Y = true;
            else if (D1O553B2BSZ3Y = true)
                D1O553B2BSZ3Y = false;
            else
                D1O553B2BSZ3Y = false;
            int DCYDB9F87JJJB = 251367167;
            if (DCYDB9F87JJJB > 251367192)
                DCYDB9F87JJJB = 251367198;
            else if (DCYDB9F87JJJB <= 251367163)
                DCYDB9F87JJJB++;
            else
                DCYDB9F87JJJB = (251367139 / 251367187);
            int D0X9HK9B7XL27 = 251367136;
            if (D0X9HK9B7XL27 > 251367179)
                D0X9HK9B7XL27 = 251367155;
            else if (D0X9HK9B7XL27 <= 251367192)
                D0X9HK9B7XL27++;
            else
                D0X9HK9B7XL27 = (251367143 / 251367118);
            int DLGG8WRL3AFF6 = 251367156;
            if (DLGG8WRL3AFF6 > 251367176)
                DLGG8WRL3AFF6 = 251367188;
            else if (DLGG8WRL3AFF6 <= 251367111)
                DLGG8WRL3AFF6++;
            else
                DLGG8WRL3AFF6 = (251367129 / 251367104);
            int DF1HHL1RMEPIK = 251367189;
            if (DF1HHL1RMEPIK > 251367150)
                DF1HHL1RMEPIK = 251367176;
            else if (DF1HHL1RMEPIK <= 251367186)
                DF1HHL1RMEPIK++;
            else
                DF1HHL1RMEPIK = (251367166 / 251367125);
            int D2HP2KCI1HBQ4 = 251367196;
            if (D2HP2KCI1HBQ4 > 251367136)
                D2HP2KCI1HBQ4 = 251367101;
            else if (D2HP2KCI1HBQ4 <= 251367131)
                D2HP2KCI1HBQ4++;
            else
                D2HP2KCI1HBQ4 = (251367191 / 251367115);
            int D9NZD94WA2S2G = 251367192;
            if (D9NZD94WA2S2G > 251367111)
                D9NZD94WA2S2G = 251367118;
            else if (D9NZD94WA2S2G <= 251367124)
                D9NZD94WA2S2G++;
            else
                D9NZD94WA2S2G = (251367183 / 251367128);
            bool D5SZ23IRR35WB = false;
            if (!D5SZ23IRR35WB)
                D5SZ23IRR35WB = true;
            else if (D5SZ23IRR35WB = true)
                D5SZ23IRR35WB = false;
            else
                D5SZ23IRR35WB = true;
            int DNQZDQOIJIPHD = 251367168;
            if (DNQZDQOIJIPHD > 251367193)
                DNQZDQOIJIPHD = 251367132;
            else if (DNQZDQOIJIPHD <= 251367191)
                DNQZDQOIJIPHD++;
            else
                DNQZDQOIJIPHD = (251367170 / 251367189);
            bool D4QSELIRSY662 = true;
            if (!D4QSELIRSY662)
                D4QSELIRSY662 = true;
            else if (D4QSELIRSY662 = true)
                D4QSELIRSY662 = true;
            else
                D4QSELIRSY662 = true;
            int DWZYP2LQJPXMP = 251367124;
            if (DWZYP2LQJPXMP > 251367161)
                DWZYP2LQJPXMP = 251367159;
            else if (DWZYP2LQJPXMP <= 251367116)
                DWZYP2LQJPXMP++;
            else
                DWZYP2LQJPXMP = (251367147 / 251367121);
            int D4MF42KAQKEA4 = 251367141;
            if (D4MF42KAQKEA4 > 251367161)
                D4MF42KAQKEA4 = 251367163;
            else if (D4MF42KAQKEA4 <= 251367182)
                D4MF42KAQKEA4++;
            else
                D4MF42KAQKEA4 = (251367198 / 251367139);
            int DI0FBFZQDPSAH = 251367114;
            if (DI0FBFZQDPSAH > 251367186)
                DI0FBFZQDPSAH = 251367148;
            else if (DI0FBFZQDPSAH <= 251367141)
                DI0FBFZQDPSAH++;
            else
                DI0FBFZQDPSAH = (251367134 / 251367133);
            int D8ZWYL7W1XRN3 = 251367153;
            if (D8ZWYL7W1XRN3 > 251367115)
                D8ZWYL7W1XRN3 = 251367196;
            else if (D8ZWYL7W1XRN3 <= 251367112)
                D8ZWYL7W1XRN3++;
            else
                D8ZWYL7W1XRN3 = (251367139 / 251367113);
            bool D9A442EFK0ADD = true;
            if (!D9A442EFK0ADD)
                D9A442EFK0ADD = true;
            else if (D9A442EFK0ADD = true)
                D9A442EFK0ADD = true;
            else
                D9A442EFK0ADD = true;
        }
    }
}