namespace _64_Bit_Launcher_2018
{
    partial class MainMenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenue));
            this.Abrunden = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.TheSquareGame = new System.Windows.Forms.Label();
            this.TheSquareGame_Strich = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MinimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.CloseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.OurWebsite_LinkLbl = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Abrunden
            // 
            this.Abrunden.ElipseRadius = 8;
            this.Abrunden.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.TheSquareGame);
            this.panel1.Controls.Add(this.TheSquareGame_Strich);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.MinimizeBtn);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 43);
            this.panel1.TabIndex = 0;
            // 
            // TheSquareGame
            // 
            this.TheSquareGame.AutoSize = true;
            this.TheSquareGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheSquareGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.TheSquareGame.Location = new System.Drawing.Point(90, 8);
            this.TheSquareGame.Name = "TheSquareGame";
            this.TheSquareGame.Size = new System.Drawing.Size(187, 25);
            this.TheSquareGame.TabIndex = 3;
            this.TheSquareGame.Text = "The Square Game";
            this.TheSquareGame.MouseLeave += new System.EventHandler(this.TheSquareGame_MouseLeave);
            this.TheSquareGame.MouseHover += new System.EventHandler(this.TheSquareGame_MouseHover);
            // 
            // TheSquareGame_Strich
            // 
            this.TheSquareGame_Strich.BackColor = System.Drawing.Color.Transparent;
            this.TheSquareGame_Strich.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
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
            this.MinimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeBtn.Image")));
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
            this.panel2.Location = new System.Drawing.Point(17, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 53);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome !";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel3.Controls.Add(this.OurWebsite_LinkLbl);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(17, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 428);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 428);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OurWebsite_LinkLbl
            // 
            this.OurWebsite_LinkLbl.ActiveLinkColor = System.Drawing.Color.OrangeRed;
            this.OurWebsite_LinkLbl.AutoSize = true;
            this.OurWebsite_LinkLbl.LinkColor = System.Drawing.Color.White;
            this.OurWebsite_LinkLbl.Location = new System.Drawing.Point(121, 143);
            this.OurWebsite_LinkLbl.Name = "OurWebsite_LinkLbl";
            this.OurWebsite_LinkLbl.Size = new System.Drawing.Size(56, 13);
            this.OurWebsite_LinkLbl.TabIndex = 1;
            this.OurWebsite_LinkLbl.TabStop = true;
            this.OurWebsite_LinkLbl.Text = "Click Here";
            this.OurWebsite_LinkLbl.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel4.Location = new System.Drawing.Point(343, 139);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(865, 427);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(865, 53);
            this.label3.TabIndex = 1;
            this.label3.Text = "Changelog";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(343, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(865, 53);
            this.panel5.TabIndex = 1;
            // 
            // MainMenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1245, 712);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "64-Bit-Launcher";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse Abrunden;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton MinimizeBtn;
        private Bunifu.Framework.UI.BunifuImageButton CloseBtn;
        private System.Windows.Forms.Label TheSquareGame;
        private Bunifu.Framework.UI.BunifuSeparator TheSquareGame_Strich;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel OurWebsite_LinkLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
    }
}

