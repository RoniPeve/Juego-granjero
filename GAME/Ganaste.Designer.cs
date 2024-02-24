namespace GAME
{
    partial class Ganaste
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
            this.picHouse = new System.Windows.Forms.PictureBox();
            this.picReplay = new System.Windows.Forms.PictureBox();
            this.picWin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWin)).BeginInit();
            this.SuspendLayout();
            // 
            // picHouse
            // 
            this.picHouse.BackColor = System.Drawing.Color.Transparent;
            this.picHouse.BackgroundImage = global::GAME.Properties.Resources.Inicio;
            this.picHouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHouse.Location = new System.Drawing.Point(345, 434);
            this.picHouse.Name = "picHouse";
            this.picHouse.Size = new System.Drawing.Size(104, 89);
            this.picHouse.TabIndex = 2;
            this.picHouse.TabStop = false;
            this.picHouse.Click += new System.EventHandler(this.picHouse_Click);
            // 
            // picReplay
            // 
            this.picReplay.BackColor = System.Drawing.Color.Transparent;
            this.picReplay.BackgroundImage = global::GAME.Properties.Resources.replay;
            this.picReplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picReplay.Location = new System.Drawing.Point(455, 434);
            this.picReplay.Name = "picReplay";
            this.picReplay.Size = new System.Drawing.Size(104, 89);
            this.picReplay.TabIndex = 1;
            this.picReplay.TabStop = false;
            this.picReplay.Click += new System.EventHandler(this.picReplay_Click);
            // 
            // picWin
            // 
            this.picWin.Location = new System.Drawing.Point(-2, 0);
            this.picWin.Name = "picWin";
            this.picWin.Size = new System.Drawing.Size(919, 635);
            this.picWin.TabIndex = 0;
            this.picWin.TabStop = false;
            // 
            // Ganaste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(910, 596);
            this.Controls.Add(this.picHouse);
            this.Controls.Add(this.picReplay);
            this.Controls.Add(this.picWin);
            this.MaximizeBox = false;
            this.Name = "Ganaste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ganaste";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ganaste_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picWin;
        private System.Windows.Forms.PictureBox picReplay;
        private System.Windows.Forms.PictureBox picHouse;
    }
}