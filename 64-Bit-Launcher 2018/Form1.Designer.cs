namespace _64_Bit_Launcher_2018
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Abrunden = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Navigation_panel = new System.Windows.Forms.Panel();
            this.Game_List = new System.Windows.Forms.Label();
            this.TheSquareGame_Strich = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MinimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.CloseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OurWebsite_LinkLbl = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Youtube = new Bunifu.Framework.UI.BunifuImageButton();
            this.Facebook = new Bunifu.Framework.UI.BunifuImageButton();
            this.WebSite = new System.Windows.Forms.Timer(this.components);
            this.TheSquare_Panel = new System.Windows.Forms.Panel();
            this.Activate_Btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Serial_Textbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Buy_Btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.changelog_panel = new System.Windows.Forms.Panel();
            this.Navigation_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Youtube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Facebook)).BeginInit();
            this.TheSquare_Panel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.changelog_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Abrunden
            // 
            this.Abrunden.ElipseRadius = 8;
            this.Abrunden.TargetControl = this;
            // 
            // Navigation_panel
            // 
            this.Navigation_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(85)))), ((int)(((byte)(121)))));
            this.Navigation_panel.Controls.Add(this.Game_List);
            this.Navigation_panel.Controls.Add(this.TheSquareGame_Strich);
            this.Navigation_panel.Controls.Add(this.pictureBox1);
            this.Navigation_panel.Controls.Add(this.MinimizeBtn);
            this.Navigation_panel.Controls.Add(this.CloseBtn);
            this.Navigation_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Navigation_panel.Location = new System.Drawing.Point(0, 0);
            this.Navigation_panel.Name = "Navigation_panel";
            this.Navigation_panel.Size = new System.Drawing.Size(1245, 43);
            this.Navigation_panel.TabIndex = 0;
            this.Navigation_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Navigation_panel_MouseMove);
            // 
            // Game_List
            // 
            this.Game_List.AutoSize = true;
            this.Game_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.Game_List.Location = new System.Drawing.Point(90, 8);
            this.Game_List.Name = "Game_List";
            this.Game_List.Size = new System.Drawing.Size(187, 25);
            this.Game_List.TabIndex = 3;
            this.Game_List.Text = "The Square Game";
            this.Game_List.Click += new System.EventHandler(this.TheSquareGame_Click);
            this.Game_List.MouseLeave += new System.EventHandler(this.TheSquareGame_MouseLeave);
            this.Game_List.MouseHover += new System.EventHandler(this.TheSquareGame_MouseHover);
            // 
            // TheSquareGame_Strich
            // 
            this.TheSquareGame_Strich.BackColor = System.Drawing.Color.Transparent;
            this.TheSquareGame_Strich.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.TheSquareGame_Strich.LineThickness = 3;
            this.TheSquareGame_Strich.Location = new System.Drawing.Point(93, 30);
            this.TheSquareGame_Strich.Name = "TheSquareGame_Strich";
            this.TheSquareGame_Strich.Size = new System.Drawing.Size(182, 10);
            this.TheSquareGame_Strich.TabIndex = 1;
            this.TheSquareGame_Strich.Transparency = 255;
            this.TheSquareGame_Strich.Vertical = false;
            this.TheSquareGame_Strich.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_64_Bit_Launcher_2018.Properties.Resources.InProgrammIcon;
            this.pictureBox1.Location = new System.Drawing.Point(6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.Image = global::_64_Bit_Launcher_2018.Properties.Resources.minimize;
            this.MinimizeBtn.ImageActive = null;
            this.MinimizeBtn.Location = new System.Drawing.Point(1187, 5);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(22, 23);
            this.MinimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeBtn.TabIndex = 1;
            this.MinimizeBtn.TabStop = false;
            this.MinimizeBtn.Zoom = 10;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.Image = global::_64_Bit_Launcher_2018.Properties.Resources.close;
            this.CloseBtn.ImageActive = null;
            this.CloseBtn.Location = new System.Drawing.Point(1215, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(27, 25);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Zoom = 10;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(11, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 53);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel3.Controls.Add(this.OurWebsite_LinkLbl);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(11, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 428);
            this.panel3.TabIndex = 1;
            // 
            // OurWebsite_LinkLbl
            // 
            this.OurWebsite_LinkLbl.ActiveLinkColor = System.Drawing.Color.OrangeRed;
            this.OurWebsite_LinkLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.OurWebsite_LinkLbl.LinkColor = System.Drawing.Color.White;
            this.OurWebsite_LinkLbl.Location = new System.Drawing.Point(0, 146);
            this.OurWebsite_LinkLbl.Name = "OurWebsite_LinkLbl";
            this.OurWebsite_LinkLbl.Size = new System.Drawing.Size(300, 17);
            this.OurWebsite_LinkLbl.TabIndex = 1;
            this.OurWebsite_LinkLbl.TabStop = true;
            this.OurWebsite_LinkLbl.Text = "Click Here";
            this.OurWebsite_LinkLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.OurWebsite_LinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OurWebsite_LinkLbl_LinkClicked);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 146);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(336, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(882, 53);
            this.panel4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(882, 53);
            this.label3.TabIndex = 1;
            this.label3.Text = "Changelog";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel5.Controls.Add(this.webBrowser1);
            this.panel5.Location = new System.Drawing.Point(336, 86);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(882, 427);
            this.panel5.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(13, 13);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(852, 402);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Youtube
            // 
            this.Youtube.BackColor = System.Drawing.Color.Transparent;
            this.Youtube.Image = global::_64_Bit_Launcher_2018.Properties.Resources.youtube;
            this.Youtube.ImageActive = null;
            this.Youtube.Location = new System.Drawing.Point(61, 655);
            this.Youtube.Name = "Youtube";
            this.Youtube.Size = new System.Drawing.Size(56, 47);
            this.Youtube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Youtube.TabIndex = 3;
            this.Youtube.TabStop = false;
            this.Youtube.Zoom = 10;
            this.Youtube.Click += new System.EventHandler(this.Youtube_Click);
            // 
            // Facebook
            // 
            this.Facebook.BackColor = System.Drawing.Color.Transparent;
            this.Facebook.Image = ((System.Drawing.Image)(resources.GetObject("Facebook.Image")));
            this.Facebook.ImageActive = null;
            this.Facebook.Location = new System.Drawing.Point(12, 657);
            this.Facebook.Name = "Facebook";
            this.Facebook.Size = new System.Drawing.Size(45, 43);
            this.Facebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Facebook.TabIndex = 0;
            this.Facebook.TabStop = false;
            this.Facebook.Zoom = 10;
            this.Facebook.Click += new System.EventHandler(this.Facebook_Click);
            // 
            // WebSite
            // 
            this.WebSite.Interval = 3000;
            this.WebSite.Tick += new System.EventHandler(this.WebSite_Tick);
            // 
            // TheSquare_Panel
            // 
            this.TheSquare_Panel.Controls.Add(this.Activate_Btn);
            this.TheSquare_Panel.Controls.Add(this.Serial_Textbox);
            this.TheSquare_Panel.Controls.Add(this.panel7);
            this.TheSquare_Panel.Controls.Add(this.Buy_Btn);
            this.TheSquare_Panel.Controls.Add(this.panel6);
            this.TheSquare_Panel.Controls.Add(this.panel1);
            this.TheSquare_Panel.Location = new System.Drawing.Point(5, 52);
            this.TheSquare_Panel.Name = "TheSquare_Panel";
            this.TheSquare_Panel.Size = new System.Drawing.Size(1236, 592);
            this.TheSquare_Panel.TabIndex = 4;
            // 
            // Activate_Btn
            // 
            this.Activate_Btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(85)))), ((int)(((byte)(121)))));
            this.Activate_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(85)))), ((int)(((byte)(121)))));
            this.Activate_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Activate_Btn.BorderRadius = 0;
            this.Activate_Btn.ButtonText = "Activate";
            this.Activate_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Activate_Btn.DisabledColor = System.Drawing.Color.Gray;
            this.Activate_Btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Activate_Btn.Iconimage = null;
            this.Activate_Btn.Iconimage_right = null;
            this.Activate_Btn.Iconimage_right_Selected = null;
            this.Activate_Btn.Iconimage_Selected = null;
            this.Activate_Btn.IconMarginLeft = 0;
            this.Activate_Btn.IconMarginRight = 0;
            this.Activate_Btn.IconRightVisible = true;
            this.Activate_Btn.IconRightZoom = 0D;
            this.Activate_Btn.IconVisible = true;
            this.Activate_Btn.IconZoom = 90D;
            this.Activate_Btn.IsTab = false;
            this.Activate_Btn.Location = new System.Drawing.Point(713, 517);
            this.Activate_Btn.Name = "Activate_Btn";
            this.Activate_Btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(85)))), ((int)(((byte)(121)))));
            this.Activate_Btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(124)))), ((int)(((byte)(180)))));
            this.Activate_Btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Activate_Btn.selected = false;
            this.Activate_Btn.Size = new System.Drawing.Size(226, 49);
            this.Activate_Btn.TabIndex = 5;
            this.Activate_Btn.Text = "Activate";
            this.Activate_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Activate_Btn.Textcolor = System.Drawing.Color.White;
            this.Activate_Btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Serial_Textbox
            // 
            this.Serial_Textbox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.Serial_Textbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Serial_Textbox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Serial_Textbox.BorderThickness = 3;
            this.Serial_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Serial_Textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Serial_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Serial_Textbox.isPassword = false;
            this.Serial_Textbox.Location = new System.Drawing.Point(313, 517);
            this.Serial_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Serial_Textbox.Name = "Serial_Textbox";
            this.Serial_Textbox.Size = new System.Drawing.Size(370, 49);
            this.Serial_Textbox.TabIndex = 4;
            this.Serial_Textbox.Text = "Serial Key";
            this.Serial_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Serial_Textbox.Enter += new System.EventHandler(this.Serial_Textbox_Enter);
            this.Serial_Textbox.Leave += new System.EventHandler(this.Serial_Textbox_Leave);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel7.Location = new System.Drawing.Point(298, 30);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(905, 421);
            this.panel7.TabIndex = 3;
            // 
            // Buy_Btn
            // 
            this.Buy_Btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(85)))), ((int)(((byte)(121)))));
            this.Buy_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(85)))), ((int)(((byte)(121)))));
            this.Buy_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Buy_Btn.BorderRadius = 0;
            this.Buy_Btn.ButtonText = "Buy ";
            this.Buy_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buy_Btn.DisabledColor = System.Drawing.Color.Gray;
            this.Buy_Btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Buy_Btn.Iconimage = null;
            this.Buy_Btn.Iconimage_right = null;
            this.Buy_Btn.Iconimage_right_Selected = null;
            this.Buy_Btn.Iconimage_Selected = null;
            this.Buy_Btn.IconMarginLeft = 0;
            this.Buy_Btn.IconMarginRight = 0;
            this.Buy_Btn.IconRightVisible = true;
            this.Buy_Btn.IconRightZoom = 0D;
            this.Buy_Btn.IconVisible = true;
            this.Buy_Btn.IconZoom = 90D;
            this.Buy_Btn.IsTab = false;
            this.Buy_Btn.Location = new System.Drawing.Point(36, 517);
            this.Buy_Btn.Name = "Buy_Btn";
            this.Buy_Btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(85)))), ((int)(((byte)(121)))));
            this.Buy_Btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(124)))), ((int)(((byte)(180)))));
            this.Buy_Btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Buy_Btn.selected = false;
            this.Buy_Btn.Size = new System.Drawing.Size(226, 49);
            this.Buy_Btn.TabIndex = 2;
            this.Buy_Btn.Text = "Buy ";
            this.Buy_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Buy_Btn.Textcolor = System.Drawing.Color.White;
            this.Buy_Btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buy_Btn.Click += new System.EventHandler(this.Buy_Btn_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(36, 458);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(226, 42);
            this.panel6.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 42);
            this.label4.TabIndex = 0;
            this.label4.Text = "2.99€";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(36, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 425);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Here will be Text";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "The Square Game Unity Edition\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // changelog_panel
            // 
            this.changelog_panel.Controls.Add(this.panel5);
            this.changelog_panel.Controls.Add(this.panel4);
            this.changelog_panel.Controls.Add(this.panel3);
            this.changelog_panel.Controls.Add(this.panel2);
            this.changelog_panel.Location = new System.Drawing.Point(5, 650);
            this.changelog_panel.Name = "changelog_panel";
            this.changelog_panel.Size = new System.Drawing.Size(1235, 590);
            this.changelog_panel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1245, 712);
            this.Controls.Add(this.changelog_panel);
            this.Controls.Add(this.TheSquare_Panel);
            this.Controls.Add(this.Youtube);
            this.Controls.Add(this.Facebook);
            this.Controls.Add(this.Navigation_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "64-Bit-Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Navigation_panel.ResumeLayout(false);
            this.Navigation_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Youtube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Facebook)).EndInit();
            this.TheSquare_Panel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.changelog_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse Abrunden;
        private System.Windows.Forms.Panel Navigation_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton MinimizeBtn;
        private Bunifu.Framework.UI.BunifuImageButton CloseBtn;
        private System.Windows.Forms.Label Game_List;
        private Bunifu.Framework.UI.BunifuSeparator TheSquareGame_Strich;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel OurWebsite_LinkLbl;
        private Bunifu.Framework.UI.BunifuImageButton Facebook;
        private Bunifu.Framework.UI.BunifuImageButton Youtube;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Timer WebSite;
        private System.Windows.Forms.Panel TheSquare_Panel;
        private System.Windows.Forms.Panel changelog_panel;
        private Bunifu.Framework.UI.BunifuFlatButton Buy_Btn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuFlatButton Activate_Btn;
        private Bunifu.Framework.UI.BunifuMetroTextbox Serial_Textbox;
    }
}

