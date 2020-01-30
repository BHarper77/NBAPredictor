using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Coursework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string teamOne = teamOneDropdown.SelectedIndex.ToString();
            string teamTwo = teamTwoDropdown.SelectedIndex.ToString();

            int TeamOneW = Int32.Parse(teamOneWL.Text);
            int teamTwoW = Int32.Parse(teamTwoWL.Text);

            if (teamOneCheck.Checked)
            {

            }
            else if (teamTwoCheck.Checked)
            {

            }
        }
    }
}
