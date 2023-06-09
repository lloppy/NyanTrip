﻿using System;
using System.Windows.Forms;
using RainbowHunter.Game.Controller.Interfaces;
using RainbowHunter.Game.Domain;

namespace RainbowHunter.Game.Controller
{
 public class MovementUtility : IMovementUtility
    {
        private Speed speed;
        public PictureBox player;
        private PictureBox roadTrack1;
        private PictureBox roadTrack2;
        public PictureBox sun1;
        public PictureBox sun2;
        public PictureBox AI1;
        public PictureBox AI2;

        public bool goLeft;
        public bool goRight;

        private Sun sun = new Sun();

        public MovementUtility(Speed speed, PictureBox player, PictureBox roadTrack1, PictureBox roadTrack2,
            PictureBox sun1, PictureBox sun2, PictureBox ai1, PictureBox ai2)
        {
            this.speed = speed;
            this.player = player;
            this.roadTrack1 = roadTrack1;
            this.roadTrack2 = roadTrack2;
            this.sun1 = sun1;
            this.sun2 = sun2;
            this.AI1 = ai1;
            this.AI2 = ai2;
        }

        public void MovePlayer()
        {
            if (goLeft && player.Left > 10)
            {
                player.Left -= speed.PlayerSpeed;
            }
            if (goRight && player.Left < 415)
            {
                player.Left += speed.PlayerSpeed;
            }
        }

        public void MoveRoad()
        {
            roadTrack1.Top += speed.RoadSpeed;
            roadTrack2.Top += speed.RoadSpeed;
            var size = 519;
            if (roadTrack2.Top > size)
            {
                roadTrack2.Top = -size;
            }
            if (roadTrack1.Top > size)
            {
                roadTrack1.Top = -size;
            }
        }
        
        public void MoveMushroom(Mushrooms mushroom)
        {
            mushroom.MoveTraffic(AI1, AI2, speed);
            var progressBar = new ProgressBar();

            if (player.Bounds.IntersectsWith(AI1.Bounds))
            {
                sun.IncreaseSunFromMushroom();
                mushroom.CreateNewMushroomPosition(AI1);
                ThrowTomato();
            }

            if (player.Bounds.IntersectsWith(AI2.Bounds))
            {
                sun.IncreaseSunFromMushroom();
                mushroom.CreateNewMushroomPosition(AI2);
                ThrowTomato();
            }
        }

        private void ThrowTomato()
        {
            var random = new Random();
            var luckyCharm = random.Next(0, 11);

            if (luckyCharm == 4)
            { 
                var tomato = new PictureBox();
                tomato.Image = Properties.Resources.tomato;
                tomato.BackColor = System.Drawing.Color.Transparent;
                tomato.Width = 475;
                tomato.Height = 519;
                tomato.Location = new System.Drawing.Point(0, 0);
                player.Parent.Controls.Add(tomato);
                tomato.BringToFront();
                
                var timer = new Timer();
                timer.Interval = 2000; 
                timer.Tick += (s, e) => {
                    player.Parent.Controls.Remove(tomato);
                    timer.Stop();
                };
                timer.Start();
            }
        }


        public void MoveSun(Sun sun)
        {
            sun.MoveSun(sun1, sun2, speed);

            if (player.Bounds.IntersectsWith(sun1.Bounds))
            {
                sun.IncreaseSun();
                sun.CreateNewSunPosition(sun1);
            }
            if (player.Bounds.IntersectsWith(sun2.Bounds))
            {
                sun.IncreaseSun();
                sun.CreateNewSunPosition(sun2);
            }
        }
    }
}