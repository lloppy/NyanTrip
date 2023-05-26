using System;
using System.Windows.Forms;

namespace RainbowHunter.Game.View
{
    public partial class StartControl : UserControl
    {
        private Controller.GameScenes _gameScenes;

        public StartControl()
        {
            InitializeComponent();
            playStartMusic();
        }
        
        public void Configure(Controller.GameScenes gameScenes)
        {
            if (_gameScenes != null)
                return;
            
            _gameScenes = gameScenes;
            startButton.Click += StartButton_Click;
        }

        private void playStartMusic()
        {
            System.Media.SoundPlayer nyanSong = new System.Media.SoundPlayer(Properties.Resources.hit2);
            nyanSong.Play();
            
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            _gameScenes.Start();
        }
    }
}