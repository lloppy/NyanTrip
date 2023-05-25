using System;

namespace RainbowHunter.Game.Controller
{
    public class GameScenes
    {
        private GameStage stage = GameStage.NotStarted;

        public event Action<GameStage> StageChanged;
        public GameStage Stage => stage;


        public void Start()
        {
            ChangeStage(GameStage.Forest);
        }

        public void StartNyanGame()
        {
            ChangeStage(GameStage.Cats);
        }
        
        private void ChangeStage(GameStage stage)
        {
            this.stage = stage;
            StageChanged?.Invoke(stage);
        }
    }
}