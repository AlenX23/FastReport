using FastReport.Utils;
using FastReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastR
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Config.DesignerSettings.ShowInTaskbar = true;
            Config.SplashScreenEnabled = true;

            using (Report report = new Report())
            {
                report.Design();
            }
        }
    }
}
