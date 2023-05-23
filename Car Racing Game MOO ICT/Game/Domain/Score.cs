using System;

namespace Car_Racing_Game_MOO_ICT.Game.Domain;

public class Score
{
    private static int _score;
    public bool stop = false;

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
    
    public void UpdateScore()
    {
        if (!stop)
        {
            _score++;
            ScoreUpdated?.Invoke(null, CurrentScore);
        }
    }

    public void PauseScore()
    {
        stop = true;
    }
    
    public void ResetScore()
    {
        _score = 0;
    }
}