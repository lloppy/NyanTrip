using System.Windows.Forms;
using NUnit.Framework;
using RainbowHunter.Game.Controller;
using RainbowHunter.Game.Domain;

namespace RainbowHunter.Game.Tests
{
    [TestFixture]
    public class MovementUtilityTests
    {
        private MovementUtility movementUtility;

        [SetUp]
        public void SetUp()
        {
            Speed speed = new Speed(5, 10 , 10);
            PictureBox player = new PictureBox();
            PictureBox roadTrack1 = new PictureBox();
            PictureBox roadTrack2 = new PictureBox();
            PictureBox sun1 = new PictureBox();
            PictureBox sun2 = new PictureBox();
            PictureBox ai1 = new PictureBox();
            PictureBox ai2 = new PictureBox();

            movementUtility = new MovementUtility(speed, player, roadTrack1, roadTrack2, sun1, sun2, ai1, ai2);
        }

        [Test]
        public void MovePlayer_GivenGoLeftAndGreaterThan10_ShouldDecrementPlayerLeft()
        {
            movementUtility.goLeft = true;
            movementUtility.player.Left = 20;

            movementUtility.MovePlayer();
            
            Assert.AreEqual(movementUtility.player.Left, 10);
        }

        [Test]
        public void MovePlayer_GivenGoRightAndLessThan415_ShouldIncrementPlayerLeft()
        {
            movementUtility.goRight = true;
            movementUtility.player.Left = 400;

            movementUtility.MovePlayer();

            Assert.AreEqual(movementUtility.player.Left, 410);
        }
    }
}