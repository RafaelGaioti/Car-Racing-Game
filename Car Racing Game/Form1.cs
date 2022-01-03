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
        int playerSpeed;
        int score;
        int carImage;

        Random rand = new Random();
        Random carPosition = new Random();

        bool goleft, goright;

        public Form1()
        {
            InitializeComponent();
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
            Explosão.Visible = false;
            award.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            award.Image = Properties.Resources.bronze;

            roadSpeed = 12;
            trafficSpeed = 15;

            Carro1.Top = carPosition.Next(200, 500) * -1;
            Carro1.Left = carPosition.Next(5, 200);

            Carro2.Top = carPosition.Next(200, 500) * -1;
            Carro2.Left = carPosition.Next(245, 430);

            gameTimer.Start();

        }

        private void RoadTrack2_Click(object sender, EventArgs e)
        {

        }

        private void playSound()
        {

        }

    }
}
