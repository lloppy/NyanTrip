using System;
using System.Drawing;
using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT.Game
{
    public class AI
    {
        private readonly Random _rand = new Random();
        private readonly Random _carPosition = new Random();

        public PictureBox Car { get; }

        public AI(PictureBox car)
        {
            Car = car;
            SetPicture();
            SetPosition();
        }
        public AI()
        {
         
        }
        
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
            AI.Top = carPosition.Next(200, 500) *-1;
            AI.Left = carPosition.Next(leftX, leftY);
            
        }


    private void SetPicture()
        {
            int carImageNumber = _rand.Next(1, 10);

            switch (carImageNumber)
            {
                case 1:
                    Car.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    Car.Image = Properties.Resources.carGreen;
                    break;
                case 3:
                    Car.Image = Properties.Resources.carGrey;
                    break;
                case 4:
                    Car.Image = Properties.Resources.carOrange;
                    break;
                case 5:
                    Car.Image = Properties.Resources.carPink;
                    break;
                case 6:
                    Car.Image = Properties.Resources.CarRed;
                    break;
                case 7:
                    Car.Image = Properties.Resources.carYellow;
                    break;
                case 8:
                    Car.Image = Properties.Resources.TruckBlue;
                    break;
                case 9:
                    Car.Image = Properties.Resources.TruckWhite;
                    break;
            }
        }
    }
}
