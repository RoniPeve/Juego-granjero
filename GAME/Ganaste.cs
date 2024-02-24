using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using PJuego;

namespace GAME
{
    public partial class Ganaste : Form
    {
        public Ganaste()
        {
            InitializeComponent();
            picWin.Image = Image.FromFile(@"..\..\Resources\Win.gif");
            picWin.SizeMode = PictureBoxSizeMode.StretchImage;//YOU_WIN.wav
            SoundPlayer son;
            son = new SoundPlayer(@"..\..\Resources\YOU_WIN.wav");
            son.Play();
        }

        private void Ganaste_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void picReplay_Click(object sender, EventArgs e)
        {
            Game replay = new Game();
            replay.Show();
            this.Hide();
        }

        private void picHouse_Click(object sender, EventArgs e)
        {
            Inicio house = new Inicio();
            this.Hide();
            house.Show();
        }
    }
}
