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

            txtScore.Text = "Score: " + score;
            score++;

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

            /*Cria uma ilusão ótica de movimento em que se a roadTrack2 chegar no fim do panel,
             *ela retornará para o topo trocando de posição com a roadTrack1. */
            if (roadTrack2.Top > 519)
            {
                roadTrack2.Top = -519;
            }
            if (roadTrack1.Top > 519)
            {
                roadTrack1.Top = -519;
            }

            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;

            //Troca a imagem e a posição dos carros quando eles reaparecem no topo
            if (AI1.Top > 530)
            {
                changeAIcars(AI1);
            }

            if (AI2.Top > 530)
            {
                changeAIcars(AI2);
            }

            //Se as hitboxes dos carros colidirem, o jogo acaba
            if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds))
            {
                gameOver();
            }

            //Se o score for maior que 40 e menor que 500, o jogador recebe a medalha de bronze
            if (score > 40 && score < 500)
            {
                award.Image = Properties.Resources.bronze;
            }
            /*Se o score for maior que 500 e menor que 2000, o jogador recebe a medalha de prata
              e a velocidade do jogo também aumenta */
            if (score > 500 && score < 2000)
            {
                award.Image = Properties.Resources.silver;
                roadSpeed = 20;
                trafficSpeed = 22;
            }
            /*Se o score for maior que 2000, o jogador recebe a medalha de ouro e a velocidade do 
             jogo aumenta*/
            if (score > 2000)
            {
                award.Image = Properties.Resources.gold;
                trafficSpeed = 27;
                roadSpeed = 25;
            }
        }

        private void changeAIcars(PictureBox tempCar)
        { 
            carImage = rand.Next(1, 8);

            //Faz o sorteio do carro que vai aparecer em seguida
            switch (carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    tempCar.Image= Properties.Resources.carGreen;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.carGrey;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carOrange;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.carPink;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;
            }

            tempCar.Top = carPosition.Next(100, 400) * -1;

            //Troca a posição dos carros a cada vez que aparecem
            if ((string)tempCar.Tag == "carleft")
            {
                tempCar.Left = carPosition.Next(5, 200);
            }

            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(245, 422);
            }
        }

        private void gameOver()
        {
            //Mostra a explosão a centraliza do player, mostra a award e habilita o áudio da batida. 
            playSound();
            gameTimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8, -5);
            explosion.BackColor = Color.Transparent;

            award.Visible = true;
            award.BringToFront();

            btnStart.Enabled = true;

        }

        private void ResetGame()
        {
            //Resetando as variáveis para o estágio inicial
            btnStart.Enabled = false;
            explosion.Visible = false;
            award.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            award.Image = Properties.Resources.bronze;

            roadSpeed = 12;
            trafficSpeed = 15;

            //A ser Comentado
            AI1.Top = carPosition.Next(200, 500) * -1;
            AI1.Left = carPosition.Next(5, 200);

            AI2.Top = carPosition.Next(200, 500) * -1;
            AI2.Left = carPosition.Next(245, 422);

            gameTimer.Start();

        }

        private void RoadTrack2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void restartGame(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void playSound()
        {
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Properties.Resources.hit);
            playCrash.Play();
        }

    }
}
