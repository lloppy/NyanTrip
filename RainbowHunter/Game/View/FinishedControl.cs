using System;
using System.Drawing;
using System.Windows.Forms;
using RainbowHunter.Game.Controller;

namespace RainbowHunter.Game.View
{
    public partial class FinishedControl : UserControl
    {
        private GameScenes _gameScenes;

        public FinishedControl()
        {
            InitializeComponent();
        }

        public void Configure(GameScenes gameScenes)
        {
            
            _gameScenes = gameScenes;
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
            button.Text = "Начать заново";
            button.Font = new Font("Arial", 16);
            button.ForeColor = Color.White;
            button.BackColor = Color.Indigo;
            button.Top = label.Bottom + 260;
            button.Left = (panel.Width - button.Width) / 2;
            button.Click += OnOpenOtherControlButtonClick;
            panel.Controls.Add(button);

            var cat = new PictureBox();
            cat.Location = new Point(203, 103);
            cat.Size = new Size(300, 300);
            cat.Top = label.Bottom;
            cat.SizeMode = PictureBoxSizeMode.Zoom;
            cat.Left = (panel.Width - cat.Width) / 2 + 20;
            cat.Image = Properties.Resources.nyan_cat_right;
            panel.Controls.Add(cat);

        }
        
        private void OnOpenOtherControlButtonClick(object sender, EventArgs e)
        {
            //var main = (MainForm)FindForm();
            //main.Close();
            Application.Restart();
        }
    }
}