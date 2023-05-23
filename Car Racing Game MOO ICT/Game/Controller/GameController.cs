using System;
using System.Drawing;
using System.Windows.Forms;
using Car_Racing_Game_MOO_ICT.Game.Domain;
using Car_Racing_Game_MOO_ICT.Game.View;

namespace Car_Racing_Game_MOO_ICT.Game.Controller
{
    public class Game
    {
        private PictureBox Player { get; }
        private PictureBox Explosion { get; }
        private PictureBox Award { get; }
        private Timer GameTimer { get; }
        private Button BtnStart { get; }
        private Score score = new Score(); 
        private Sun sun = new Sun(); 
        private Speed Speed { get; } = new Speed(12, 15, 12);

        public Game(Timer gameTimer, PictureBox explosion, PictureBox player, PictureBox award, Button btnStart, Speed speed)
        {
            GameTimer = gameTimer;
            Explosion = explosion;
            Player = player;
            Award = award;
            Speed = speed;
            BtnStart = btnStart;
        }

        public void UpdateAward()
        {
            var endScore = score.CurrentScore;
            Award.Image = endScore > 2000 ? Properties.Resources.gold :
                           endScore > 500 ? Properties.Resources.silver :
                           Properties.Resources.bronze;
            Speed.roadSpeed = endScore > 500 ? 18 : endScore > 2000 ? 23 : 13;
            Speed.trafficSpeed = endScore > 500 ? 20 : endScore > 2000 ? 25 : 16;
        }
        
        public void GameNyanCat(TransparentPanel panel)
        {
            GameTimer.Stop();

            var form = new Form1();
            panel.Controls.Clear();
            
            panel.BackColor = Color.CornflowerBlue;

            var catCreator = new NyanCat(panel, new Random());
            for (var i = 0; i < 5; i++)
            {
                catCreator.CreateNyanCat(i * 50 + 10);
            }
            //if (sun.getSunCount() >= 501) gameOver();
        }

       private void gameOver()
        {
            playSound();
            GameTimer.Stop();
            Explosion.Visible = true;
            Player.Controls.Add(Explosion);
            Explosion.Location = new Point(-8, 5);
            Explosion.BackColor = Color.Transparent;

            Award.Visible = true;
            Award.BringToFront();

            BtnStart.Enabled = true;
        }

        public void ResetGame()
        {
            BtnStart.Enabled = false;
            Explosion.Visible = false;
            Award.Visible = false; 
            Award.Image = Properties.Resources.bronze;

            score.ResetScore(); 
            sun.ResetSunScore();
        }

        private void playSound()
        {
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Properties.Resources.hit);
            playCrash.Play();
        }

        public void SetGameSettings(PictureBox AI1, PictureBox AI2, PictureBox SUN1, PictureBox SUN2, Random position)
        {
            Speed.roadSpeed = 13;
            Speed.trafficSpeed = 16;

            AI1.Top = position.Next(200, 500) * -1;
            AI1.Left = position.Next(5, 200);
            AI2.Top = position.Next(200, 500) * -1;
            AI2.Left = position.Next(245, 422);

            SUN1.Top = position.Next(200, 500) * -1;
            SUN1.Left = position.Next(5, 200);
            SUN2.Top = position.Next(200, 500) * -1;
            SUN2.Left = position.Next(245, 422);
        }
    }
}
