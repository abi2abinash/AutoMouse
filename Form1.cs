using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.UserActivityMonitor;
using System.Runtime.InteropServices;
using System.Threading;

namespace MouseClicker
{
    public partial class FrmMouseClicker : Form
    {
        Thread objThread;
        ThreadStart ts;
        int txtValueX;
        int txtValueY;
        string seconds;
        int minutes;
        int hours;
        int repeatTimes = 0;
        int slctedCmbMouseBtn;
        int slctedCmbMouseClick;
        public FrmMouseClicker()
        {
            InitializeComponent();
            btnStart.Hide();
            btnStop.Hide();
            cmbMouseButton.SelectedIndex = 0;
            cmbMouseAction.SelectedIndex = 0;
            rBStoptillcommand.Checked = true;
            rbClickOnFixedPont.Checked = true;
            lblMouseClicked.Hide();
            lblMouseClickedCount.Hide();
        }

        private void FrmMouseClicker_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                txtX.Text = Cursor.Position.X.ToString();
                txtY.Text = Cursor.Position.Y.ToString();
            }
            catch { }
        }

        private void FrmMouseClicker_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            try
            {
                Point pt = new Point();
                GetCursorPos(ref pt);
                txtX.Text = pt.X.ToString();
                txtY.Text = pt.Y.ToString();
            }
            catch { }
        }
        private void FrmMouseClicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                timer1.Stop();
                Point pt = new Point();
                if (txtX.Text != string.Empty && txtY.Text != string.Empty)
                {
                    pt.X = int.Parse(txtX.Text);
                    pt.Y = int.Parse(txtY.Text);
                }
                btnStart.Show();
                objThread.Abort();
                btnStop.Hide();
                btnStartToCapture.Enabled = true;
            }
            catch { }
        }
        public void CursorPosition()
        {
            try
            {
                seconds = txtSeconds.Text + "000";
                minutes = int.Parse(txtMinutes.Text) * 60000;
                hours = int.Parse(txtHours.Text) * 3600000;
                while (true)
                {
                    if (rbStoptillRepeat.Checked)
                    {
                        if (repeatTimes == int.Parse(txtRepeatTimes.Text))
                        {
                            repeatTimes = 0;
                            Stop();
                            break;
                        }
                    }
                    if (txtX.Text != string.Empty && txtY.Text != string.Empty)
                    {
                        txtValueX = int.Parse(txtX.Text);
                        txtValueY = int.Parse(txtY.Text);
                        Thread.Sleep(int.Parse(seconds) + minutes + hours);
                        Cursor.Position = new Point(txtValueX, txtValueY);
                    }
                    else
                    {
                        Thread.Sleep(int.Parse(seconds) + minutes + hours);
                        Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y);
                    }
                    DoMouseClick();
                }
            }
            catch { }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public void DoMouseClick()
        {
            repeatTimes++;
            if (lblMouseClickedCount.InvokeRequired)
            {
                lblMouseClickedCount.Invoke(new MethodInvoker(delegate
                {
                    lblMouseClicked.Show();
                    lblMouseClickedCount.Show();
                    lblMouseClickedCount.Text = repeatTimes.ToString();
                }));
            }
            if (slctedCmbMouseBtn == 0 && slctedCmbMouseClick == 0)
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, txtValueX, txtValueY, 0, 0);
            }
            else if (slctedCmbMouseBtn == 0 && slctedCmbMouseClick == 1)
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, txtValueX, txtValueY, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, txtValueX, txtValueY, 0, 0);
            }
            else if (slctedCmbMouseBtn == 1 && slctedCmbMouseClick == 0)
            {
                mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, txtValueX, txtValueY, 0, 0);
            }
            else if (slctedCmbMouseBtn == 1 && slctedCmbMouseClick == 1)
            {
                mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, txtValueX, txtValueY, 0, 0);
                mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, txtValueX, txtValueY, 0, 0);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }
        public void Stop()
        {
            try
            {
                repeatTimes = 0;
                if (btnStop.InvokeRequired || btnStop.InvokeRequired)
                {
                    btnStop.Invoke(new MethodInvoker(delegate
                    {
                        btnStop.Hide(); btnStart.Show(); btnStartToCapture.Enabled = true;
                        timer1.Stop();
                        objThread.Abort();
                    }));
                }
                btnStop.Hide();
                btnStart.Show();
                btnStartToCapture.Enabled = true;
                timer1.Stop();
                objThread.Abort();
            }
            catch { }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Stop();
            this.Close();
        }

        private void btnStartToCapture_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Start();
                btnStart.Hide();
            }
            catch { }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                lblMouseClickedCount.Text = "0";
                ts = new ThreadStart(CursorPosition);
                objThread = new Thread(ts);
                objThread.Start();
                btnStart.Hide();
                btnStop.Show();
                btnStartToCapture.Enabled = false;
                slctedCmbMouseBtn = cmbMouseButton.SelectedIndex;
                slctedCmbMouseClick = cmbMouseAction.SelectedIndex;
            }
            catch { }
        }

        private void rbClickWhereMouse_Click(object sender, EventArgs e)
        {
            try
            {
                txtX.Text = "";
                txtY.Text = "";
                groupBoxSpecifyClickPoint.Hide();
                btnStart.Show();
                Stop();
            }
            catch { }
        }

        private void rbClickOnFixedPont_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxSpecifyClickPoint.Show();
                Stop();
                btnStart.Hide();
            }
            catch { }
        }
    }
}
