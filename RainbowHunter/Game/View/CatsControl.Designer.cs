using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RainbowHunter.Game.View
{
    partial class CatsControl
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.panel = new Panel();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.SUN1 = new System.Windows.Forms.PictureBox();
            this.SUN2 = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUN2)).BeginInit();
            //
            // panel
            // 
            this.panel.Controls.Add(this.AI2);
            this.panel.Controls.Add(this.AI1);
            this.panel.Controls.Add(this.SUN2);
            this.panel.Controls.Add(this.SUN1);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(475, 519);
            this.panel.TabIndex = 0;
            this.panel.BackColor = Color.CornflowerBlue;    
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
            
            
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUN2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private Panel panel;
        
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox SUN1;
        private System.Windows.Forms.PictureBox SUN2;
        private Panel panel1;
    }
}