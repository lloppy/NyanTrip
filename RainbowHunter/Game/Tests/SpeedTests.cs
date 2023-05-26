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

           
            Assert.AreEqual(roadSpeed, speed.RoadSpeed);
            Assert.AreEqual(trafficSpeed, speed.TrafficSpeed);
            Assert.AreEqual(playerSpeed, speed.PlayerSpeed);
        }

        [Test]
        public void OnPause_SetsAllSpeedsToZero()
        {
            var speed = new Speed(50, 30, 80);
            speed.OnPause();

            Assert.AreEqual(0, speed.RoadSpeed);
            Assert.AreEqual(0, speed.TrafficSpeed);
            Assert.AreEqual(0, speed.PlayerSpeed);
        }

        [Test]
        public void OnRestart_SetsSpeedsToLastSpeed()
        {
            var previousSpeed = new Speed(50, 30, 80);
            var speed = new Speed(60, 40, 100);

            speed.OnRestart(previousSpeed);
            
            Assert.AreEqual(previousSpeed.RoadSpeed, speed.RoadSpeed);
            Assert.AreEqual(previousSpeed.TrafficSpeed, speed.TrafficSpeed);
            Assert.AreEqual(previousSpeed.PlayerSpeed, speed.PlayerSpeed);
        }
    }
}
