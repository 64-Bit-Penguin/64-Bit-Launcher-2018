using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _64_Bit_Launcher_2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
    }
}
