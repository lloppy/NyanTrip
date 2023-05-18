using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT.Game;

public class Score
{
    private int _score;

    public Score()
    {
        _score = 0;
    }

    public int getScore()
    {
        return _score ;
    }
    public void UpdateScore(Label label)
    {
        _score++;
        label.Text = "Score: " + _score;
    }

    public void ResetScore()
    {
        _score = 0;
    }
}