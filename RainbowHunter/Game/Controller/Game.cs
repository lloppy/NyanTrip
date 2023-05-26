using RainbowHunter.Game.Domain;
using RainbowHunter.Game.View;
using RainbowHunter.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using RainbowHunter.Game.Controller.Interfaces;

namespace RainbowHunter.Game.Controller
{
    public class Game : IGame
    {
        private GameStage stage = GameStage.NotStarted;
        public PictureBox Player { get; set; }
        public Timer GameTimer { get; set; }
        private Score score = new Score();
        private Sun sun = new Sun();
        public Speed Speed { get; } = new Speed(12, 15, 12);

        public Game(Timer gameTimer, PictureBox player, Speed speed)
        {
            GameTimer = gameTimer;
            Player = player;
            Speed = speed;
        }

        public void UpdateAward()
        {
            var endScore = score.CurrentScore;
            Speed.RoadSpeed = endScore > 200 ? 18 : endScore > 900 ? 23 : 13;
            Speed.TrafficSpeed = endScore > 200 ? 20 : endScore > 900 ? 25 : 16;
        }
        
        public void ResetGame()
        {
            score.ResetScore();
            sun.ResetSunScore();
        }
        
        public void SetGameSettings(PictureBox ai1, PictureBox ai2, PictureBox sun1, PictureBox sun2, Random position)
        {
            Speed.RoadSpeed = 13;
            Speed.TrafficSpeed = 16;

            ai1.Top = position.Next(200, 500) * -1;
            ai1.Left = position.Next(5, 200);
            ai2.Top = position.Next(200, 500) * -1;
            ai2.Left = position.Next(245, 422);

            sun1.Top = position.Next(200, 500) * -1;
            sun1.Left = position.Next(5, 200);
            sun2.Top = position.Next(200, 500) * -1;
            sun2.Left = position.Next(245, 422);
        }
    }
}