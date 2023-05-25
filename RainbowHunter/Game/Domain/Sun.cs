using System;
using System.Windows.Forms;

namespace RainbowHunter.Game.Domain;

public class Sun
{    
    private static int _sun;
    public event EventHandler<int> SunScoreUpdated;
    private readonly Random _sunPosition = new Random();
    public ProgressBar ProgressBar = new ProgressBar();
    private PictureBox SunPictureBox { get; }

    public Sun() => _sun = 0;

    private Sun(PictureBox sun)
    {
        SunPictureBox = sun;
        SetPicture();
        SetPosition();
    }
    
    public void ResetSunScore() => _sun = 0;
    
    public int GetSunCount() => _sun;

    public void IncreaseSun() => _sun++;
    
    public void IncreaseSunFromMushroom() => _sun += 5;
    
    public void IncreaseSunFromCat() => _sun += 50;
    
    private int CurrentSunScore
    {
        get => _sun;
        set => _sun = value;
    }
    
    public void UpdateSunScore()
    {
        SunScoreUpdated?.Invoke(null, CurrentSunScore);
        ProgressBar.Value = _sun;
    }
    
    public void UpdateSunScore(int startValue)
    {
        SunScoreUpdated?.Invoke(null, CurrentSunScore + startValue);
        ProgressBar.Value = _sun + startValue;
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
        
        if (SUN1.Top > 530) ChangeAISuns(SUN1);
        if (SUN2.Top > 530) ChangeAISuns(SUN2);
    }

    private void ChangeAISuns(PictureBox tempSun)
    {
        var ai = new Sun(tempSun);
    }

    public void CreateNewSunPosition(PictureBox sun)
    {
        sun.Top = -250;
        
        if ((string)sun.Tag == "sunLeft")
        {
            sun.Left = _sunPosition.Next(5, 135);
        }
        else if ((string)sun.Tag == "sunRight")
        {
            sun.Left = _sunPosition.Next(230, 360);
        }    
    }
}