
namespace TheLotteryProject
{
    partial class Game1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game1));
            this.BtnTryChance = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.LblId = new System.Windows.Forms.Label();
            this.LLblSignIn = new System.Windows.Forms.LinkLabel();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.PctWin = new System.Windows.Forms.PictureBox();
            this.PctLose = new System.Windows.Forms.PictureBox();
            this.LblNum1 = new System.Windows.Forms.Label();
            this.LblNum2 = new System.Windows.Forms.Label();
            this.LblNum3 = new System.Windows.Forms.Label();
            this.LblNum4 = new System.Windows.Forms.Label();
            this.MskNum1 = new System.Windows.Forms.MaskedTextBox();
            this.MskNum2 = new System.Windows.Forms.MaskedTextBox();
            this.MskNum3 = new System.Windows.Forms.MaskedTextBox();
            this.MskNum4 = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ınformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theLotteryMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTurnToMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctLose)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnTryChance
            // 
            this.BtnTryChance.Enabled = false;
            this.BtnTryChance.Location = new System.Drawing.Point(31, 118);
            this.BtnTryChance.Name = "BtnTryChance";
            this.BtnTryChance.Size = new System.Drawing.Size(327, 34);
            this.BtnTryChance.TabIndex = 10;
            this.BtnTryChance.Text = "Try Your Chance!";
            this.BtnTryChance.UseVisualStyleBackColor = true;
            this.BtnTryChance.Click += new System.EventHandler(this.BtnTryChance_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnLogOut);
            this.groupBox1.Controls.Add(this.LblId);
            this.groupBox1.Controls.Add(this.LLblSignIn);
            this.groupBox1.Controls.Add(this.BtnLogin);
            this.groupBox1.Controls.Add(this.TxtPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtUsername);
            this.groupBox1.Location = new System.Drawing.Point(396, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 222);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login - Sign In";
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Location = new System.Drawing.Point(112, 172);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(173, 32);
            this.BtnLogOut.TabIndex = 4;
            this.BtnLogOut.Text = "Logout";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(15, 184);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(0, 22);
            this.LblId.TabIndex = 10;
            // 
            // LLblSignIn
            // 
            this.LLblSignIn.AutoSize = true;
            this.LLblSignIn.Location = new System.Drawing.Point(9, 139);
            this.LLblSignIn.Name = "LLblSignIn";
            this.LLblSignIn.Size = new System.Drawing.Size(65, 22);
            this.LLblSignIn.TabIndex = 5;
            this.LLblSignIn.TabStop = true;
            this.LLblSignIn.Text = "Sign In";
            this.LLblSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLblSignIn_LinkClicked);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(112, 134);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(173, 32);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(112, 93);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(173, 30);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username:";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(112, 55);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(173, 30);
            this.TxtUsername.TabIndex = 1;
            // 
            // PctWin
            // 
            this.PctWin.Image = ((System.Drawing.Image)(resources.GetObject("PctWin.Image")));
            this.PctWin.Location = new System.Drawing.Point(31, 158);
            this.PctWin.Name = "PctWin";
            this.PctWin.Size = new System.Drawing.Size(327, 98);
            this.PctWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctWin.TabIndex = 6;
            this.PctWin.TabStop = false;
            this.PctWin.Visible = false;
            // 
            // PctLose
            // 
            this.PctLose.Image = ((System.Drawing.Image)(resources.GetObject("PctLose.Image")));
            this.PctLose.Location = new System.Drawing.Point(31, 158);
            this.PctLose.Name = "PctLose";
            this.PctLose.Size = new System.Drawing.Size(327, 98);
            this.PctLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctLose.TabIndex = 7;
            this.PctLose.TabStop = false;
            this.PctLose.Visible = false;
            // 
            // LblNum1
            // 
            this.LblNum1.AutoSize = true;
            this.LblNum1.Location = new System.Drawing.Point(51, 34);
            this.LblNum1.Name = "LblNum1";
            this.LblNum1.Size = new System.Drawing.Size(16, 22);
            this.LblNum1.TabIndex = 11;
            this.LblNum1.Text = "-";
            // 
            // LblNum2
            // 
            this.LblNum2.AutoSize = true;
            this.LblNum2.Location = new System.Drawing.Point(142, 34);
            this.LblNum2.Name = "LblNum2";
            this.LblNum2.Size = new System.Drawing.Size(16, 22);
            this.LblNum2.TabIndex = 12;
            this.LblNum2.Text = "-";
            // 
            // LblNum3
            // 
            this.LblNum3.AutoSize = true;
            this.LblNum3.Location = new System.Drawing.Point(230, 34);
            this.LblNum3.Name = "LblNum3";
            this.LblNum3.Size = new System.Drawing.Size(16, 22);
            this.LblNum3.TabIndex = 13;
            this.LblNum3.Text = "-";
            // 
            // LblNum4
            // 
            this.LblNum4.AutoSize = true;
            this.LblNum4.Location = new System.Drawing.Point(320, 34);
            this.LblNum4.Name = "LblNum4";
            this.LblNum4.Size = new System.Drawing.Size(16, 22);
            this.LblNum4.TabIndex = 14;
            this.LblNum4.Text = "-";
            // 
            // MskNum1
            // 
            this.MskNum1.Enabled = false;
            this.MskNum1.Location = new System.Drawing.Point(31, 69);
            this.MskNum1.Mask = "0";
            this.MskNum1.Name = "MskNum1";
            this.MskNum1.Size = new System.Drawing.Size(57, 30);
            this.MskNum1.TabIndex = 15;
            this.MskNum1.ValidatingType = typeof(int);
            // 
            // MskNum2
            // 
            this.MskNum2.Enabled = false;
            this.MskNum2.Location = new System.Drawing.Point(123, 69);
            this.MskNum2.Mask = "0";
            this.MskNum2.Name = "MskNum2";
            this.MskNum2.Size = new System.Drawing.Size(57, 30);
            this.MskNum2.TabIndex = 16;
            this.MskNum2.ValidatingType = typeof(int);
            // 
            // MskNum3
            // 
            this.MskNum3.Enabled = false;
            this.MskNum3.Location = new System.Drawing.Point(215, 69);
            this.MskNum3.Mask = "0";
            this.MskNum3.Name = "MskNum3";
            this.MskNum3.Size = new System.Drawing.Size(57, 30);
            this.MskNum3.TabIndex = 17;
            this.MskNum3.ValidatingType = typeof(int);
            // 
            // MskNum4
            // 
            this.MskNum4.Enabled = false;
            this.MskNum4.Location = new System.Drawing.Point(301, 69);
            this.MskNum4.Mask = "0";
            this.MskNum4.Name = "MskNum4";
            this.MskNum4.Size = new System.Drawing.Size(57, 30);
            this.MskNum4.TabIndex = 18;
            this.MskNum4.ValidatingType = typeof(int);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theLotteryMenuToolStripMenuItem,
            this.ınformationToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.producerInformationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ınformationToolStripMenuItem
            // 
            this.ınformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameInformationToolStripMenuItem});
            this.ınformationToolStripMenuItem.Name = "ınformationToolStripMenuItem";
            this.ınformationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.ınformationToolStripMenuItem.Text = "Information";
            // 
            // gameInformationToolStripMenuItem
            // 
            this.gameInformationToolStripMenuItem.Name = "gameInformationToolStripMenuItem";
            this.gameInformationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gameInformationToolStripMenuItem.Text = "Game Information";
            this.gameInformationToolStripMenuItem.Click += new System.EventHandler(this.gameInformationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // theLotteryMenuToolStripMenuItem
            // 
            this.theLotteryMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitTurnToMenuToolStripMenuItem});
            this.theLotteryMenuToolStripMenuItem.Name = "theLotteryMenuToolStripMenuItem";
            this.theLotteryMenuToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.theLotteryMenuToolStripMenuItem.Text = "The Lottery Menu";
            // 
            // exitTurnToMenuToolStripMenuItem
            // 
            this.exitTurnToMenuToolStripMenuItem.Name = "exitTurnToMenuToolStripMenuItem";
            this.exitTurnToMenuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitTurnToMenuToolStripMenuItem.Text = "Exit & Turn to Menu";
            this.exitTurnToMenuToolStripMenuItem.Click += new System.EventHandler(this.exitTurnToMenuToolStripMenuItem_Click);
            // 
            // producerInformationToolStripMenuItem
            // 
            this.producerInformationToolStripMenuItem.Name = "producerInformationToolStripMenuItem";
            this.producerInformationToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.producerInformationToolStripMenuItem.Text = "Producer Information";
            this.producerInformationToolStripMenuItem.Click += new System.EventHandler(this.producerInformationToolStripMenuItem_Click);
            // 
            // Game1
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(731, 269);
            this.Controls.Add(this.MskNum4);
            this.Controls.Add(this.MskNum3);
            this.Controls.Add(this.MskNum2);
            this.Controls.Add(this.MskNum1);
            this.Controls.Add(this.LblNum4);
            this.Controls.Add(this.LblNum3);
            this.Controls.Add(this.LblNum2);
            this.Controls.Add(this.LblNum1);
            this.Controls.Add(this.PctLose);
            this.Controls.Add(this.PctWin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnTryChance);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Game1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game1";
            this.Load += new System.EventHandler(this.Game1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctLose)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnTryChance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.LinkLabel LLblSignIn;
        private System.Windows.Forms.PictureBox PctWin;
        private System.Windows.Forms.PictureBox PctLose;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Label LblNum1;
        private System.Windows.Forms.Label LblNum2;
        private System.Windows.Forms.Label LblNum3;
        private System.Windows.Forms.Label LblNum4;
        private System.Windows.Forms.MaskedTextBox MskNum1;
        private System.Windows.Forms.MaskedTextBox MskNum2;
        private System.Windows.Forms.MaskedTextBox MskNum3;
        private System.Windows.Forms.MaskedTextBox MskNum4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ınformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theLotteryMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitTurnToMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producerInformationToolStripMenuItem;
    }
}