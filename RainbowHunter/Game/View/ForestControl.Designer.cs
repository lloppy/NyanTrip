using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RainbowHunter.Game.View
{
    partial class ForestControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.panel1 = new Panel();
            this.txtScore = new System.Windows.Forms.Label();
            this.sunScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.SUN1 = new System.Windows.Forms.PictureBox();
            this.SUN2 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUN2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.SUN2);
            this.panel1.Controls.Add(this.SUN1);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.roadTrack2);
            this.panel1.Controls.Add(this.roadTrack1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 519);
            this.panel1.TabIndex = 0;
            this.panel1.BackColor = Color.Green;
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(12, 534);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(475, 37);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score: 0";
            this.txtScore.Visible = false;
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sunScore
            // 
            this.sunScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunScore.Location = new System.Drawing.Point(12, 564);
            this.sunScore.Name = "sunScore";
            this.sunScore.Size = new System.Drawing.Size(475, 37);
            this.sunScore.TabIndex = 2;
            this.sunScore.Text = "Sun: 0";
            this.sunScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 634);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 138);
            this.label2.TabIndex = 3;
            this.label2.Text = "Press Left and Right to move. \r\n\r\nCollect mushrooms in the _game an" +
    "d survive as long as you can";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roadTrack1
            // 
            this.roadTrack1.Image = global::RainbowHunter.Properties.Resources.roadTrack;
            this.roadTrack1.Location = new System.Drawing.Point(0, -519);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(475, 519);
            this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack1.TabIndex = 0;
            this.roadTrack1.TabStop = false;
            // 
            // roadTrack2
            // 
            this.roadTrack2.Image = global::RainbowHunter.Properties.Resources.roadTrack;
            this.roadTrack2.Location = new System.Drawing.Point(0, 0);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(475, 519);
            this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack2.TabIndex = 4;
            this.roadTrack2.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::RainbowHunter.Properties.Resources.user;
            this.player.Location = new System.Drawing.Point(215, 402);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 99);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 5;
            this.player.Click += new System.EventHandler(this.ResetGame);
            this.player.TabStop = false;
            // 
            // AI1
            // 
            this.AI1.Image = global::RainbowHunter.Properties.Resources.mushroomGreen;
            this.AI1.Location = new System.Drawing.Point(86, 42);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(50, 101);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI1.TabIndex = 5;
            this.AI1.TabStop = false;
            this.AI1.Tag = "mushroomLeft";
            // 
            // AI2
            // 
            this.AI2.Image = global::RainbowHunter.Properties.Resources.mushroomGrey;
            this.AI2.Location = new System.Drawing.Point(370, 82);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(50, 100);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI2.TabIndex = 5;
            this.AI2.TabStop = false;
            this.AI2.Tag = "mushroomRight";
            // 
            // SUN1
            // 
            this.SUN1.Image = global::RainbowHunter.Properties.Resources.sun;
            this.SUN1.Location = new System.Drawing.Point(20, 232);
            this.SUN1.Name = "SUN1";
            this.SUN1.BringToFront();
            this.SUN1.Size = new System.Drawing.Size(50, 101);
            this.SUN1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SUN1.TabIndex = 5;
            this.SUN1.TabStop = false;
            this.SUN1.Tag = "sunLeft";
            // 
            // SUN2
            // 
            this.SUN2.Image = global::RainbowHunter.Properties.Resources.sun;
            this.SUN2.Location = new System.Drawing.Point(402, 402);
            this.SUN2.Name = "SUN2";
            this.SUN2.BringToFront();
            this.SUN2.Size = new System.Drawing.Size(50, 100);
            this.SUN2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SUN2.TabIndex = 5;
            this.SUN2.TabStop = false;
            this.SUN2.Tag = "sunRight";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 781);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.sunScore);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Mushroom Hunter Simulator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUN2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label sunScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox roadTrack2;
        private System.Windows.Forms.PictureBox roadTrack1;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox SUN1;
        private System.Windows.Forms.PictureBox SUN2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
    }
}
