using NUnit.Framework;
using Car_Racing_Game_MOO_ICT.Game.Domain;

namespace Car_Racing_Game_MOO_ICT.Tests
{
    public class SpeedTests
    {
        [Test]
        public void SpeedConstructor_SetsProperties()
        {
            var roadSpeed = 10;
            var trafficSpeed = 20;
            var playerSpeed = 30;
            
            var speed = new Speed(roadSpeed, trafficSpeed, playerSpeed);
            
            Assert.AreEqual(speed.roadSpeed, roadSpeed);
            Assert.AreEqual(speed.trafficSpeed, trafficSpeed);
            Assert.AreEqual(speed.playerSpeed, playerSpeed);
        }

        [Test]
        public void OnPause_SetsSpeedsToZero()
        {
            var speed = new Speed(10, 20, 30);

            speed.onPause();

            Assert.AreEqual(speed.roadSpeed, 0);
            Assert.AreEqual(speed.trafficSpeed, 0);
            Assert.AreEqual(speed.playerSpeed, 0);
        }

        [Test]
        public void OnRestart_SetsSpeedsToLastSpeed()
        {
            var lastSpeed = new Speed(10, 20, 30);
            var speed = new Speed(0, 0, 0);

            speed.onRestart(lastSpeed);

            Assert.AreEqual(speed.roadSpeed, lastSpeed.roadSpeed);
            Assert.AreEqual(speed.trafficSpeed, lastSpeed.trafficSpeed);
            Assert.AreEqual(speed.playerSpeed, lastSpeed.playerSpeed);
        }
    }
}