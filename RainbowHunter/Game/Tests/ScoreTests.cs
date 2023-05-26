using NUnit.Framework;
using RainbowHunter.Game.Domain;

namespace RainbowHunter.Game.Tests
{
    [TestFixture]
    public class ScoreTests
    {
        [Test]
        public void ScoreStartsAtZero()
        {
            var score = new Score();

            Assert.AreEqual(0, score.CurrentScore);
        }

        [Test]
        public void UpdateScoreIncreasesScore()
        {
            var score = new Score();
            score.UpdateScore();

            Assert.AreEqual(1, score.CurrentScore);
        }

        [Test]
        public void ScoreUpdatedEventIsRaised()
        {
            var score = new Score();
            bool eventRaised = false;
            int updatedScore = 0;

            score.ScoreUpdated += (sender, score) =>
            {
                eventRaised = true;
                updatedScore = score;
            };

            score.UpdateScore();

            Assert.IsTrue(eventRaised);
            Assert.AreEqual(1, updatedScore);
        }

        [Test]
        public void ResetScoreSetsScoreToZero()
        {
            var score = new Score();
            score.UpdateScore();
            score.ResetScore();

            Assert.AreEqual(0, score.CurrentScore);
        }
    }
}