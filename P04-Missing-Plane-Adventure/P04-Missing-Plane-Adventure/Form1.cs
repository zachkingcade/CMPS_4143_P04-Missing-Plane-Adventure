using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04_Missing_Plane_Adventure
{
    public partial class Pregame_Form : Form
    {
        public Pregame_Form()
        {
            InitializeComponent();
        }

        private void customRadioCheck_CheckedChanged_1(object sender, EventArgs e)
        {
            sizeInput.Text = "10";
            sizeInput.Enabled = customRadioCheck.Checked;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //Create a game window and show it
            GameWindow game = new GameWindow(Int32.Parse(sizeInput.Text), this);
            game.Show();

            //close the current pregame window
            this.Hide();
        }

        private void sizeInput_TextChanged(object sender, EventArgs e)
        {
            if (sizeInput.Text != "")
            {
                sizeInput.Text = Int32.Parse(sizeInput.Text) <= 20 ? sizeInput.Text : "20";
                sizeInput.Text = Int32.Parse(sizeInput.Text) >= 2 ? sizeInput.Text : "2";
            }
        }
    }
}
