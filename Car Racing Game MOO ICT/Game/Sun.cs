using System;
using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT.Game;

public class Sun
{
    private int _sun;
    private readonly Random _sunPosition = new Random();
    private PictureBox SunPictureBox { get; }

    public Sun()
    {
        _sun = 0;
    }
    
    public Sun(PictureBox sun)
    {
        SunPictureBox = sun;
        SetPicture();
        SetPosition();
    }
    
    public int getSunCount()
    {
        return _sun ;
    }
    public void UpdateScore(Label label)
    {
        _sun++;
        label.Text = "Sun: " + _sun;
    }
    
    private void SetPosition()
    {
        SunPictureBox.Top = _sunPosition.Next(100, 400) * -1;

        if ((string)SunPictureBox.Tag == "carLeft")
        {
            SunPictureBox.Left = _sunPosition.Next(5, 200);
        }
        else if ((string)SunPictureBox.Tag == "carRight")
        {
            SunPictureBox.Left = _sunPosition.Next(245, 422);
        }
    }

    private void SetPicture()
    {
        SunPictureBox.Image = Properties.Resources.sun;
    }
}