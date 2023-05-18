using System.Drawing;
using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT.Game;

public class Game
{
    public PictureBox Player { get; set; }
    public PictureBox AI1 { get; set; }
    public PictureBox AI2 { get; set; }
    public PictureBox Explosion { get; set; }
    public PictureBox Award { get; set; }
    public Timer GameTimer { get; set; }
    
    public void gameOver(Timer gameTimer, PictureBox explosion, PictureBox player, PictureBox award, Button btnStart)
    {
        playSound();
        gameTimer.Stop();
        explosion.Visible = true;
        player.Controls.Add(explosion);
        explosion.Location = new Point(-8, 5);
        explosion.BackColor = Color.Transparent;

        award.Visible = true;
        award.BringToFront();

        btnStart.Enabled = true;
    }

    public void ResetGame(Timer gameTimer, PictureBox explosion, PictureBox award, Button btnStart)
    {
        btnStart.Enabled = false;
        explosion.Visible = false;
        award.Visible = false;
        
        award.Image = Properties.Resources.bronze;
        //roadSpeed = 12;
        //trafficSpeed = 15;
        
    }
    private void playSound()
    {
        System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Properties.Resources.hit);
        playCrash.Play();
    }
}