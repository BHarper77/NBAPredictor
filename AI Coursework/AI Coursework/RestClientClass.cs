using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;

namespace AI_Coursework
{
    public class RestClientClass
    {
        //Recieving inputted data from user and requesting data from API
        public string[] getData(string[] teams)
        {
            var client = new RestClient("https://flagrantflop.com/api/endpoint.php?api_key=13b6ca7fa0e3cd29255e044b167b01d7&scope=team_stats&season=2019-2020&season_type=regular&team_name=");

            string[] results = new string[2];

            //Using for loop to send one request for each team, JSON results stored in a string array and returned
            for (int i = 0; i < 3; i++)
            {
                var request = new RestRequest(teams[i], DataFormat.Json);

                dynamic json = client.Get(request);

                string jsonString = json.toString();

                results[i] = json;
            }

            return results;
        }
        
    }
}
