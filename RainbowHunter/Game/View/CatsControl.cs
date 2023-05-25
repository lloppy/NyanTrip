using System;
using System.Windows.Forms;
using RainbowHunter.Game.Controller;
using RainbowHunter.Game.Domain;

namespace RainbowHunter.Game.View
{
    public partial class CatsControl : UserControl
    {
        private Controller.GameScenes _gameScenes;

        public CatsControl()
        {
            InitializeComponent();
            
           CreateCats();
        }

        private void CreateCats()
        {
            var catCreator = new NyanCat(panel, new Random());
            for (var i = 0; i < 5; i++)
            {
                catCreator.CreateNyanCat(AI1, AI2);
            }
            
        }

        public void Configure(GameScenes gameScenes)
        {
            _gameScenes = gameScenes;

            
        }
    }
}