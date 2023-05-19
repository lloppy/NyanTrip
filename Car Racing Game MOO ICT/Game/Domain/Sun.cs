using System;
using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT.Game.Domain;

public class Sun
{    
    private static int _sun;
    public event EventHandler<int> SunScoreUpdated;
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

    public void IncreaseSun()
    {
        _sun++;
    }

    private int CurrentSunScore
    {
        get => _sun;
        set => _sun = value;
    }
    
    public void UpdateSunScore()
    {
        SunScoreUpdated?.Invoke(null, CurrentSunScore);
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
        _sun = 0;
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
    
    
    public void StopMoveSun(PictureBox sun, Speed speed)
    {
        sun.Top = 0;
        sun.Visible = false;
    }

    private void ChangeAISuns(PictureBox tempSun)
    {
        var ai = new Sun(tempSun);
    }
}