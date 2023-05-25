namespace RainbowHunter.Game.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.startControl = new RainbowHunter.Game.View.StartControl();
            this.forestControl = new RainbowHunter.Game.View.ForestControl();
            this.finishedControl = new RainbowHunter.Game.View.FinishedControl();
            this.SuspendLayout();
            // 
            // forestControl
            // 
            this.forestControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forestControl.Location = new System.Drawing.Point(0, 0);
            this.forestControl.Name = "forestControl";
            this.forestControl.Size = new System.Drawing.Size(475, 519);
            this.forestControl.TabIndex = 0;
            // 
            // startControl
            // 
            this.startControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startControl.Location = new System.Drawing.Point(0, 0);
            this.startControl.Name = "startControl";
            this.startControl.Size = new System.Drawing.Size(475, 519);
            this.startControl.TabIndex = 2;
            // 
            // finishedControl1
            // 
            this.finishedControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finishedControl.Location = new System.Drawing.Point(0, 0);
            this.finishedControl.Name = "finishedControl1";
            this.finishedControl.Size = new System.Drawing.Size(475, 519);
            this.finishedControl.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 781);
            this.Controls.Add(this.finishedControl);
            this.Controls.Add(this.startControl);
            this.Controls.Add(this.forestControl);
            this.Name = "MainForm";
            this.Text = "Rainbow Hunter";
            this.ResumeLayout(false);
        }

        #endregion

        private ForestControl forestControl;
        private StartControl startControl;
        private FinishedControl finishedControl;
    }
}

