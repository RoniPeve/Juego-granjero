namespace PJuego
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.picInformacion = new System.Windows.Forms.PictureBox();
            this.picComenzar = new System.Windows.Forms.PictureBox();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picInformacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComenzar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // picInformacion
            // 
            this.picInformacion.BackColor = System.Drawing.Color.Transparent;
            this.picInformacion.BackgroundImage = global::GAME.Properties.Resources.servicio_al_cliente;
            this.picInformacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picInformacion.Location = new System.Drawing.Point(417, 12);
            this.picInformacion.Name = "picInformacion";
            this.picInformacion.Size = new System.Drawing.Size(137, 77);
            this.picInformacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInformacion.TabIndex = 0;
            this.picInformacion.TabStop = false;
            this.picInformacion.Click += new System.EventHandler(this.PicInformacion_Click);
            // 
            // picComenzar
            // 
            this.picComenzar.BackColor = System.Drawing.Color.Transparent;
            this.picComenzar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picComenzar.Image = global::GAME.Properties.Resources.logo;
            this.picComenzar.Location = new System.Drawing.Point(209, 164);
            this.picComenzar.Name = "picComenzar";
            this.picComenzar.Size = new System.Drawing.Size(383, 102);
            this.picComenzar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picComenzar.TabIndex = 3;
            this.picComenzar.TabStop = false;
            this.picComenzar.Click += new System.EventHandler(this.picComenzar_Click);
            // 
            // iconcerrar
            // 
            this.iconcerrar.BackColor = System.Drawing.Color.Transparent;
            this.iconcerrar.Image = global::GAME.Properties.Resources.botonCerrar;
            this.iconcerrar.Location = new System.Drawing.Point(758, 3);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(30, 36);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 4;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.Iconcerrar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GAME.Properties.Resources.Port;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconcerrar);
            this.Controls.Add(this.picComenzar);
            this.Controls.Add(this.picInformacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picInformacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComenzar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picInformacion;
        private System.Windows.Forms.PictureBox picComenzar;
        private System.Windows.Forms.PictureBox iconcerrar;
    }
}

