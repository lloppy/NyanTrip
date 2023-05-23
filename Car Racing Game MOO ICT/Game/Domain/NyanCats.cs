using System;
using System.Drawing;
using System.Windows.Forms;
using Car_Racing_Game_MOO_ICT.Game.View;

namespace Car_Racing_Game_MOO_ICT.Game.Domain;

public class NyanCat
{
    private readonly Panel _panel;
    private readonly Random _random;
    public NyanCat(TransparentPanel panel, Random random)
    {
        _panel = panel;
        _random = random;
    }

    public PictureBox CreateNyanCat(int x)
    { 
        var catPBox = new PictureBox();
        catPBox.Image = Properties.Resources.nyan_cat_left;
        catPBox.SizeMode = PictureBoxSizeMode.AutoSize;
        catPBox.Left =x;
        catPBox.BackColor = Color.Transparent; 
        catPBox.Top = _random.Next(1, 400);
        _panel.Controls.Add(catPBox);

        animateNyanCat(catPBox);
        return catPBox;
    }

    private void animateNyanCat(PictureBox pictureBox)
    {
        var timer = new Timer();
        var direction = 1;
        var step = 5;
        var maxHeight = _panel.Height - pictureBox.Height;
        timer.Interval = 50;
        timer.Tick += (sender, args) =>
        {
            pictureBox.Left += direction * step;
            if (pictureBox.Right >= _panel.Width || pictureBox.Left <= 0)
            {
                direction *= -1;
            }
            pictureBox.Top += step;
            if (pictureBox.Top >= maxHeight || pictureBox.Top <= 0)
            {
                step *= -1;
            }
        };
        timer.Start();
    }
}
