using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game
{
    public partial class Form1 : Form
    {

        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 12;
        int score;
        int carImage;

        Random rand = new Random();
        Random carPosition = new Random();

        bool goleft, goright;

        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) //Se a tecla esquerda for pressionada, goleft recebe verdadeiro.
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right) //Se a tecla direita for pressionada, goright recebe verdadeiro.
            {
                goright = true;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) //Se a tecla esquerda não for pressionada, goleft recebe falso.
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right) //Se a tecla esquerda não for pressionada, goright recebe falso.
            {
                goright = false;
            }

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            //Faz o player se movimentar pela estrada sem sair da borda do Panel 
            if (goleft == true && player.Left > 10)
            {
                player.Left -= playerSpeed;
            }
            if (goright == true && player.Left < 415)
            {
                player.Left += playerSpeed;
            }

            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;

            /*Cria uma ilusão de ótica de movimento em que se a roadTrack2 chegar no fim do panel,
             *ela retornará para o topo trocando de posição com a roadTrack1 :D */
            if (roadTrack2.Top > 519)
            {
                roadTrack2.Top = -519;
            }
            if (roadTrack1.Top > 519)
            {
                roadTrack1.Top = -519;
            }
        }

        private void changeAIcars(PictureBox tempCar)
        {

        }

        private void gameOver()
        {

        }

        private void ResetGame()
        {
            //Resetando as variáveis para o estágio inicial
            btnStart.Enabled = false;
            explosão.Visible = false;
            award.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            award.Image = Properties.Resources.bronze;

            roadSpeed = 12;
            trafficSpeed = 15;

            //A ser Comentado
            Carro1.Top = carPosition.Next(200, 500) * -1;
            Carro1.Left = carPosition.Next(5, 200);

            Carro2.Top = carPosition.Next(200, 500) * -1;
            Carro2.Left = carPosition.Next(245, 422);

            gameTimer.Start();

        }

        private void RoadTrack2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playSound()
        {

        }

    }
}
