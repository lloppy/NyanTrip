using System;
using System.Windows.Forms;
using NUnit.Framework;
using RainbowHunter.Game.Domain;

namespace RainbowHunter.Game.Tests
{
    [TestFixture]
    public class GameTests
    {
        private Timer gameTimer;
        private PictureBox player;
        private Speed speed;

        [SetUp]
        public void Setup()
        {
            gameTimer = new Timer();
            player = new PictureBox();
            speed = new Speed(12, 15, 12);
        }

        [Test]
        public void Game_CreatedWithCorrectParameters()
        {
            var game = new Game.Controller.Game(gameTimer, player, speed);

            Assert.AreEqual(gameTimer, game.GameTimer);
            Assert.AreEqual(player, game.Player);
            Assert.AreEqual(speed, game.Speed);
        }

        [Test]
        public void UpdateAward_ChangesSpeedAccordingToCurrentScore()
        {
            var game = new Game.Controller.Game(gameTimer, player, speed);
            game.UpdateAward();

            game.Speed.roadSpeed = 201;
            game.UpdateAward();

            Assert.AreEqual(13,game.Speed.roadSpeed);
            Assert.AreEqual(16, game.Speed.trafficSpeed);
        }
        
        [Test]
        public void SetGameSettings_SetsCorrectInitialPositions()
        {
            var ai1 = new PictureBox();
            var ai2 = new PictureBox();
            var sun1 = new PictureBox();
            var sun2 = new PictureBox();
            var position = new Random();
            var game = new Game.Controller.Game(gameTimer, player, speed);

            game.SetGameSettings(ai1, ai2, sun1, sun2, position);

            Assert.IsTrue(ai1.Top < 0 && ai1.Top >= -500);
            Assert.IsTrue(ai1.Left >= 5 && ai1.Left <= 200);
            Assert.IsTrue(ai2.Top < 0 && ai2.Top >= -500);
            Assert.IsTrue(ai2.Left >= 245 && ai2.Left <= 422);
            Assert.IsTrue(sun1.Top < 0 && sun1.Top >= -500);
            Assert.IsTrue(sun1.Left >= 5 && sun1.Left <= 200);
            Assert.IsTrue(sun2.Top < 0 && sun2.Top >= -500);
            Assert.IsTrue(sun2.Left >= 245 && sun2.Left <= 422);
        }
    }
}
