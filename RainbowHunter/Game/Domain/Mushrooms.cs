using System;
using System.Windows.Forms;

namespace RainbowHunter.Game.Domain
{
    public class Mushrooms
    {
        private readonly Random _rand = new Random();
        private readonly Random _mushroomPosition = new Random();

        private PictureBox Mushroom { get; }

        public Mushrooms(PictureBox mushroom)
        {
            Mushroom = mushroom;
            SetPicture();
            SetPosition();
        }
        
        public Mushrooms(){}

        private void SetPosition()
        {
            Mushroom.Top = _mushroomPosition.Next(100, 400) * -1;

            if ((string)Mushroom.Tag == "mushroomLeft")
            {
                Mushroom.Left = _mushroomPosition.Next(5, 170);
            }
            else if ((string)Mushroom.Tag == "mushroomRight")
            {
                Mushroom.Left = _mushroomPosition.Next(275, 422);
            }
        }
        
        public void CreateNewMushroomPosition(PictureBox mushroom)
        {
            mushroom.Top = -250;
            if ((string)mushroom.Tag == "mushroomLeft")
            {
                mushroom.Left = _mushroomPosition.Next(5, 135);
            }
            else if ((string)mushroom.Tag == "mushroomRight")
            {
                mushroom.Left = _mushroomPosition.Next(230, 360);
            }        
        }

        public void SetPicture()
        {
            var mushroomImageNumber = _rand.Next(1, 8);

            Mushroom.Image = mushroomImageNumber switch
            {
                1 => Properties.Resources.mushroomWhite,
                2 => Properties.Resources.mushroomGreen,
                3 => Properties.Resources.mushroomGrey,
                4 => Properties.Resources.mushroomOrange,
                5 => Properties.Resources.mushroomPink,
                6 => Properties.Resources.mushroomRed,
                7 => Properties.Resources.mushroomYellow,
                _ => Mushroom.Image
            };
        }

        public void MoveTraffic(PictureBox AI1, PictureBox AI2, Speed speed)
        {
            AI1.Top += speed.trafficSpeed;
            AI2.Top += speed.trafficSpeed;
            
            if (AI1.Top > 530) ChangeAIMushrooms(AI1);
            if (AI2.Top > 530) ChangeAIMushrooms(AI2);
        }
        
        private void ChangeAIMushrooms(PictureBox tempMushroom)
        {
            var ai = new Mushrooms(tempMushroom);
        }
    }
}
