using System;
using System.Windows.Forms;
using Car_Racing_Game_MOO_ICT.Game.Controller;
using Car_Racing_Game_MOO_ICT.Game.Domain;

namespace Car_Racing_Game_MOO_ICT.Game.View {
    public partial class Form1 : Form
    {
        private Speed speed;
        private Score score;
        private Sun sun;
        private Mushrooms mushrooms;

        private Game.Controller.Game game;
        private MovementUtility movementUtility;

        Random position = new Random();

        public Form1()
        {
            InitializeComponent();
            speed = new Speed(12, 15, 12);
            score = new Score();
            sun = new Sun();
            mushrooms = new Mushrooms();
            score.ScoreUpdated += (sender, e) => txtScore.Text = "Score: " + e;
            sun.SunScoreUpdated += (sender, e) => sunScore.Text = "Sun: " + e;

            KeyDown += (sender, e) => movementUtility.KeyDown(e);
            KeyUp += (sender, e) => movementUtility.KeyUp(e);

            movementUtility = new MovementUtility(speed, player, roadTrack1, roadTrack2, SUN1, SUN2);
            game = new Game.Controller.Game(gameTimer, explosion, player, award, btnStart, speed);
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            score.UpdateScore();
            sun.UpdateSunScore();

            movementUtility.MovePlayer();
            movementUtility.MoveRoad();
            mushrooms.MoveTraffic(AI1, AI2, speed);
            movementUtility.MoveSun(sun);
            game.GameOver(AI1, AI2);
            game.UpdateAward();
        }
        
        private void ResetGame(object sender, EventArgs e)
        {
            game.ResetGame();
            game.SetGameSettings(AI1, AI2, SUN1, SUN2, position);
            
            gameTimer.Start();
        }
    }
}