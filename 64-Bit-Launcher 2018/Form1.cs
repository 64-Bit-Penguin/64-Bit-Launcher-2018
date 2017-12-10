﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (WebSite.IsBusy == false)
            {
                WebSite.RunWorkerAsync();
            }
        }

        delegate void Website();

        private void ShowWebBrowser()
        {
            webBrowser1.Show();
        }


        private void WebSite_DoWork(object sender, DoWorkEventArgs e)
        {
            Website web = new Website(ShowWebBrowser);

            System.Threading.Thread.Sleep(1000);

            this.Invoke(web);
        }
    }
}
