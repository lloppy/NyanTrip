using System;
using System.Windows.Forms;
using NUnit.Framework;
using RainbowHunter.Game.Controller;
using RainbowHunter.Game.Domain;

namespace RainbowHunter.Game.Tests;

[TestFixture]
public class ForestControlTests
{
    [Test]
    public void TestScoreUpdate()
    {
        Score score = new Score();
        score.UpdateScore();
        Assert.AreEqual(1, score.CurrentScore);
    }

    [Test]
    public void TestSunUpdate()
    {
        Sun sun = new Sun();
        sun.UpdateSunScore();
        Assert.AreEqual(0, sun.GetSunCount());
    }
    
    [Test]
    public void TestSunUpdateWithValue()
    {
        Sun sun = new Sun();
        sun.UpdateSunScore(70);
        Assert.AreEqual(70, sun.ProgressBar.Value);
    }
    
    [Test]
    public void TestMovementUtility()
    {
        Speed speed = new Speed(12, 15, 12);
        PictureBox player = new PictureBox();
        PictureBox roadTrack1 = new PictureBox();
        PictureBox roadTrack2 = new PictureBox();
        PictureBox SUN1 = new PictureBox();
        PictureBox SUN2 = new PictureBox();
        PictureBox AI1 = new PictureBox();
        PictureBox AI2 = new PictureBox();

        MovementUtility movementUtility = new MovementUtility(speed, player, roadTrack1, roadTrack2, SUN1, SUN2, AI1, AI2);
        movementUtility.MovePlayer(); 
        movementUtility.MoveRoad(); 
        movementUtility.MoveSun(new Sun()); 
    }

    [Test]
    public void TestGame()
    {
        PictureBox player = new PictureBox();
        Speed speed = new Speed(12, 15, 12);
        Controller.Game game = new Controller.Game(new Timer(), player, speed);
        game.ResetGame(); // test game reset
        game.SetGameSettings(new PictureBox(), new PictureBox(), new PictureBox(), new PictureBox(), new Random()); // test game settings
    }

}