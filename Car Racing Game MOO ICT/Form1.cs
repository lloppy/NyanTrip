using System;
using System.Windows.Forms;
using Car_Racing_Game_MOO_ICT.Game;

namespace Car_Racing_Game_MOO_ICT
{
    public partial class Form1 : Form
    {
        private Speed speed;
        private Score score;
        private Sun sun;
        
        private Game.Game game;
    
        Random position = new Random();

        bool goleft, goright;

        public Form1()
        {
            InitializeComponent();
            speed = new Speed(12, 15, 12); 
            score = new Score();
            sun = new Sun();
            game = new Game.Game();

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
            score.UpdateScore(txtScore);

            if (goleft && player.Left > 10)
            {
                player.Left -= speed.playerSpeed;
            }
            if (goright && player.Left < 415)
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
            
            SUN1.Top += speed.trafficSpeed;
            SUN2.Top += speed.trafficSpeed;
            
            if (AI1.Top > 530)
            {
                changeAIcars(AI1);
            }

            if (AI2.Top > 530)
            {
                changeAIcars(AI2);
            }
            
            if (AI1.Top > 520)
            {
                changeAIsuns(SUN1);
            }

            if (AI2.Top > 520)
            {
                changeAIsuns(SUN2);
            }
           

            if (player.Bounds.IntersectsWith(SUN1.Bounds) || player.Bounds.IntersectsWith(SUN2.Bounds))
            {
                sun.UpdateScore(sunScore);
            }
            
            if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds))
            {
                game.gameOver(gameTimer, explosion, player, award, btnStart);
            }

            var endscore = this.score.getScore();
            
            if (endscore > 40 && endscore < 500)
            {
                award.Image = Properties.Resources.bronze;
            }
            
            if (endscore > 500 && endscore < 2000)
            {
                award.Image = Properties.Resources.silver;
                speed.roadSpeed = 18;
                speed.trafficSpeed = 20;
            }

            if (endscore > 2000)
            {
                award.Image = Properties.Resources.gold;
                speed.trafficSpeed = 25;
                speed.roadSpeed = 23;
            }

            if (sun.getSunCount() == 100)
            {
                game.gameOver(gameTimer, explosion, player, award, btnStart);
            }
        }

        private void changeAIsuns(PictureBox tempSun)
        {
            var ai = new Sun(tempSun);
        }
        
        private void changeAIcars(PictureBox tempCar)
        {
            var ai = new AI(tempCar);
        }
        
        private void ResetGame()
        {
            game.ResetGame(gameTimer, explosion, award, btnStart);
            
            speed.roadSpeed = 13;
            speed.trafficSpeed = 16;
            score.ResetScore();
            sun.ResetSunScore();
            sun.UpdateScore(sunScore);

            AI1.Top = position.Next(200, 500) * -1;
            AI1.Left = position.Next(5, 200);

            AI2.Top = position.Next(200, 500) * -1;
            AI2.Left = position.Next(245, 422);
            
            
            SUN1.Top = position.Next(200, 500) * -1;
            SUN1.Left = position.Next(5, 200);

            SUN2.Top = position.Next(200, 500) * -1;
            SUN2.Left = position.Next(245, 422);
            
            gameTimer.Start();
        }

        private void restartGame(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}