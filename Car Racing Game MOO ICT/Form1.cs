using System; 
using System.Windows.Forms; 
using Car_Racing_Game_MOO_ICT.Game;

namespace Car_Racing_Game_MOO_ICT { 
    public partial class Form1 : Form { 

        private Speed speed; 
        private Score score; 
        private Sun sun; 
        private AI ai; 
        private Game.Game game; 
        Random position = new Random(); 
        bool goleft, goright;

        public Form1() { 
            InitializeComponent(); 
            speed = new Speed(12, 15, 12); 
            score = new Score(); 
            sun = new Sun(); 
            ai = new AI(); 
            game = new Game.Game(gameTimer, explosion, player, award, btnStart, sunScore); 
            score.ScoreUpdated += Score_ScoreUpdated; 
        } 
        
        private void gameTimerEvent(object sender, EventArgs e) { 
            UpdateScore(); 
            MovePlayer(); 
            MoveRoad(); 
            ai.MoveTraffic(AI1, AI2, speed); 
            MoveSun(); 
            CheckCollisions(); 
            UpdateAward(); 
            CheckGameOver(); 
        } 
        
        private void Score_ScoreUpdated(object sender, int e) { 
            txtScore.Text = "Score: " + e; 
        }

        private void UpdateScore() { 
            score.UpdateScore(txtScore); 
        }

        private void MovePlayer() { 
            if (goleft && player.Left > 10) { 
                player.Left -= speed.playerSpeed; 
            } 
            if (goright && player.Left < 415) { 
                player.Left += speed.playerSpeed; 
            } 
        } 

        private void MoveRoad() { 
            roadTrack1.Top += speed.roadSpeed; 
            roadTrack2.Top += speed.roadSpeed; 
            if (roadTrack2.Top > 519) { 
                roadTrack2.Top = -519; 
            } 
            if (roadTrack1.Top > 519) { 
                roadTrack1.Top = -519; 
            } 
        } 

        private void MoveSun() { 
            sun.MoveSun(SUN1, SUN2, speed);

            if (player.Bounds.IntersectsWith(SUN1.Bounds)){ 
                sun.UpdateScore(sunScore);
                SUN1.Visible = false;
            }
            if (player.Bounds.IntersectsWith(SUN2.Bounds))
            {
                sun.UpdateScore(sunScore);
                SUN2.Visible = false;
            }
        } 

        private void CheckCollisions() { 
            if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds)) { 
                game.gameOver(); 
            } 
        } 

        private void UpdateAward() { 
            var endScore = score.CurrentScore; 
            if (endScore > 40 && endScore < 500) { 
                award.Image = Properties.Resources.bronze; 
            } 
            if (endScore > 500 && endScore < 2000) { 
                award.Image = Properties.Resources.silver; 
                speed.roadSpeed = 18; 
                speed.trafficSpeed = 20; 
            } 
            if (endScore > 2000) { 
                award.Image = Properties.Resources.gold; 
                speed.trafficSpeed = 25; 
                speed.roadSpeed = 23; 
            } 
        } 

        private void CheckGameOver() { 
            if (sun.getSunCount() == 100) { 
                game.gameOver(); 
            } 
        } 

        private void ResetGame(object sender, EventArgs e) { 
            game.ResetGame(); 
            speed.roadSpeed = 13; 
            speed.trafficSpeed = 16;
            
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
    }
}