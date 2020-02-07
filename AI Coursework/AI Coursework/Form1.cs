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
