using System;
using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT.Game.Domain
{
    public class AI
    {
        private readonly Random _rand = new Random();
        private readonly Random _carPosition = new Random();

        private PictureBox Car { get; }

        public AI(PictureBox car)
        {
            Car = car;
            SetPicture();
            SetPosition();
        }
        
        public AI(){}

        private void SetPosition()
        {
            Car.Top = _carPosition.Next(100, 400) * -1;

            if ((string)Car.Tag == "carLeft")
            {
                Car.Left = _carPosition.Next(5, 200);
            }
            else if ((string)Car.Tag == "carRight")
            {
                Car.Left = _carPosition.Next(245, 422);
            }
        }

        public void ResetPosition(PictureBox AI, Random carPosition, int leftX, int leftY)
        {
            AI.Top = carPosition.Next(200, 500) * -1;
            AI.Left = carPosition.Next(leftX, leftY);
        }


        private void SetPicture()
        {
            var carImageNumber = _rand.Next(1, 9);

            Car.Image = carImageNumber switch
            {
                1 => Properties.Resources.TruckWhite,
                2 => Properties.Resources.carGreen,
                3 => Properties.Resources.carGrey,
                4 => Properties.Resources.carOrange,
                5 => Properties.Resources.carPink,
                6 => Properties.Resources.CarRed,
                7 => Properties.Resources.carYellow,
                8 => Properties.Resources.TruckBlue,
                _ => Car.Image
            };
        }

        public void MoveTraffic(PictureBox AI1, PictureBox AI2, Speed speed)
        {
            AI1.Top += speed.trafficSpeed;
            AI2.Top += speed.trafficSpeed;
            if (AI1.Top > 530)
            {
                ChangeAICars(AI1);
            }
            if (AI2.Top > 530)
            {
                ChangeAICars(AI2);
            }
        }
        
        private void ChangeAICars(PictureBox tempCar)
        {
            var ai = new AI(tempCar);
        }
    }
}
