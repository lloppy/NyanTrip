using System;

namespace RainbowHunter.Game.Domain;

public class Score
{
    private static int _score;
    public event EventHandler<int> ScoreUpdated;

    public Score() => _score = 0;
    
    public void ResetScore() => _score = 0;

    public int CurrentScore
    {
        get => _score;
        private set => _score = value;
    }
    
    public void UpdateScore()
    {
        _score++;
        ScoreUpdated?.Invoke(null, CurrentScore);
    }
}