
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
            this.sizeInput = new System.Windows.Forms.TextBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.customRadioCheck = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sizeInput
            // 
            this.sizeInput.Enabled = false;
            this.sizeInput.Location = new System.Drawing.Point(62, 34);
            this.sizeInput.Name = "sizeInput";
            this.sizeInput.PlaceholderText = "Enter Whole Number.......";
            this.sizeInput.Size = new System.Drawing.Size(131, 23);
            this.sizeInput.TabIndex = 0;
            this.sizeInput.Text = "10";
            this.sizeInput.TextChanged += new System.EventHandler(this.sizeInput_TextChanged);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(12, 37);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(27, 15);
            this.sizeLabel.TabIndex = 1;
            this.sizeLabel.Text = "Size";
            // 
            // customRadioCheck
            // 
            this.customRadioCheck.AutoSize = true;
            this.customRadioCheck.Location = new System.Drawing.Point(12, 9);
            this.customRadioCheck.Name = "customRadioCheck";
            this.customRadioCheck.Size = new System.Drawing.Size(130, 19);
            this.customRadioCheck.TabIndex = 6;
            this.customRadioCheck.Text = "Custom Size? (2-20)";
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
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.sizeInput);
            this.Name = "Pregame_Form";
            this.Text = "Pregame Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sizeInput;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.CheckBox customRadioCheck;
        private System.Windows.Forms.Button startButton;
    }
}

