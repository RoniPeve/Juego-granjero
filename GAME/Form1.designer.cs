namespace PJuego
{
    partial class Form1
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
            this.picIntegrantes = new System.Windows.Forms.PictureBox();
            this.picSolución = new System.Windows.Forms.PictureBox();
            this.picComenzar = new System.Windows.Forms.PictureBox();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picInformacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIntegrantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSolución)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComenzar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // picInformacion
            // 
            this.picInformacion.BackColor = System.Drawing.Color.Transparent;
            this.picInformacion.Image = global::PJuego.Properties.Resources.servicio_al_cliente;
            this.picInformacion.Location = new System.Drawing.Point(321, 12);
            this.picInformacion.Name = "picInformacion";
            this.picInformacion.Size = new System.Drawing.Size(137, 77);
            this.picInformacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInformacion.TabIndex = 0;
            this.picInformacion.TabStop = false;
            this.picInformacion.Click += new System.EventHandler(this.PicInformacion_Click);
            // 
            // picIntegrantes
            // 
            this.picIntegrantes.BackColor = System.Drawing.Color.Transparent;
            this.picIntegrantes.Image = global::PJuego.Properties.Resources.trabajo_en_equipo;
            this.picIntegrantes.Location = new System.Drawing.Point(197, 12);
            this.picIntegrantes.Name = "picIntegrantes";
            this.picIntegrantes.Size = new System.Drawing.Size(137, 77);
            this.picIntegrantes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIntegrantes.TabIndex = 1;
            this.picIntegrantes.TabStop = false;
            this.picIntegrantes.Click += new System.EventHandler(this.PicIntegrantes_Click);
            // 
            // picSolución
            // 
            this.picSolución.BackColor = System.Drawing.Color.Transparent;
            this.picSolución.Image = global::PJuego.Properties.Resources.bombilla;
            this.picSolución.Location = new System.Drawing.Point(442, 12);
            this.picSolución.Name = "picSolución";
            this.picSolución.Size = new System.Drawing.Size(137, 77);
            this.picSolución.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSolución.TabIndex = 2;
            this.picSolución.TabStop = false;
            this.picSolución.Click += new System.EventHandler(this.PicSolución_Click);
            // 
            // picComenzar
            // 
            this.picComenzar.BackColor = System.Drawing.Color.Transparent;
            this.picComenzar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picComenzar.Image = global::PJuego.Properties.Resources.logo;
            this.picComenzar.Location = new System.Drawing.Point(209, 164);
            this.picComenzar.Name = "picComenzar";
            this.picComenzar.Size = new System.Drawing.Size(383, 102);
            this.picComenzar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picComenzar.TabIndex = 3;
            this.picComenzar.TabStop = false;
            // 
            // iconcerrar
            // 
            this.iconcerrar.BackColor = System.Drawing.Color.Transparent;
            this.iconcerrar.Image = global::PJuego.Properties.Resources.boton_x1;
            this.iconcerrar.Location = new System.Drawing.Point(758, 3);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(30, 36);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 4;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.Iconcerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PJuego.Properties.Resources.Port;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconcerrar);
            this.Controls.Add(this.picComenzar);
            this.Controls.Add(this.picSolución);
            this.Controls.Add(this.picIntegrantes);
            this.Controls.Add(this.picInformacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picInformacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIntegrantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSolución)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComenzar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picInformacion;
        private System.Windows.Forms.PictureBox picIntegrantes;
        private System.Windows.Forms.PictureBox picSolución;
        private System.Windows.Forms.PictureBox picComenzar;
        private System.Windows.Forms.PictureBox iconcerrar;
    }
}

