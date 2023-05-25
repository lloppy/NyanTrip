using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RainbowHunter.Game.View;
using RainbowHunter.Properties;

namespace RainbowHunter.Game.Domain;

public class NyanCat
{
    private readonly Panel _panel;
    private readonly Random _random;
    private bool flag = false;
    private Sun sun = new Sun();
    public NyanCat(Panel panel, Random random)
    {
        _panel = panel;
        _random = random;
    }

    public  NyanCat(){}
    public void CreateNyanCat(PictureBox AI1, PictureBox AI2)
    {
        var counter = 0;
        var backColors = new List<Color>{Color.Yellow, Color.DarkOrange, Color.Crimson, Color.Transparent};
        AI1.Image = Resources.nyan_cat_right;
        AI2.Image = Resources.nyan_cat_right;
        AI1.Top = 60;
        AI1.Left = 60;
        
        var progressBar = new ProgressBar();
        
        AI1.Click += (sender, args) =>
        {
            _panel.BackColor = backColors[counter];
            counter++;
            sun.IncreaseSunFromCat();
        };
        AI2.Click += (sender, args) =>
        {
            _panel.BackColor = backColors[counter];
            counter++;
            sun.IncreaseSunFromCat();
        };
        
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
        timer.Interval = 50;
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
        timer.Interval = 50;
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