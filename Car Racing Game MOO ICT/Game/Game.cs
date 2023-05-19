using System;
using System.Drawing;
using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT.Game;

public class Game
{
    private PictureBox Player { get; }
    private PictureBox Explosion { get; }
    private PictureBox Award { get; }
    private Timer GameTimer { get; }
    private Button BtnStart { get; }

    private Score score; 
    private Sun sun; 
    private Speed Speed; 
    
    public Game(Timer gameTimer, PictureBox explosion, PictureBox player, PictureBox award, Button btnStart, Speed speed)
    {
        GameTimer = gameTimer;
        Explosion = explosion;
        Player = player;
        Award = award;
        Speed = speed;
        BtnStart = btnStart;
    }
    
    public void UpdateAward()
    {
        var endScore = score.CurrentScore;
        if (endScore > 40 && endScore < 500)
        {
            Award.Image = Properties.Resources.bronze;
        }

        if (endScore > 500 && endScore < 2000)
        {
            Award.Image = Properties.Resources.silver;
            Speed.roadSpeed = 18;
            Speed.trafficSpeed = 20;
        }

        if (endScore > 2000)
        {
            Award.Image = Properties.Resources.gold;
            Speed.trafficSpeed = 25;
            Speed.roadSpeed = 23;
        }
    }

    public void CheckCollisions(PictureBox AI1, PictureBox AI2)
    {
        if (Player.Bounds.IntersectsWith(AI1.Bounds) || Player.Bounds.IntersectsWith(AI2.Bounds))
        {
            gameOver();
        }
    }
    
    public void CheckGameOver()
    {
        if (sun.getSunCount() == 100)
        {
            gameOver();
        }
    }

    private void gameOver()
    {
        playSound();
        GameTimer.Stop();
        Explosion.Visible = true;
        Player.Controls.Add(Explosion);
        Explosion.Location = new Point(-8, 5);
        Explosion.BackColor = Color.Transparent;

        Award.Visible = true;
        Award.BringToFront();
        
        BtnStart.Enabled = true;
    }

    public void ResetGame()
    {
        BtnStart.Enabled = false;
        Explosion.Visible = false;
        Award.Visible = false; 
        Award.Image = Properties.Resources.bronze;

        score = new Score(); 
        sun = new Sun();
        score.ResetScore(); 
        sun.ResetSunScore();
    }
    
    private void playSound()
    {
        System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Properties.Resources.hit);
        playCrash.Play();
    }

    public void SetGameSettings(PictureBox AI1, PictureBox AI2, PictureBox SUN1, PictureBox SUN2, Random position)
    {
        Speed.roadSpeed = 13;
        Speed.trafficSpeed = 16;

        AI1.Top = position.Next(200, 500) * -1;
        AI1.Left = position.Next(5, 200);
        AI2.Top = position.Next(200, 500) * -1;
        AI2.Left = position.Next(245, 422);

        SUN1.Top = position.Next(200, 500) * -1;
        SUN1.Left = position.Next(5, 200);
        SUN2.Top = position.Next(200, 500) * -1;
        SUN2.Left = position.Next(245, 422);    }
}