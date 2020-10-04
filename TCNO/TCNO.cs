using System;
using System.Windows.Forms;

namespace TCNO
{
    static class TCNO
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Control.CheckForIllegalCrossThreadCalls = false;
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}