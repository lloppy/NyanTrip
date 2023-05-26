using NUnit.Framework;
using RainbowHunter.Game.Domain;

namespace RainbowHunter.Game.Tests
{
    [TestFixture]
    public class SpeedTests
    {
        [Test]
        public void Constructor_SetsProperties()
        {
            int roadSpeed = 50, trafficSpeed = 30, playerSpeed = 80;
            var speed = new Speed(roadSpeed, trafficSpeed, playerSpeed);

           
            Assert.AreEqual(roadSpeed, speed.roadSpeed);
            Assert.AreEqual(trafficSpeed, speed.trafficSpeed);
            Assert.AreEqual(playerSpeed, speed.playerSpeed);
        }

        [Test]
        public void OnPause_SetsAllSpeedsToZero()
        {
            var speed = new Speed(50, 30, 80);
            speed.onPause();

            Assert.AreEqual(0, speed.roadSpeed);
            Assert.AreEqual(0, speed.trafficSpeed);
            Assert.AreEqual(0, speed.playerSpeed);
        }

        [Test]
        public void OnRestart_SetsSpeedsToLastSpeed()
        {
            var previousSpeed = new Speed(50, 30, 80);
            var speed = new Speed(60, 40, 100);

            speed.onRestart(previousSpeed);
            
            Assert.AreEqual(previousSpeed.roadSpeed, speed.roadSpeed);
            Assert.AreEqual(previousSpeed.trafficSpeed, speed.trafficSpeed);
            Assert.AreEqual(previousSpeed.playerSpeed, speed.playerSpeed);
        }
    }
}
