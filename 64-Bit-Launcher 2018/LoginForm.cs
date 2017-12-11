using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using platzhalter;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using HazardEdit;
using connection;
using System.Diagnostics;

namespace _64_Bit_Launcher_2018
{
    public partial class LoginForm : Form
    {
        public string user;
        public string pass;
        public string rpass;
        public string email;
        public LoginForm()
        {
            connection.MeinSQL.Connect();
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

        #region platzhalter
        private void Username_Login_Enter(object sender, EventArgs e)
        {
            platzhalter_enter.enter(Username_Login);
        }

        private void Username_Login_Leave(object sender, EventArgs e)
        {
            platzhalter_enter.username_leave(Username_Login);
        }

        private void Password_Login_Enter(object sender, EventArgs e)
        {
            platzhalter_enter.enter(Password_Login);
        }

        private void Password_Login_Leave(object sender, EventArgs e)
        {
            platzhalter_enter.password_leave(Password_Login);
        }

        private void Username_Regi_Enter(object sender, EventArgs e)
        {
            platzhalter_enter.enter(Username_Regi);
        }

        private void Username_Regi_Leave(object sender, EventArgs e)
        {
            platzhalter_enter.username_regileave(Username_Regi);
        }

        private void Password_Regi_Enter(object sender, EventArgs e)
        {
            platzhalter_enter.enter(Password_Regi);
        }

        private void Password_Regi_Leave(object sender, EventArgs e)
        {
            platzhalter_enter.password_regileave(Password_Regi);
        }

        private void Repassword_Regi_Enter(object sender, EventArgs e)
        {
            platzhalter_enter.enter(Repassword_Regi);
        }

        private void Repassword_Regi_Leave(object sender, EventArgs e)
        {
            platzhalter_enter.repassword_regileave(Repassword_Regi);
        }

        private void Email_Regi_Enter(object sender, EventArgs e)
        {
            platzhalter_enter.enter(Email_Regi);
        }

        private void Email_Regi_Leave(object sender, EventArgs e)
        {
            platzhalter_enter.email_regileave(Email_Regi);
        }

        #endregion

        private void Navigation_panel_MouseMove(object sender, MouseEventArgs e)
        {
            Move_Panel(Handle, e);
        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {


            Form1 Client = new Form1();
            var Login = this;
            connection.MeinSQL.anmelden(Username_Login, Password_Login, user, Client, Login);
            connection.MeinSQL.IsLogin(user, pass);
        
            
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            connection.MeinSQL.register(Username_Regi, Password_Regi, Repassword_Regi, Email_Regi, user, pass, rpass, email);
        }
    }
}
