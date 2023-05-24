using System;
using System.Drawing;
using System.Windows.Forms;
using Car_Racing_Game_MOO_ICT.Game.View;

namespace Car_Racing_Game_MOO_ICT.Game.Domain
{
    public class NyanCat
    {
        private readonly Panel _panel;
        private readonly Random _random;
        private bool goingRight = true;
        private int jumpCount = 0;

        public NyanCat(TransparentPanel panel, Random random)
        {
            _panel = panel;
            _random = random;
        }

        public PictureBox CreateNyanCat(int x)
        {
            var catPBox = new PictureBox();
            setSettings(catPBox, Properties.Resources.nyan_cat_right, x);
            animateNyanCat(catPBox, Properties.Resources.nyan_cat_left, Properties.Resources.nyan_cat_right);
            return catPBox;
        }

        private void setSettings(PictureBox catPBox, Bitmap nyanCatLR, int x)
        {
            catPBox.Image = nyanCatLR;
            catPBox.Top = x * 2;
            catPBox.SizeMode = PictureBoxSizeMode.AutoSize;
            catPBox.Left = _random.Next(x, x + 80);
            catPBox.BackColor = Color.Transparent;
            _panel.Controls.Add(catPBox);
        }

        private void animateNyanCat(PictureBox pictureBox, Bitmap nyanCatLeft, Bitmap nyanCatRight)
        {
            var timer = new Timer();
            timer.Interval = 20;
            timer.Tick += (sender, e) =>
            {
                var location = pictureBox.Location;
                if (goingRight) location.X += 1;
                else location.X -= 1;

                var form1 = new Form1();
                if (location.X + pictureBox.Width > form1.ClientSize.Width)
                {
                    goingRight = false;
                    location.X = form1.ClientSize.Width - pictureBox.Width;
                }
                if (location.X < 0)
                {
                    goingRight = true;
                    location.X = 0;
                    //pictureBox.Image = nyanCatRight;
                }
                pictureBox.Location = location;
            };
            timer.Start();
        }
    }
}
