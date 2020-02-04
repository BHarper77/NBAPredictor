using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Authenticators;

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
            if (validate() == true)
            {
                RestClientClass restClient = new RestClientClass();
                string[] teams = new string[2];

                string teamOne = teamOneDropdown.GetItemText(teamOneDropdown.SelectedItem);
                string teamTwo = teamTwoDropdown.GetItemText(teamTwoDropdown.SelectedItem);

                teams[0] = teamOne;
                teams[1] = teamTwo;

                string[] data = new string[2];

                data = restClient.getData(teams);
            }

            /*if (validate() == true)
            {
                //Creating instance for each team, data will be passed to AI
                teamData teamOneData = new teamData();
                teamData teamTwoData = new teamData();

                string teamOne = teamOneDropdown.GetItemText(teamOneDropdown.SelectedItem);
                string teamTwo = teamTwoDropdown.GetItemText(teamTwoDropdown.SelectedItem);

                double teamOneOffRtg = double.Parse(teamOneOrtg.Text);
                double teamTwoOffRtg = double.Parse(teamTwoOrtg.Text);

                double teamOneDefRtg = double.Parse(teamOneDrtg.Text);
                double teamTwoDefRtg = double.Parse(teamTwoDrtg.Text);

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
                teamOneData.setOffRating(teamOneOffRtg);
                teamOneData.setDefRating(teamOneDefRtg);
                teamOneData.setHome(teamOneHome);

                teamTwoData.setTeamName(teamTwo);
                teamTwoData.setOffRating(teamTwoOffRtg);
                teamTwoData.setDefRating(teamTwoDefRtg);
                teamTwoData.setHome(teamTwoHome);

                main(teamOneData, teamTwoData);
            }*/
        }

        void main(teamData teamOneData, teamData teamTwoData)
        {
            int teamOneScore, teamTwoScore;
        }

        Boolean validate()
        {
            /*if ((teamOneDropdown.SelectedIndex > -1) || (teamTwoDropdown.SelectedIndex > -1)
                || (string.IsNullOrWhiteSpace(teamOneOrtg.Text)) || (string.IsNullOrWhiteSpace(teamTwoOrtg.Text))
                || (string.IsNullOrWhiteSpace(teamOneDrtg.Text)) || (string.IsNullOrWhiteSpace(teamTwoDrtg.Text)))
            {
                MessageBox.Show("Missing data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if ((!teamOneCheck.Checked) && (!teamTwoCheck.Checked))
            {
                MessageBox.Show("Select a home team", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }*/

            return true;
        }
    }
}
