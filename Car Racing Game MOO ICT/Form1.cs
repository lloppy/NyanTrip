using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car_Racing_Game_MOO_ICT.Game;

namespace Car_Racing_Game_MOO_ICT
{
    public partial class Form1 : Form
    {
        Speed speed;
        int score;

        Random carPosition = new Random();

        bool goleft, goright;

        public Form1()
        {
            InitializeComponent();
            speed = new Speed(12, 15, 12); 
            ResetGame();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;
            score++;

            if (goleft == true && player.Left > 10)
            {
                player.Left -= speed.playerSpeed;
            }
            if (goright == true && player.Left < 415)
            {
                player.Left += speed.playerSpeed;
            }

            roadTrack1.Top += speed.roadSpeed;
            roadTrack2.Top += speed.roadSpeed;

            if (roadTrack2.Top > 519)
            {
                roadTrack2.Top = -519;
            }
            if (roadTrack1.Top > 519)
            {
                roadTrack1.Top = -519;
            }

            AI1.Top += speed.trafficSpeed;
            AI2.Top += speed.trafficSpeed;


            if (AI1.Top > 530)
            {
                changeAIcars(AI1);
            }

            if (AI2.Top > 530)
            {
                changeAIcars(AI2);
            }

            if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds))
            {
                gameOver();
            }

            if (score > 40 && score < 500)
            {
                award.Image = Properties.Resources.bronze;
            }


            if (score > 500 && score < 2000)
            {
                award.Image = Properties.Resources.silver;
                speed.roadSpeed = 18;
                speed.trafficSpeed = 20;
            }

            if (score > 2000)
            {
                award.Image = Properties.Resources.gold;
                speed.trafficSpeed = 25;
                speed.roadSpeed = 23;
            }
        }

        private void changeAIcars(PictureBox tempCar)
        {
            var ai = new AI(tempCar);
        }

        private void gameOver()
        {
            var game = new Game.Game();
            game.gameOver(gameTimer, explosion, player, award, btnStart);
        }

        private void ResetGame()
        {
            var game = new Game.Game();
            game.ResetGame(gameTimer, explosion, award, btnStart);
            
            speed.roadSpeed = 13;
            speed.trafficSpeed = 16;
            score = 0;

            AI1.Top = carPosition.Next(200, 500) * -1;
            AI1.Left = carPosition.Next(5, 200);

            AI2.Top = carPosition.Next(200, 500) * -1;
            AI2.Left = carPosition.Next(245, 422);
            
            gameTimer.Start();
        }

        private void restartGame(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}