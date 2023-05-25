using System;
using System.Drawing;
using System.Windows.Forms;
using RainbowHunter.Properties;

namespace RainbowHunter.Game.Domain;

public class NyanCat
{
    private readonly Panel _panel;
    private readonly Random _random;
    private bool flag = false;
    public NyanCat(Panel panel, Random random)
    {
        _panel = panel;
        _random = random;
    }

    public void CreateNyanCat(PictureBox AI1, PictureBox AI2)
    {
        AI1.Image = Resources.nyan_cat_right;
        AI2.Image = Resources.nyan_cat_right;
        AI1.Top = 60;
        AI1.Left = 60;

        
        AI2.Top = 260;
        AI2.Left = 260;
        
        animateNyanCat(AI1);
        animateNyanCat2(AI2);
    }

    private void animateNyanCat(PictureBox pictureBox)
    {
        var timer = new Timer();
        var direction = 1;
        var step = 5;
        var maxHeight = _panel.Height - pictureBox.Height;
        timer.Interval = 30;
        timer.Tick += (sender, args) =>
        {
            pictureBox.Left += direction * step;

            if (pictureBox.Right >= _panel.Width)
            {
                pictureBox.Image = Resources.nyan_cat_left ;
                direction *= -1;
            }
            else if (pictureBox.Left <= 0)
            {
                pictureBox.Image = Resources.nyan_cat_right;
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
    
    private void animateNyanCat2(PictureBox pictureBox)
    {
        var timer = new Timer();
        var direction = 1;
        var step = 5;
        var maxHeight = _panel.Height - pictureBox.Height;
        timer.Interval = 30;
        timer.Tick += (sender, args) =>
        {
            pictureBox.Left += direction * step;

            if (pictureBox.Right >= _panel.Width)
            {
                pictureBox.Image = Resources.nyan_cat_left ;
                direction *= -1;
            }
            else if (pictureBox.Left <= 0)
            {
                pictureBox.Image = Resources.nyan_cat_right;
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