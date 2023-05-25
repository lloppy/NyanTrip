using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RainbowHunter.Game.Domain;
using RainbowHunter.Game.View;
using RainbowHunter.Properties;

namespace RainbowHunter.Game.Controller
{
    public class Game
    {
        private GameStage stage = GameStage.NotStarted;
        private PictureBox Player { get; }
        private Timer GameTimer { get; }
        private Score score = new Score(); 
        private Sun sun = new Sun(); 
        private Speed Speed { get; } = new Speed(12, 15, 12);
        public event Action<GameStage> StageChanged;

        public Game(Timer gameTimer, PictureBox player, Speed speed)
        {
            GameTimer = gameTimer;
            Player = player;
            Speed = speed;
        }
        
        public Game(){}

        public void UpdateAward()
        {
            var endScore = score.CurrentScore;
            Speed.roadSpeed = endScore > 200 ? 18 : endScore > 900 ? 23 : 13;
            Speed.trafficSpeed = endScore > 200 ? 20 : endScore > 900 ? 25 : 16;
        }
        
        private void ChangeStage(GameStage stage)
        {
            this.stage = stage;
            StageChanged?.Invoke(stage);
        }
        
       public void gameOver()
        {
            ChangeStage(GameStage.Finished);
        }

        public void ResetGame()
        {
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
