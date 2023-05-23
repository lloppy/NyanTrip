using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Car_Racing_Game_MOO_ICT.Game.Domain;

namespace Car_Racing_Game_MOO_ICT.Tests
{
    public class SunTests
    {
        private PictureBox _sunPictureBox;
        private Sun _sun;

        [SetUp]
        public void SetUp()
        {
            _sunPictureBox = new PictureBox();
            _sun = new Sun(_sunPictureBox);
        }

        [Test]
        public void GetSunCount_Initially_ReturnsZero()
        {
            int result = _sun.getSunCount();

            Assert.AreEqual(0, result);
        }

        [Test]
        public void IncreaseSun_IncrementsSunCountByOne()
        {
            _sun.IncreaseSun();

            Assert.AreEqual(1, _sun.getSunCount());
        }

        [Test]
        public void ResetSunScore_SetsSunCountToZero()
        {
            _sun.IncreaseSun();
            _sun.ResetSunScore();

            Assert.AreEqual(0, _sun.getSunCount());
        }

        [Test]
        public void MoveSun_ChangesTopOfPictureBoxes()
        {
            var sun1 = new PictureBox { Top = 200 };
            var sun2 = new PictureBox { Top = 300 };
            var speed = new Speed(12, 15, 12);

            _sun.MoveSun(sun1, sun2, speed);

            Assert.AreEqual(215, sun1.Top);
            Assert.AreEqual(315, sun2.Top);

            _sun.MoveSun(sun1, sun2, speed);

            Assert.AreEqual(230, sun1.Top);
            Assert.AreEqual(330, sun2.Top);
        }   
        
        [Test]
        public void StopMoveSun_SetsTopToZeroAndHidesPictureBox()
        {
            var sun = new PictureBox { Top = 100, Visible = true };
            var speed = new Speed(12, 15, 12);
            
            Assert.AreEqual(0, sun.Top);
            Assert.IsFalse(sun.Visible);
        }
    }
}