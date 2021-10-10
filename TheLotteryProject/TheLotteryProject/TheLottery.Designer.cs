
namespace TheLotteryProject
{
    partial class TheLottery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheLottery));
            this.BtnLottery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLottery
            // 
            this.BtnLottery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLottery.BackgroundImage")));
            this.BtnLottery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLottery.Location = new System.Drawing.Point(56, 87);
            this.BtnLottery.Name = "BtnLottery";
            this.BtnLottery.Size = new System.Drawing.Size(146, 139);
            this.BtnLottery.TabIndex = 0;
            this.BtnLottery.UseVisualStyleBackColor = true;
            this.BtnLottery.Click += new System.EventHandler(this.BtnLottery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "START!";
            // 
            // TheLottery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(275, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLottery);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TheLottery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Lottery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLottery;
        private System.Windows.Forms.Label label1;
    }
}

