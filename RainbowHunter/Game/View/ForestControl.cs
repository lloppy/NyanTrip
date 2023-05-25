using System;
using System.Drawing;
using System.Windows.Forms;
using RainbowHunter.Game.Controller;
using RainbowHunter.Game.Domain;
using RainbowHunter.Properties;

namespace RainbowHunter.Game.View
{
    public partial class ForestControl : UserControl
    {
        private Speed speed;
        private Score score;
        private Sun sun;
        private Mushrooms mushrooms;
        private MovementUtility movementUtility;
        private GameScenes _gameScenes;
        private Controller.Game _game;

        Random position = new Random();
        
        public ForestControl()
        {
            InitializeComponent();

            speed = new Speed(12, 15, 12);
            score = new Score();
            sun = new Sun();
            mushrooms = new Mushrooms(); 
            score.ScoreUpdated += (sender, e) => txtScore.Text = "Score: " + e;
            sun.SunScoreUpdated += (sender, e) => sunScore.Text = "Sun: " + e;
            
            movementUtility = new MovementUtility(speed, player, roadTrack1, roadTrack2, SUN1, SUN2, AI1, AI2);
            _game = new Controller.Game(gameTimer, player, speed);
        }

        
        private void GameTimerEvent(object sender, EventArgs e)
        {
            score.UpdateScore();
            sun.UpdateSunScore();

            movementUtility.MovePlayer();
            movementUtility.MoveRoad();
            movementUtility.MoveMushroom(mushrooms);
            movementUtility.MoveSun(sun);
            
            StartNewGame();
            _game.UpdateAward();
        }

        private void ResetGame(object sender, EventArgs e)
        {
            _game.ResetGame();
            _game.SetGameSettings(AI1, AI2, SUN1, SUN2, position);
            gameTimer.Start();
        }
        
        private void StartNewGame()
        {
            if (sun.getSunCount() >= 41)
            {
                gameTimer.Stop();
                
                AI1.Image = Resources.nyan_cat_right;
                AI2.Image = Resources.nyan_cat_left;
                AI1.Top = 60;
                AI1.Left = 60;
                
                AI2.Top = 260;
                AI2.Left = 300;
                
                panel1.BackColor = Color.CornflowerBlue;
                roadTrack1.Visible = false;
                roadTrack2.Visible = false;
                SUN1.Visible = false;
                SUN2.Visible = false;
                
                //this.ParentForm.Close();

                //_gameScenes.StartNyanGame();
            }
        }
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    movementUtility.goLeft = true;
                    movementUtility.goRight = false;
                    break;
                case Keys.Right:
                    movementUtility.goRight = true;
                    movementUtility.goLeft = false;
                    break;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}