using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PJuego
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PicInformacion_Click(object sender, EventArgs e)
        {
            Form formulario = new FormInformacion();
            formulario.Show();
        }

        private void PicSolución_Click(object sender, EventArgs e)
        {
            Form formulario = new FormSolucion();
            formulario.Show();
        }

        private void PicIntegrantes_Click(object sender, EventArgs e)
        {
            Form formulario = new FormIntegrantes();
            formulario.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
