using System;
using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT.Game;

public class Sun
{
    private int _sun;
 
    public Sun()
    {
        _sun = 0;
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
}