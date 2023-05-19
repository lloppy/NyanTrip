using NUnit.Framework;
using Car_Racing_Game_MOO_ICT.Game.Domain;
using System;

namespace Car_Racing_Game_MOO_ICT.Tests
{
    public class ScoreTests
    {
        [Test]
        public void ScoreConstructor_SetsInitialScoreToZero()
        {
            var score = new Score();
            Assert.AreEqual(score.CurrentScore, 0);
        }

        [Test]
        public void UpdateScore_IncrementsCurrentScore()
        {
            var score = new Score();
            score.UpdateScore();
            Assert.AreEqual(score.CurrentScore, 1);
        }

        [Test]
        public void ScoreUpdated_EventRaisedOnUpdateScore()
        {
            var score = new Score();
            int eventCount = 0;
            int expectedScore = 1;
            EventHandler<int> handler = (sender, score) => { eventCount++; };

            score.ScoreUpdated += handler;
            score.UpdateScore();

            Assert.AreEqual(eventCount, 1);
            Assert.AreEqual(score.CurrentScore, expectedScore);

            score.ScoreUpdated -= handler;
        }

        [Test]
        public void ResetScore_ResetsCurrentScoreToZero()
        {
            var score = new Score();
            score.UpdateScore();
            score.ResetScore();

            Assert.AreEqual(score.CurrentScore, 0);
        }
    }
}