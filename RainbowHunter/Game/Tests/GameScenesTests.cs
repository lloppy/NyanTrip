using NUnit.Framework;
using RainbowHunter.Game.Controller;

namespace RainbowHunter.Game.Tests
{
    public class GameScenesTests
    {
        [Test]
        public void MainMenu_ChangesStageToNotStarted()
        {
            var gameScenes = new GameScenes();
            GameStage expected = GameStage.NotStarted;

            gameScenes.MainMenu();
            
            GameStage actual = gameScenes.Stage;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Start_ChangesStageToForest()
        {
            var gameScenes = new GameScenes();
            GameStage expected = GameStage.Forest;

            gameScenes.Start();
            
            GameStage actual = gameScenes.Stage;
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Finish_ChangesStageToFinished()
        {
            var gameScenes = new GameScenes();
            GameStage expected = GameStage.Finished;

            gameScenes.Finish();
            
            GameStage actual = gameScenes.Stage;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void StageChanged_Event_IsRaisedWhenStageChanges()
        {
            var gameScenes = new GameScenes();
            GameStage expected = GameStage.Forest;
            GameStage actual = GameStage.NotStarted;
            gameScenes.StageChanged += stage => actual = stage;

            gameScenes.Start();
            
            Assert.AreEqual(expected, actual);
        }
    }
}