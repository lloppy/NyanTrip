using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RainbowHunter.Game.Domain.Interfaces;
using RainbowHunter.Properties;

namespace RainbowHunter.Game.Domain;

public class NyanCat: INyanCat
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

    public void CreateNyanCat(PictureBox AI1, PictureBox AI2, PictureBox AI3, PictureBox AI4)
    {
        var counter = 0;
        var backColors = new List<Color>{Color.LightSkyBlue, Color.LimeGreen, Color.Gold, Color.Goldenrod, Color.DarkOrange, Color.Coral,  Color.Crimson, Color.Transparent};
        AI1.Image = Resources.nyan_cat_right;
        AI2.Image = Resources.nyan_cat_right;
        AI3.Image = Resources.nyan_cat_right;
        AI4.Image = Resources.nyan_cat_right;

        var size = 120;
        AI1.Size = new Size(size, size);
        AI2.Size = new Size(size, size);
        AI3.Size = new Size(size, size);
        AI4.Size = new Size(size, size);

        AI1.SizeMode = PictureBoxSizeMode.Zoom;
        AI2.SizeMode = PictureBoxSizeMode.Zoom;
        AI3.SizeMode = PictureBoxSizeMode.Zoom;
        AI4.SizeMode = PictureBoxSizeMode.Zoom;

        AI1.Top = 0;
        AI1.Left = 0;
        AI2.Top = 50;
        AI2.Left = 50;
        AI3.Top = 1;
        AI3.Left = 40;
        AI4.Top = 176;
        AI4.Left = 150;

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

        AI3.Click += (sender, args) =>
        {
            _panel.BackColor = backColors[counter];
            counter++;
            sun.IncreaseSunFromCat();
        };

        AI4.Click += (sender, args) =>
        {
            _panel.BackColor = backColors[counter];
            counter++;
            sun.IncreaseSunFromCat();
        };

        animateNyanCat(AI1);
        animateNyanCat2(AI2);
        animateNyanCat3(AI3);
        animateNyanCat4(AI4);
    }

    private void animateNyanCat(PictureBox pictureBox)
    {
        var timer = new Timer();
        setAnimate(timer, pictureBox);
        timer.Start();
    }

    private void animateNyanCat2(PictureBox pictureBox)
    {
        var timer = new Timer();
        setAnimate(timer, pictureBox);
        timer.Start();
    }

    private void animateNyanCat3(PictureBox pictureBox)
    {
        var timer = new Timer();
        setAnimate(timer, pictureBox);
        timer.Start();
    }

    private void animateNyanCat4(PictureBox pictureBox)
    {
        var timer = new Timer();
        setAnimate(timer, pictureBox);
        timer.Start();
    }

    private void setAnimate(Timer timer, PictureBox pictureBox)
    {
        var direction = -1;
        var step = 5;
        var maxHeight = _panel.Height - pictureBox.Height + 70;
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
            if (pictureBox.Top + 40 >= maxHeight || pictureBox.Top + 40 <= 0)
            {
                step *= -1;
            }
        };
    }
}