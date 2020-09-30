using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MonitorRotationer
{
    public class MonitorOnOff
    {
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MONITORPOWER = 0xF170;
        public const int MONITOR_ON = -1;
        public const int MONITOR_OFF = 2;
        public const int MONITOR_STANBY = 1;

        [DllImport("user32.dll")]
        public static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);
    }
}
