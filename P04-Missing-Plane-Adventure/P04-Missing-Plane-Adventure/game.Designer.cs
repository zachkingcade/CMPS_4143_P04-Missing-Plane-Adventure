
namespace P04_Missing_Plane_Adventure
{
    partial class GameWindow
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guessCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.distanceIslandLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.wonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guessCountLabel
            // 
            this.guessCountLabel.AutoSize = true;
            this.guessCountLabel.Location = new System.Drawing.Point(12, 9);
            this.guessCountLabel.Name = "guessCountLabel";
            this.guessCountLabel.Size = new System.Drawing.Size(61, 15);
            this.guessCountLabel.TabIndex = 0;
            this.guessCountLabel.Text = "Guesses: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click on unexplored tiles to see if you can find the island!";
            // 
            // distanceIslandLabel
            // 
            this.distanceIslandLabel.AutoSize = true;
            this.distanceIslandLabel.Location = new System.Drawing.Point(549, 9);
            this.distanceIslandLabel.Name = "distanceIslandLabel";
            this.distanceIslandLabel.Size = new System.Drawing.Size(118, 15);
            this.distanceIslandLabel.TabIndex = 2;
            this.distanceIslandLabel.Text = "Distance from island:";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(201, 27);
            this.playButton.Name = "playButton";
            this.playButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Visible = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(433, 27);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Visible = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // wonLabel
            // 
            this.wonLabel.AutoSize = true;
            this.wonLabel.Location = new System.Drawing.Point(328, 31);
            this.wonLabel.Name = "wonLabel";
            this.wonLabel.Size = new System.Drawing.Size(58, 15);
            this.wonLabel.TabIndex = 5;
            this.wonLabel.Text = "You Won!";
            this.wonLabel.Visible = false;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 761);
            this.Controls.Add(this.wonLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.distanceIslandLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guessCountLabel);
            this.Name = "GameWindow";
            this.Text = "Missing Plane Adventure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label guessCountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label distanceIslandLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label wonLabel;
    }
}