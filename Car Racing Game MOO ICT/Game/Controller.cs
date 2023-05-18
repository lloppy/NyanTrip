using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT.Game
{
    public class Controller
    {
        Speed speed;
        Score score;
        private Game game;

        public void Update( Label txtScore, bool goright, bool goleft, PictureBox player, 
            PictureBox roadTrack1, PictureBox roadTrack2, PictureBox AI1, PictureBox AI2)

        {
            score.UpdateScore(txtScore);

            if (goleft == true && player.Left > 10)
            {
                player.Left -= speed.playerSpeed;
            }
            if (goright == true && player.Left < 415)
            {
                player.Left += speed.playerSpeed;
            }
            
           

            if (roadTrack2.Top > 519)
            {
                roadTrack2.Top = -519;
            }
            if (roadTrack1.Top > 519)
            {
                roadTrack1.Top = -519;
            }

          

            if (AI1.Top > 530)
            {
                changeAIcars(AI1);
            }

            if (AI2.Top > 530)
            {
                changeAIcars(AI2);
            }
        }
        
        private void changeAIcars(PictureBox tempCar)
        {
            var ai = new AI(tempCar);
        }
    }
}