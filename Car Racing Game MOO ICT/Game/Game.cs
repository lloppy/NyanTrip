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
    
    public Game(Timer gameTimer, PictureBox explosion, PictureBox player, PictureBox award, Button btnStart)
    {
        GameTimer = gameTimer;
        Explosion = explosion;
        Player = player;
        Award = award;
        BtnStart = btnStart;
    }
    
    public void gameOver()
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
        //roadSpeed = 12;
        //trafficSpeed = 15;
        
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
}