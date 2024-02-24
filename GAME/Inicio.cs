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
using GAME;
using System.Media;

namespace PJuego
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            SoundPlayer sonido;
            sonido = new SoundPlayer(@"..\..\Resources\FondoSonido.wav");
            sonido.PlayLooping();
        }

        private void PicInformacion_Click(object sender, EventArgs e)
        {
            Form formulario = new FormInformacion();
            formulario.ShowDialog();
        }

        private void PicSolución_Click(object sender, EventArgs e)
        {
           /*Form formulario = new FormSolucion();
            formulario.Show();*/
        }

        private void PicIntegrantes_Click(object sender, EventArgs e)
        {
           
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

        private void picComenzar_Click(object sender, EventArgs e)
        {
            Game iniciar = new Game();
            iniciar.Show();
            this.Hide();
        }
    }
}
