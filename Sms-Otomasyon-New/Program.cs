using System;
using System.Windows.Forms;

namespace Sms_Otomasyon_New
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new bos());


        }
    }
}
