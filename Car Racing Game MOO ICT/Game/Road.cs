using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT.Game
{
    public class Road
    {
        private int speed;
        private PictureBox track1;
        private PictureBox track2;

        public Road(int roadSpeed, int trafficSpeed)
        {
            speed = roadSpeed;
            track1 = new PictureBox();
            track2 = new PictureBox();
            // Initialize track1 and track2 picture boxes here
        }

        public void Move()
        {
            track1.Top += speed;
            track2.Top += speed;

            if (track2.Top > 519)
            {
                track2.Top = -519;
            }

            if (track1.Top > 519)
            {
                track1.Top = -519;
            }
        }
    }

}