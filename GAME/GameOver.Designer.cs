namespace GAME
{
    partial class GameOver
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
            this.picOver = new System.Windows.Forms.PictureBox();
            this.picHouse = new System.Windows.Forms.PictureBox();
            this.picReplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReplay)).BeginInit();
            this.SuspendLayout();
            // 
            // picOver
            // 
            this.picOver.Location = new System.Drawing.Point(-2, 0);
            this.picOver.Name = "picOver";
            this.picOver.Size = new System.Drawing.Size(926, 635);
            this.picOver.TabIndex = 0;
            this.picOver.TabStop = false;
            // 
            // picHouse
            // 
            this.picHouse.BackColor = System.Drawing.Color.Black;
            this.picHouse.BackgroundImage = global::GAME.Properties.Resources.Inicio;
            this.picHouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHouse.Location = new System.Drawing.Point(320, 439);
            this.picHouse.Name = "picHouse";
            this.picHouse.Size = new System.Drawing.Size(104, 89);
            this.picHouse.TabIndex = 4;
            this.picHouse.TabStop = false;
            this.picHouse.Click += new System.EventHandler(this.picHouse_Click);
            // 
            // picReplay
            // 
            this.picReplay.BackColor = System.Drawing.Color.Black;
            this.picReplay.BackgroundImage = global::GAME.Properties.Resources.replay;
            this.picReplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picReplay.Location = new System.Drawing.Point(430, 439);
            this.picReplay.Name = "picReplay";
            this.picReplay.Size = new System.Drawing.Size(104, 89);
            this.picReplay.TabIndex = 3;
            this.picReplay.TabStop = false;
            this.picReplay.Click += new System.EventHandler(this.picReplay_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 596);
            this.Controls.Add(this.picHouse);
            this.Controls.Add(this.picReplay);
            this.Controls.Add(this.picOver);
            this.MaximizeBox = false;
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.GameOver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picOver;
        private System.Windows.Forms.PictureBox picHouse;
        private System.Windows.Forms.PictureBox picReplay;
    }
}