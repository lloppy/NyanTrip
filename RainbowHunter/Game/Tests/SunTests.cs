using System.Windows.Forms;
using NUnit.Framework;
using RainbowHunter.Game.Domain;

namespace RainbowHunter.Game.Tests
{
    [TestFixture]
    public class SunTests
    {
        private Sun _sun;

        [SetUp]
        public void SetUp()
        {
            var pictureBox = new PictureBox();
            _sun = new Sun();
        }

        [Test]
        public void GetSunCount_ReturnsZero_WhenNoSunCollected()
        {
            var sunCount = _sun.GetSunCount();
            Assert.AreEqual(0, sunCount);
        }

        [Test]
        public void IncreaseSun_IncrementsSunCountByOne()
        {
            var initialSunCount = _sun.GetSunCount();
            _sun.IncreaseSun();
            var newSunCount = _sun.GetSunCount();
            Assert.AreEqual(initialSunCount + 1, newSunCount);
        }

        [Test]
        public void IncreaseSunFromMushroom_IncrementsSunCountByFive()
        {
            var initialSunCount = _sun.GetSunCount();
            _sun.IncreaseSunFromMushroom();
            var newSunCount = _sun.GetSunCount();
            Assert.AreEqual(initialSunCount + 5, newSunCount);
        }

        [Test]
        public void IncreaseSunFromCat_IncrementsSunCountByFifty()
        {
            var initialSunCount = _sun.GetSunCount();
            _sun.IncreaseSunFromCat();
            var newSunCount = _sun.GetSunCount();
            Assert.AreEqual(initialSunCount + 50, newSunCount);
        }

        [Test]
        public void UpdateSunScore_RaisesSunScoreUpdatedEvent()
        {
            var eventRaised = false;
            _sun.SunScoreUpdated += (sender, sunScore) => { eventRaised = true; };
            _sun.UpdateSunScore();
            Assert.IsTrue(eventRaised);
        }

        [Test]
        public void UpdateSunScore_UpdatesProgressBarWithValue()
        {
            _sun.ProgressBar.Value = 0;
            _sun.UpdateSunScore(10);
            Assert.AreEqual(10, _sun.ProgressBar.Value);
        }

        [Test]
        public void CreateNewSunPosition_SetsPicturePositionAccordingToTag()
        {
            var pictureBoxLeft = new PictureBox() { Tag = "sunLeft" };
            var pictureBoxRight = new PictureBox() { Tag = "sunRight" };
            _sun.CreateNewSunPosition(pictureBoxLeft);
            _sun.CreateNewSunPosition(pictureBoxRight);
            Assert.GreaterOrEqual(pictureBoxLeft.Top, -250);
            Assert.LessOrEqual(pictureBoxLeft.Top, 0);
            Assert.GreaterOrEqual(pictureBoxLeft.Left, 5);
            Assert.LessOrEqual(pictureBoxLeft.Left, 135);
            Assert.GreaterOrEqual(pictureBoxRight.Top, -250);
            Assert.LessOrEqual(pictureBoxRight.Top, 0);
            Assert.GreaterOrEqual(pictureBoxRight.Left, 230);
            Assert.LessOrEqual(pictureBoxRight.Left, 360);
        }
    }
}
