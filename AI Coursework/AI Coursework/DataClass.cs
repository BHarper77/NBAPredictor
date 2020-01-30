using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Coursework
{
    public class teamData
    {
        string teamName;
        double recordPercentage;
        Boolean home;

        //Setters
        public void setTeamName(string name)
        {
            teamName = name;
        }

        public void setRecordPercentage(double percentage)
        {
            recordPercentage = percentage;
        }

        public void setHome(Boolean Home)
        {
            home = Home;
        }

        //Getters
        public string getTeamName()
        {
            return teamName;
        }

        public double getRecordPercentage()
        {
            return recordPercentage;
        }

        public Boolean getHome()
        {
            return home;
        }
    }
}
