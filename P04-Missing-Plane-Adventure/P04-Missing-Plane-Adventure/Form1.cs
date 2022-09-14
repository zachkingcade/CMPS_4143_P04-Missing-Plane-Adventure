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
            if (customRadioCheck.Checked)
            {
                widthInput.Enabled = true;
                heightInput.Enabled = true;
            }
            else
            {
                widthInput.Text = "10";
                heightInput.Text = "10";
                widthInput.Enabled = false;
                heightInput.Enabled = false;
            }
        }
    }
}
