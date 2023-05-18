using System;
using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT.Game;

public class Score
{
    private int _score;

    public event EventHandler<int> ScoreUpdated;

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
        ScoreUpdated?.Invoke(this, _score);
    }

    public void ResetScore()
    {
        _score = 0;
    }
}