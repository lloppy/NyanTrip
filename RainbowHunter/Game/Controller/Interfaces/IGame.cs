using System;
using System.Windows.Forms;

namespace RainbowHunter.Game.Controller.Interfaces;

public interface IGame
{
    PictureBox Player { get; set; }
    Timer GameTimer { get; set; }
    void UpdateAward();
    void ResetGame();
    void SetGameSettings(PictureBox ai1, PictureBox ai2, PictureBox sun1, PictureBox sun2, Random position);
}