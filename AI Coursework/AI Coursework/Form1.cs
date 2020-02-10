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
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RestSharp.Serialization.Json;

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
            //Creating new request to API for each team selected by user
            var client = new RestClient("https://flagrantflop.com/api/");

            string[] teams = new string[2];

            teams[0] = teamOneDropdown.GetItemText(teamOneDropdown.SelectedItem);
            teams[1] = teamTwoDropdown.GetItemText(teamTwoDropdown.SelectedItem);

            #region TeamOne            
            var request = new RestRequest("endpoint.php?api_key=13b6ca7fa0e3cd29255e044b167b01d7&scope=team_stats&season=2019-2020&season_type=regular&team_name=" + teams[0], Method.GET);
            var response = client.Execute(request);

            JsonDeserializer deserializer = new JsonDeserializer();
            string json = deserializer.Deserialize<string>(response);

            var teamOneData = DataClass.FromJson(json);
            #endregion

            #region TeamTwo
            var requestTwo = new RestRequest("endpoint.php?api_key=13b6ca7fa0e3cd29255e044b167b01d7&scope=team_stats&season=2019-2020&season_type=regular&team_name=" + teams[1], Method.GET);
            var responseTwo = client.Execute(requestTwo);

            JsonDeserializer deserializerTwo = new JsonDeserializer();
            string jsonTwo = deserializerTwo.Deserialize<string>(responseTwo);

            var teamTwoData = DataClass.FromJson(json);
            #endregion

            MessageBox.Show("Team 1: " + teamOneData.Data[0].TeamName + "Team 2:" + teamTwoData.Data[0].TeamName);

            double[] teamScores = offence(teamOneData, teamTwoData);

            if (teamScores[0] > teamScores[1])
            {
                MessageBox.Show("Team 1 wins");
            }
            else if (teamScores[1] > teamScores[0])
            {
                MessageBox.Show("Team 2 wins");
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        /* RULE ONE*/
        double[] offence(DataClass teamOneData, DataClass teamTwoData)
        {
            double[] teamScores = new double[2];

            #region Pace
            double teamOnePace = double.Parse(teamOneData.Data[0].Pace);
            double teamTwoPace = double.Parse(teamTwoData.Data[0].Pace);

            if (teamOnePace > teamTwoPace)
            {
                teamScores[0] += 0.4;
            }
            else if (teamTwoPace > teamOnePace)
            {
                teamScores[1] += 0.4;
            }
            #endregion

            #region Assists
            string[] splitOneAssists = teamOneData.Data[0].Assists.Split('|');
            string[] splitTwoAssists = teamTwoData.Data[0].Assists.Split('|');

            int teamOneAssists = int.Parse(splitOneAssists[0]);
            int teamTwoAssists = int.Parse(splitTwoAssists[0]);

            if (teamOneAssists > teamTwoAssists)
            {
                teamScores[0] += 0.5;
            }
            else if (teamTwoAssists > teamOneAssists)
            {
                teamScores[1] += 0.5;
            }
            #endregion

            #region OffensiveRebounds
            string[] splitOneRebounds = teamOneData.Data[0].OffensiveRebounds.Split('|');
            string[] splitTwoRebounds = teamTwoData.Data[0].OffensiveRebounds.Split('|');

            int teamOneRebounds = int.Parse(splitOneRebounds[0]);
            int teamTwoRebounds = int.Parse(splitTwoRebounds[0]);

            if (teamOneRebounds > teamTwoRebounds)
            {
                teamScores[0] += 0.3;
            }
            else if (teamTwoRebounds > teamOneRebounds)
            {
                teamScores[1] += 0.3;
            }
            #endregion

            #region 3pt Percentage
            double[] teamThreePercentages = calculateThreePointPercentages(teamOneData, teamTwoData);

            if (teamThreePercentages[0] > teamThreePercentages[1])
            {
                teamScores[0] += 0.8;
            }
            else if (teamThreePercentages[1] > teamThreePercentages[0])
            {
                teamScores[1] += 0.8;
            }
            #endregion

            #region FT percentage
            string[] splitOneFT = teamOneData.Data[0].FtPercentage.Split('|');
            string[] splitTwoFT = teamTwoData.Data[0].FtPercentage.Split('|');

            double teamOneFT = double.Parse(splitOneFT[0]);
            double teamTwoFT = double.Parse(splitTwoFT[0]);

            if (teamOneFT > teamTwoFT)
            {
                teamScores[0] += 0.6;
            }
            else if (teamTwoFT > teamOneFT)
            {
                teamScores[1] += 0.6;
            }
            #endregion

            #region OffensiveRating
            string[] splitOneRating = teamOneData.Data[0].OffensiveRating.Split('|');
            string[] splitTwoRating = teamTwoData.Data[0].OffensiveRating.Split('|');

            double teamOneRating = double.Parse(splitOneRating[0]);
            double teamTwoRating = double.Parse(splitTwoRating[0]);

            if (teamOneRating > teamTwoRating)
            {
                teamScores[0] = teamScores[0] + 0.9;
            }
            else if (teamTwoRating > teamOneRating)
            {
                teamScores[1] = teamScores[1] + 0.9;
            }
            #endregion

            return teamScores;
        }

        public double[] calculateThreePointPercentages(DataClass teamOneData, DataClass teamTwoData)
        {
            string[] splitOneFGAttempts = teamOneData.Data[0].FgAttempted.Split('|');
            string[] splitOneFGMade = teamOneData.Data[0].FgMade.Split('|');

            string[] splitOneTwoAttempts = teamOneData.Data[0].TpfgAttempted.Split('|');
            string[] splitOneTwoMade = teamOneData.Data[0].TpfgMade.Split('|');

            double oneThreeAttempt = double.Parse(splitOneFGAttempts[0]) - double.Parse(splitOneTwoAttempts[0]);
            double oneThreeMade = double.Parse(splitOneFGMade[0]) - double.Parse(splitOneTwoMade[0]);

            double oneThreePercentage = (oneThreeMade / oneThreeAttempt) * 100;

            string[] splitTwoFGAttempts = teamTwoData.Data[0].FgAttempted.Split('|');
            string[] splitTwoFGMade = teamTwoData.Data[0].FgMade.Split('|');

            string[] splitTwoTwoAttempts = teamTwoData.Data[0].TpfgAttempted.Split('|');
            string[] splitTwoTwoMade = teamTwoData.Data[0].TpfgMade.Split('|');

            double twoThreeAttempt = double.Parse(splitTwoFGAttempts[0]) - double.Parse(splitTwoTwoAttempts[0]);
            double twoThreeMade = double.Parse(splitTwoFGMade[0]) - double.Parse(splitTwoTwoMade[0]);

            double twoThreePercentage = (twoThreeMade / twoThreeAttempt) * 100;

            double[] percentages = new double[2];
            percentages[0] = oneThreePercentage;
            percentages[1] = twoThreePercentage;

            return percentages;
        }

        public bool validate()
        {
            if (teamOneDropdown.SelectedIndex < 0 || teamTwoDropdown.SelectedIndex < 0)
            {
                MessageBox.Show("Teams have not been selected correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
