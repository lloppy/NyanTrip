using System;
using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT.Game;

public class Score
{
    private static int _score;

    public event EventHandler<int> ScoreUpdated;

    public Score()
    {
        _score = 0;
    }

    public int CurrentScore
    {
        get => _score;
        private set => _score = value;
    }
    
    public void UpdateScore(Label label)
    {
        _score++;
        ScoreUpdated?.Invoke(null, CurrentScore);
    }

    public void ResetScore()
    {
        _score = 0;
    }
}