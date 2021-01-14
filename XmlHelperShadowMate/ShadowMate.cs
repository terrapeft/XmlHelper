using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace XmlHelperShadowMate
{
    public partial class ShadowMate : Form
    {
        [DllImport("user32")]
        private static extern bool SetForegroundWindow(IntPtr hwnd);

        private Timer _timer;


        public ShadowMate()
        {
            InitializeComponent();

            _timer = new Timer();
            _timer.Interval = (2 * 1000);
            _timer.Tick += (sender, args) =>
            {
                Hide();

                var proc = Process.GetProcessesByName("XmlHelper").FirstOrDefault();
                if (proc != null && proc.MainWindowHandle != IntPtr.Zero)
                {
                    SetForegroundWindow(proc.MainWindowHandle);
                }
                else
                {
                    Close();
                }
            };

            _timer.Start();
        }
    }
}
