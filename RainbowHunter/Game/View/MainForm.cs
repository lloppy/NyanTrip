using System.Windows.Forms;
using RainbowHunter.Game.Controller;

namespace RainbowHunter.Game.View
{
    public partial class MainForm : Form
    {
        private GameScenes _gameScenes;

        public MainForm()
        {
            InitializeComponent();
            
            _gameScenes = new Controller.GameScenes();
            _gameScenes.StageChanged += GameScenesOnStageChanged;

            ShowStartScreen();
        }
        
        private void GameScenesOnStageChanged(GameStage stage)
        {
            switch (stage)
            {
                case GameStage.Forest:
                    ShowArrangingShipsScreen();
                    break;
                case GameStage.Cats:
                    ShowBattleScreen();
                    break;
                case GameStage.Finished:
                    ShowFinishedScreen();
                    break;
                case GameStage.NotStarted:
                default:
                    ShowStartScreen();
                    break;
            }
        }

        private void ShowStartScreen()
        {
            HideScreens();
            startControl.Configure(_gameScenes);
            startControl.Show();
        }

        private void ShowArrangingShipsScreen()
        {
            HideScreens();
            //forestControl.Configure(_gameScenes);
            forestControl.Show();
        }

        private void ShowBattleScreen()
        {
            HideScreens();
            //catsControl.Configure(_gameScenes);
            catsControl.Show();
        }

        private void ShowFinishedScreen()
        {
            HideScreens();
            //finishedControl.Configure(_gameScenes);
            finishedControl.Show();
        }

        private void HideScreens()
        {
            startControl.Hide();
            forestControl.Hide();
            catsControl.Hide();
            finishedControl.Hide();
        }
    }
}