using System;
using System.Windows.Forms;

namespace TCNO
{
    internal static class TCNO
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Control.CheckForIllegalCrossThreadCalls = false;
#if NETCOREAPP3_1 || NET5_0 || NET6_0
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
#endif
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}