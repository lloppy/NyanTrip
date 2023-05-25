using System.Drawing;
using System.Windows.Forms;
using RainbowHunter.Game.Controller;

namespace RainbowHunter.Game.View
{
    public partial class FinishedControl : UserControl
    {
        public FinishedControl()
        {
            InitializeComponent();
        }

        public void Configure(GameScenes gameScenes)
        {
            var panel = new Panel();
            panel.BackColor = Color.Black;

        }
    }
}