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
            //Creating instance for each team, data will be passed to AI
            teamData teamOneData = new teamData();
            teamData teamTwoData = new teamData();

            string teamOne = teamOneDropdown.SelectedIndex.ToString();
            string teamTwo = teamTwoDropdown.SelectedIndex.ToString();

            int TeamOneW = Int32.Parse(teamOneWL.Text);
            int teamTwoW = Int32.Parse(teamTwoWL.Text);

            Boolean teamOneHome = false;
            Boolean teamTwoHome = false;

            if (teamOneCheck.Checked)
            {
                teamOneHome = true;
                teamTwoHome = false;
            }
            else if (teamTwoCheck.Checked)
            {
                teamTwoHome = true;
                teamOneHome = false;
            }

            //Inserting inputted data into class instances
            teamOneData.setTeamName(teamOne);
            teamOneData.setRecordPercentage();
            teamOneData.setHome(teamOneHome);

            teamTwoData.setTeamName(teamTwo);
            teamTwoData.setRecordPercentage();
            teamTwoData.setHome(teamTwoHome);

            main();
        }

        void main()
        {
            //AI code
        }
    }
}
