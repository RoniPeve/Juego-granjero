using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace GAME
{
    public partial class Game : Form
    {
        SoundPlayer sonido;
        public Game()
        {
            InitializeComponent();
            INICIAR();
            
            sonido = new SoundPlayer(@"..\..\Resources\FondoSonido.wav");
            sonido.PlayLooping();
        }
        string mensaje = "no se envia";
        void INICIAR()
        {
            pictureBox1.Visible = true;
            pictGranjero.Visible = true;
            pictMAIZ.Visible = true;
            pictGallina.Visible = true;
            plBarco.Location = new Point(28, 306);
            plBarco2.Location = new Point(508, 306);
            pictgranjero2.Visible = false;
            pictmaiz2.Visible = false;
            pictgallina2.Visible = false;
            pictzorro2.Visible = false;
            pictGallina3.Visible = false;
            pictGranjero3.Visible = false;
            pictMaiz3.Visible = false;
            pictZorro3.Visible = false;
            pictGranjero4.Visible = false;
            pictZorro4.Visible = false;
            pictMaiz4.Visible = false;
            pictGallina4.Visible = false;
            plBarco2.Visible = false;
        }
        private void PictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (plBarco.Visible && plBarco.Left == 28)
            {
                pictureBox1.Visible = false;
                pictzorro2.Visible = true;
            }
        }

        private void Pictzorro2_DoubleClick(object sender, EventArgs e)
        {
            if (plBarco.Left == 28)
            {
                pictureBox1.Visible = true;
                pictzorro2.Visible = false;
            }
            
        }

        private void PictMAIZ_DoubleClick(object sender, EventArgs e)
        {
            if (plBarco.Visible && plBarco.Left == 28)
            {
                pictMAIZ.Visible = false;
                pictmaiz2.Visible = true;
            }
        }

        private void PictGranjero_DoubleClick(object sender, EventArgs e)
        {
            if (plBarco.Visible)
            {
                pictGranjero.Visible = false;
                pictgranjero2.Visible = true;
                pictmaiz2.BringToFront();
            }
        }

        private void PictGallina_DoubleClick(object sender, EventArgs e)
        {
            if (plBarco.Visible && plBarco.Left == 28)
            {
                pictGallina.Visible = false;
                pictgallina2.Visible = true;
            }
        }

        private void Pictmaiz2_DoubleClick(object sender, EventArgs e)
        {
            if (plBarco.Left == 28)
            {
                pictMAIZ.Visible = true;
                pictmaiz2.Visible = false;
            }
            
        }

        private void Pictgranjero2_DoubleClick(object sender, EventArgs e)
        {
            if (plBarco.Left == 28)
            {
                pictGranjero.Visible = true;
                pictgranjero2.Visible = false;
            }
           
        }

        private void Pictgallina2_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void Pictgallina2_DoubleClick(object sender, EventArgs e)
        {
            if (plBarco.Left==28)
            {
                pictGallina.Visible = true;
                pictgallina2.Visible = false;
            }
        }

        int contador = 0;
        int volver = 0;
        public void trasladar()
        {
            if (pictgranjero2.Visible == true)
            {
                if ((pictzorro2.Visible == true && pictgallina2.Visible == true && pictmaiz2.Visible == true) ||
                    (pictzorro2.Visible == false && pictgallina2.Visible == true && pictmaiz2.Visible == true) ||
                    (pictzorro2.Visible == true && pictgallina2.Visible == false && pictmaiz2.Visible == true) ||
                    (pictzorro2.Visible == true && pictgallina2.Visible == true && pictmaiz2.Visible == false)
                    )
                {
                   
                    MessageBox.Show("solo puenden entrar dos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (pictureBox1.Visible == true && pictGallina.Visible == true && pictMAIZ.Visible == true)
                    {
                        MessageBox.Show("no se pueden quedar los 3 animales", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (verificar())
                        {
                            DoubleBuffered = true;
                            timer1.Start();
                        }
                        else
                        {
                            GameOver();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay quien maneje el bote", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
            }
        }

        public void bajar()
        {

            if (plBarco.Left >= 500 && plBarco.Visible)
            {
                if (pictgranjero2.Visible)
                {
                    if (pictmaiz2.Visible)
                    {
                        pictmaiz2.Visible = false;                 
                        pictMaiz3.Visible = true;

                    }
                    if ( pictzorro2.Visible)
                    {
                        pictzorro2.Visible = false;
                        pictZorro3.Visible = true;
                    }
                    if (pictgallina2.Visible)
                    {
                        pictGallina3.Visible = true;
                        pictgallina2.Visible = false;


                    }
                }
                pictgranjero2.Visible = false;
                pictGranjero3.Visible = true;
                plBarco.Visible = false;
                plBarco2.Visible = true;
                plBarco2.Location = new Point(508, 306);
                GANAR();
                
            }
            if (plBarco2.Left == 28 && plBarco2.Visible)
            {
                if (pictGranjero4.Visible && pictMaiz4.Visible)
                {
                    pictMaiz4.Visible = false;
                    pictMAIZ.Visible = true;


                }
                if (pictGranjero4.Visible && pictZorro4.Visible)
                {
                    pictZorro4.Visible = false;
                    pictureBox1.Visible = true;
                }
                if (pictGranjero4.Visible && pictGallina4.Visible)
                {
                    pictGallina.Visible = true;
                    pictGallina4.Visible = false;
                    if (pictureBox1.Visible==false)
                    {
                        pictGallina.Location= new Point(2,390);
                    }
                    if (pictMAIZ.Visible==false)
                    {
                        pictGallina.Location = new Point(74, 387);
                    }


                }
                pictGranjero4.Visible = false;
                pictGranjero.Visible = true;
                plBarco2.Visible = false;
                plBarco.Visible = true;
                plBarco.Location = new Point(28, 306);
            }
        }
        
        public bool verificar()
        {

            if (plBarco.Visible)
            {
                if (pictureBox1.Visible && pictGallina.Visible)
                {
                    MessageBox.Show("el zorro se come a la gallina", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mensaje = "zorro";
                    return false;
                    
                }
                if (pictMAIZ.Visible && pictGallina.Visible)
                {
                    MessageBox.Show("La gallina se come al maiz", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    return false;
                }
            }
            if (plBarco2.Visible)
            {
                if (pictZorro3.Visible && pictGallina3.Visible)
                {
                    MessageBox.Show("el zorro se come a la gallina", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show("el zorro se come a la gallina");
                    mensaje = "zorro";
                    return false;
                }
                if (pictMaiz3.Visible && pictGallina3.Visible)
                {
                    MessageBox.Show("La gallina se come al maiz", "Game Over", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    mensaje = "gallina";
                    return false;
                }
            }

            return true;
        }

        private void BtnTrasladar_Click(object sender, EventArgs e)
        {
            if (plBarco.Left == 28 && plBarco.Visible)
            {
                trasladar();


            }
            if (plBarco2.Left > 500 && plBarco2.Visible)
            {
                Regresar();

            }
            

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            plBarco.Location = new Point(28 + contador, 306);
            contador = contador + 2;
            
            if (plBarco.Left >= 500)
            {
                timer1.Stop();
                //MessageBox.Show(plBarco.Location.ToString());
                bajar();
                contador = 0;
            }


        }

        private void PictGranjero3_DoubleClick(object sender, EventArgs e)
        {
            if (plBarco2.Visible)
            {
                pictGranjero3.Visible = false;
                pictGranjero4.Visible = true;
                pictGranjero4.BringToFront();
                pictGallina4.BringToFront();
            }
        }

        public void Regresar()
        {
            if (pictGranjero4.Visible)
            {
                if ((pictZorro4.Visible == true && pictGallina4.Visible == true && pictMaiz4.Visible == true) ||
                    (pictZorro4.Visible == false && pictGallina4.Visible == true && pictMaiz4.Visible == true) ||
                    (pictZorro4.Visible == true && pictGallina4.Visible == false && pictMaiz4.Visible == true) ||
                    (pictZorro4.Visible == true && pictGallina4.Visible == true && pictMaiz4.Visible == false)
                    )
                {

                    MessageBox.Show("solo puenden entrar dos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    
                        if (verificar())
                        {
                            DoubleBuffered = true;
                            timRegresar.Start();
                        }
                        else
                        {
                            GameOver();
                        }
                    
                }
                /*
                if ((pictZorro3.Visible && pictGallina3.Visible && pictMaiz3.Visible) ||
                    (pictZorro3.Visible == false && pictGallina3.Visible && pictMaiz3.Visible) ||
                    (pictZorro3.Visible && pictGallina3.Visible == false && pictMaiz3.Visible ) ||
                    (pictZorro3.Visible && pictGallina3.Visible && pictMaiz3.Visible == false)
                    )
                {

                    if (verificar())
                    {
                       // MessageBox.Show("REGRESAR");

                        DoubleBuffered = true;
                        timRegresar.Start();
                        pictmaiz2.Visible = false;
                    }
                    else
                    {
                        GameOver();
                    }
                }
               */


            }
            else
            {
                MessageBox.Show("No hay quien maneje el bote", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
            }
        }
       
        private void PictGallina3_DoubleClick(object sender, EventArgs e)
        {
            if (plBarco2.Visible && plBarco2.Left == 508)
            {
                pictGallina3.Visible = false;
                pictGallina4.Visible = true;
                pictGallina4.BringToFront();
                pictGranjero4.SendToBack();
            }
        }

        private void PictGranjero4_DoubleClick(object sender, EventArgs e)
        {
            if (plBarco2.Visible && plBarco.Left==508)
            {
                pictGranjero3.Visible = true;
                pictGranjero4.Visible = false;
                //pictGranjero4.BringToFront();
                pictGranjero4.SendToBack();
            }
        }

        private void PictGallina4_DoubleClick(object sender, EventArgs e)
        {
            if (plBarco2.Visible && plBarco2.Left == 508)
            {
                pictGallina3.Visible = true;
                pictGallina4.Visible = false;
            }

           
        }
        public void GANAR()
        {
            if (pictGranjero3.Visible && pictGallina3.Visible && pictMaiz3.Visible && pictZorro3.Visible)
            {
                /*Form2 win = new Form2();
                 win.ShowDialog();
                 this.Hide();*/
               // sonido.Stop();
                MessageBox.Show("FELICIDADES GANASTE");
                btnTrasladar.Enabled = false;
                Ganaste win = new Ganaste();
                
                this.Hide();
                win.Show();

            }
        }
        public void GameOver()
        {
            GameOver over = new GameOver();
            over.Show();
            this.Hide();
        }
        private void TimRegresar_Tick(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            plBarco2.Location = new Point(508 - volver, 306);
            if (plBarco2.Left <= 28)
            {
                timRegresar.Stop();
                bajar();
                volver = 0;
                
            }
            volver = volver + 2;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void PictMaiz3_DoubleClick(object sender, EventArgs e)
        {
            if (plBarco2.Visible && plBarco2.Left == 508)
            {
                pictMaiz3.Visible = false;
                pictMaiz4.Visible = true;
            }
        }

        private void PictZorro3_DoubleClick(object sender, EventArgs e)
        {
            if (plBarco2.Visible && plBarco2.Left == 508)
            {
                pictZorro3.Visible = false;
                pictZorro4.Visible = true;
            }
        }

        private void PictMaiz4_DoubleClick(object sender, EventArgs e)
        {
            pictMaiz3.Visible = true;
            pictMaiz4.Visible = false;
        }

        private void PictZorro4_DoubleClick(object sender, EventArgs e)
        {
            pictZorro3.Visible = true;
            pictZorro4.Visible = false;
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
