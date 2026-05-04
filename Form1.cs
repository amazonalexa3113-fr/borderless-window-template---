// the only file that literally controls the drag + resize function fr fr

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace draggable_borderless_window
{
    public partial class Form1 : Form
    {
        // import win32 APIs first thing first

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HTCAPTION = 0x2;

        // --- resize stuff (the real sauce) ---
        const int WM_NCHITTEST = 0x84;

        const int HTLEFT = 10;
        const int HTRIGHT = 11;
        const int HTTOP = 12;
        const int HTTOPLEFT = 13;
        const int HTTOPRIGHT = 14;
        const int HTBOTTOM = 15;
        const int HTBOTTOMLEFT = 16;
        const int HTBOTTOMRIGHT = 17;

        const int resizeArea = 10; // how thicc the resize border is

        public Form1()
        {
            InitializeComponent();

            // borderless
            if (this.FormBorderStyle != FormBorderStyle.None)
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }

            // some cool customizations that i made for fun :D
            this.formLabel.Text = this.Text;

            // opacity changer ayo
            if (this.trackBar1.Value != 100)
            {
                this.trackBar1.Maximum = 100;
            }
            if (this.trackBar1.Visible)
            {
                this.trackBar1.Visible = false; // should be invisible in the first place
            }

            // now put anything u want here for now on :D

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void dragPanel_DoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                maxBtn_Click(sender, EventArgs.Empty);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            // toggle maximize like a normal window
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            // minimize the window
            this.WindowState = FormWindowState.Minimized;
        }

        // --- this is where the magic happens fr ---
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && this.WindowState != FormWindowState.Maximized)
            {
                Point cursor = this.PointToClient(Cursor.Position);

                bool left = cursor.X <= resizeArea;
                bool right = cursor.X >= this.ClientSize.Width - resizeArea;
                bool top = cursor.Y <= resizeArea;
                bool bottom = cursor.Y >= this.ClientSize.Height - resizeArea;

                // corners first (important or it feels weird af)
                if (left && top)
                    m.Result = (IntPtr)HTTOPLEFT;
                else if (right && top)
                    m.Result = (IntPtr)HTTOPRIGHT;
                else if (left && bottom)
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (right && bottom)
                    m.Result = (IntPtr)HTBOTTOMRIGHT;

                // edges
                else if (left)
                    m.Result = (IntPtr)HTLEFT;
                else if (right)
                    m.Result = (IntPtr)HTRIGHT;
                else if (top)
                    m.Result = (IntPtr)HTTOP;
                else if (bottom)
                    m.Result = (IntPtr)HTBOTTOM;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.Opacity = Math.Max(0.1, this.trackBar1.Value / 100.0);
        }

        private void viewOpSlider_Click(object sender, EventArgs e)
        {
            if (!this.trackBar1.Visible)
            {
                this.trackBar1.Visible = true;
            }
            else
            {
                this.trackBar1.Visible = false;
            }
        }

        // i mean we had Program.cs so who rlly needs [STAThread] and a Main() void
    }
}