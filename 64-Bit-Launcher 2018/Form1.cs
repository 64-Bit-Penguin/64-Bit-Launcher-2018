using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace _64_Bit_Launcher_2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Panel als Mover benutzen;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public static void Move_Panel(IntPtr Handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //"Move_Panel(Handle, e);"   in   "panel1_MouseMove" schreiben "using System.Runtime.InteropServices;"
        #endregion

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TheSquareGame_MouseHover(object sender, EventArgs e)
        {
            string hex = "#C7C7C7";
            Color color = System.Drawing.ColorTranslator.FromHtml(hex);
            TheSquareGame.ForeColor = color;
            TheSquareGame_Strich.Visible = true;
        }

        private void TheSquareGame_MouseLeave(object sender, EventArgs e)
        {
            string hex = "#888888";
            Color color = System.Drawing.ColorTranslator.FromHtml(hex);
            TheSquareGame.ForeColor = color;
            TheSquareGame_Strich.Visible = false;
        }

        private void OurWebsite_LinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://google.de");
        }

        private void Facebook_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/64BitPenguin/");
        }

        private void Youtube_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.de/deralbaner");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("http://ongart.lima-city.de/black/");

            
        }

        private void Navigation_panel_MouseMove(object sender, MouseEventArgs e)
        {
            Move_Panel(Handle, e);
        }


        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebSite.Start();
        }

        private void WebSite_Tick(object sender, EventArgs e)
        {
            webBrowser1.Show();
            WebSite.Stop();
        }

        private void TheSquareGame_Click(object sender, EventArgs e)
        {
            changelog_panel.Visible = false;
        }

        private void Buy_Btn_Click(object sender, EventArgs e)
        {
            Process.Start("https://selly.gg/p/173857e3");
        }
    }
}
