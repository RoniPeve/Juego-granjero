using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using PJuego;

namespace GAME
{
    public partial class GameOver : Form
    {
        //string mensaje;
        public GameOver()
        {
            InitializeComponent();
            picOver.Image = Image.FromFile(@"..\..\Resources\GameOver.gif");
           
        }
        public void sonido1()
        {
            SoundPlayer sonido;
            picOver.SizeMode = PictureBoxSizeMode.StretchImage;
            
            sonido = new SoundPlayer(@"..\..\Resources\GameOver.wav");
            sonido.Play();
            
            //sonido2();
        }
        
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            sonido1();
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
