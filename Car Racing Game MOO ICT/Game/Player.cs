using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT.Game
{
   public class Player
   {
      private int speed;
      private PictureBox car;

      public Player(int playerSpeed, int startPositionX)
      {
         speed = playerSpeed;
         car = new PictureBox();
         // Initialize car picture box here
         car.Left = startPositionX;
      }

      public void MoveLeft()
      {
         if (car.Left > 10)
         {
            car.Left -= speed;
         }
      }

      public void MoveRight()
      {
         if (car.Left < 415)
         {
            car.Left += speed;
         }
      }

      public void Update()
      {
         // Update position of car picture box here
      }

      public bool IsCollidingWith(AI aiCar)
      {
         return true;
         // Check if player car is colliding with given AI car here
      }
   }

}