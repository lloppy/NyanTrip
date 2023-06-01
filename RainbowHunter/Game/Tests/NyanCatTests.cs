using System;
using System.Windows.Forms;
using NUnit.Framework;
using RainbowHunter.Game.Domain;

namespace RainbowHunter.Game.Tests
{
    [TestFixture]
    public class NyanCatTests
    {
        [Test]
        public void CreateNyanCat_ShouldSetInitialPositionsAndImages()
        {
            var panel = new Panel();
            var random = new Random();
            var ai1 = new PictureBox();
            var ai2 = new PictureBox();
            var ai3 = new PictureBox();
            var ai4 = new PictureBox();

            var nyanCat = new NyanCat(panel, random);
            nyanCat.CreateNyanCat(ai1, ai2, ai3, ai4);

            Assert.AreEqual(ai1.Top, 0);
            Assert.AreEqual(ai1.Left, 0);
            Assert.AreEqual(ai2.Top, 50);
            Assert.AreEqual(ai2.Left, 50);
            Assert.AreEqual(ai3.Top, 1);
            Assert.AreEqual(ai3.Left, 40);
            Assert.AreEqual(ai4.Top, 176);
            Assert.AreEqual(ai4.Left, 150);

            Assert.IsNotNull(ai1.Image);
            Assert.IsNotNull(ai2.Image);
            Assert.IsNotNull(ai3.Image);
            Assert.IsNotNull(ai4.Image);
        }
    }
}