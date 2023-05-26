using System.Windows.Forms;
using NUnit.Framework;
using RainbowHunter.Game.Domain;

namespace RainbowHunter.Game.Tests
{
    public class MushroomsTests
    {
        [Test]
        public void CreateNewMushroomPosition_SetsTopAndLeftForMushroom()
        {
            var pictureBox = new PictureBox { Tag = "mushroomLeft" };
            var mushrooms = new Mushrooms();
            
            mushrooms.CreateNewMushroomPosition(pictureBox);
            
            Assert.That(pictureBox.Top, Is.EqualTo(-250));
            Assert.That(pictureBox.Left, Is.InRange(5, 135));
        }
        
        [Test]
        public void SetPicture_SetsRandomImageForMushroom()
        {
            var pictureBox = new PictureBox();
            var mushrooms = new Mushrooms(pictureBox);
            
            mushrooms.SetPicture();
            Assert.That(pictureBox.Image, Is.Not.Null);
        }
    }
}