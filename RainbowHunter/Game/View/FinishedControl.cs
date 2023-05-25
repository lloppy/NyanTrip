using System;
using System.Drawing;
using System.Windows.Forms;
using RainbowHunter.Game.Controller;

namespace RainbowHunter.Game.View
{
    public partial class FinishedControl : UserControl
    {
        private Controller.GameScenes _gameScenes;

        public FinishedControl()
        {
            InitializeComponent();
        }

      
        public void Configure(GameScenes gameScenes)
        {
            _gameScenes = gameScenes;
            
            //panel.BackColor = Color.Black;
            Controls.Add(panel);

            var label = new Label();
            label.Text = "Вы выиграли!";
            label.Top = 60;
            label.Font = new Font("Arial", 40, FontStyle.Bold);
            label.Width = panel.Width;
            label.Height = 140;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.ForeColor = Color.Indigo;
            panel.Controls.Add(label);

            var button = new Button();
            button.Location = new Point(300, 538);
            button.Size = new Size(400, 47);
            button.Text = "Выход";
            button.Font = new Font("Arial", 16);
            button.ForeColor = Color.White;
            button.BackColor = Color.Indigo;
            button.Top = label.Bottom + 260;
            button.Left = (panel.Width - button.Width) / 2;
            button.Click += OnOpenOtherControlButtonClick;
            panel.Controls.Add(button);
        }
        
        private void OnOpenOtherControlButtonClick(object sender, EventArgs e)
        {
            var main = (MainForm)FindForm();
            main.Close();
        }
    }
}