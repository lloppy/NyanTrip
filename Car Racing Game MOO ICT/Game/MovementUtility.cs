using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT.Game
{
    public class MovementUtility
    {
        private Speed speed;
        private PictureBox player;
        private PictureBox roadTrack1;
        private PictureBox roadTrack2;
        public PictureBox sun1;
        public PictureBox sun2;
        private bool goLeft;
        private bool goRight;

        public MovementUtility(Speed speed, PictureBox player, PictureBox roadTrack1, PictureBox roadTrack2, PictureBox sun1, PictureBox sun2)
        {
            this.speed = speed;
            this.player = player;
            this.roadTrack1 = roadTrack1;
            this.roadTrack2 = roadTrack2;
            this.sun1 = sun1;
            this.sun2 = sun2;
        }

        public void MovePlayer()
        {
         
            if (goLeft && player.Left > 10)
            {
                player.Left -= speed.playerSpeed;
            }
            if (goRight && player.Left < 415)
            {
                player.Left += speed.playerSpeed;
            }
        }

        public void MoveRoad()
        {
            roadTrack1.Top += speed.roadSpeed;
            roadTrack2.Top += speed.roadSpeed;
            if (roadTrack2.Top > 519)
            {
                roadTrack2.Top = -519;
            }
            if (roadTrack1.Top > 519)
            {
                roadTrack1.Top = -519;
            }
        }
        
        public void MoveSun(Sun sun) { 
            sun.MoveSun(sun1, sun2, speed);

            if (player.Bounds.IntersectsWith(sun1.Bounds))
            {
                sun.IncreaseSun();
                sun1.Visible = false;
            }
            if (player.Bounds.IntersectsWith(sun2.Bounds))
            {
                sun.IncreaseSun();
                sun2.Visible = false;
            }
        } 
        
        public void KeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = true;
            if (e.KeyCode == Keys.Right) goRight = true;
        }

        public void KeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = false;
            if (e.KeyCode == Keys.Right) goRight = false;
        }
    }
}
