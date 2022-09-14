
namespace P04_Missing_Plane_Adventure
{
    partial class Pregame_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.widthInput = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.customRadioCheck = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(62, 34);
            this.widthInput.Name = "widthInput";
            this.widthInput.PlaceholderText = "Enter Whole Number.......";
            this.widthInput.Size = new System.Drawing.Size(131, 23);
            this.widthInput.TabIndex = 0;
            this.widthInput.Text = "10";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(12, 37);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(39, 15);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "Width";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(12, 72);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(43, 15);
            this.heightLabel.TabIndex = 4;
            this.heightLabel.Text = "Height";
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(62, 69);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(131, 23);
            this.heightInput.TabIndex = 5;
            this.heightInput.Text = "10";
            // 
            // customRadioCheck
            // 
            this.customRadioCheck.AutoSize = true;
            this.customRadioCheck.Location = new System.Drawing.Point(12, 9);
            this.customRadioCheck.Name = "customRadioCheck";
            this.customRadioCheck.Size = new System.Drawing.Size(137, 19);
            this.customRadioCheck.TabIndex = 6;
            this.customRadioCheck.Text = "Custom dimensions?";
            this.customRadioCheck.UseVisualStyleBackColor = true;
            this.customRadioCheck.CheckedChanged += new System.EventHandler(this.customRadioCheck_CheckedChanged_1);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 211);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(181, 23);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Pregame_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 246);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.customRadioCheck);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.widthInput);
            this.Name = "Pregame_Form";
            this.Text = "Pregame Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox heightInput;
        private System.Windows.Forms.CheckBox customRadioCheck;
        private System.Windows.Forms.Button startButton;
    }
}

