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

        if ((string)SunPictureBox.Tag == "sunLeft")
        {
            SunPictureBox.Left = _sunPosition.Next(5, 200);
        }
        else if ((string)SunPictureBox.Tag == "sunRight")
        {
            SunPictureBox.Left = _sunPosition.Next(245, 422);
        }
    }
    
    public void ResetSunScore()
    {
        _sun = -1;
    }

    private void SetPicture()
    {
        SunPictureBox.Image = Properties.Resources.sun;
    }

    public void MoveSun(PictureBox SUN1, PictureBox SUN2, Speed speed)
    {
        SUN2.Visible = true;
        SUN1.Visible = true;
        
        SUN1.Top += speed.trafficSpeed;
        SUN2.Top += speed.trafficSpeed;
        
        if (SUN1.Top > 530)
        {
            ChangeAISuns(SUN1);
        }
        if (SUN2.Top > 530)
        {
            ChangeAISuns(SUN2);
        }
    }
    
    private void ChangeAISuns(PictureBox tempSun)
    {
        var ai = new Sun(tempSun);
    }
}