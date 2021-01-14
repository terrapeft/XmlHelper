using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace XmlHelper
{
    public partial class Main : Form
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

        private int secondsCounter = 120*60;
        private string scrollKey = "{DOWN}";

        private Timer timer = new Timer();
        private Timer upTimeTimer = new Timer();

        private TimeSpan upTimeSpan = TimeSpan.Zero;
        private DateTime lastPeriodStartTime = DateTime.Now;

        private Process _shadowMateProcess;

        public Main()
        {
            InitializeComponent();

            StartShadowMate();

            timer.Interval = (1 * 1000);
            timer.Tick += Timer_Tick;

            upTimeTimer.Interval = 1000;
            upTimeTimer.Tick += (s, a) =>
            {
                UpdateUpTime();
            };

            this.ActiveControl = scrollerTextBox;
            scrollerTextBox.Select(0, 0);
        }

        private void StartShadowMate()
        {
            _shadowMateProcess = Process.Start("XmlHelperShadowMate.exe");
        }

        private void Start()
        {
            lastPeriodStartTime = DateTime.Now;

            UpdateUpTime();

            startTimeTextBox.Text = lastPeriodStartTime.ToString("hh\\:mm\\:ss");
            countDownTextBox.Text = TimeSpan.FromSeconds(secondsCounter).ToString();

            Text = "In Progress";

            //KickMouse();
            SetKeepScreenOn(true);
            TypeSomething();

            timer.Start();
            upTimeTimer.Start();
        }

        private void Stop()
        {
            timer.Stop();
            upTimeTimer.Stop();

            secondsCounter = 120 * 60;
            Text = "On Pause";
            SetKeepScreenOn(false);
            UpdateUpTime();
        }

        private void UpdateUpTime()
        {
            upTimeSpan = upTimeSpan.Add(DateTime.Now - lastPeriodStartTime);
            lastPeriodStartTime = DateTime.Now;
            upTimeTextBox.Text = upTimeSpan.ToString("hh\\:mm\\:ss");
        }

        void SetKeepScreenOn(bool isKeepScreenOn)
        {
            if (isKeepScreenOn == true)
            {
                //You can combine several flags and specify multiple behaviors with a single call
                SetThreadExecutionState(
                    EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_SYSTEM_REQUIRED |
                    EXECUTION_STATE.ES_DISPLAY_REQUIRED /*| EXECUTION_STATE.ES_AWAYMODE_REQUIRED*/);
            }
            else
            {
                //To reset or allow those event again you have to call this API with only ES_CONTINUOUS
                SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
            }
        }

        private void KickMouse()
        {
            var p = new WinX.POINT();
            p.x = new Random(10).Next(10, 25);
            p.y = new Random(10).Next(10, 25);

            WinX.ClientToScreen(this.Handle, ref p);
            WinX.SetCursorPos(p.x, p.y);
        }

        private void TypeSomething()
        {
            var linesCount = scrollerTextBox.GetLineFromCharIndex(int.MaxValue) + 1; // Displayed lines with word wrap differs from number of source lines.
            var currentLine = scrollerTextBox.GetLineFromCharIndex(scrollerTextBox.SelectionStart) + 1;

            if (currentLine == 1) scrollKey = "{DOWN}";
            if (currentLine == linesCount) scrollKey = "{UP}";

            SendKeys.Send(scrollKey);
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
            _shadowMateProcess.CloseMainWindow();
            _shadowMateProcess.Close();
        }


        private void Form1_Deactivate(object sender, EventArgs e)
        {
            Stop();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (secondsCounter-- > 0)
            {
                Start();
            }
            else
            {
                Stop();
            }
        }
    }
}
