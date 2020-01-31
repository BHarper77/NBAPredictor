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
        double offRtg, defRtg;
        Boolean home;

        //Setters
        public void setTeamName(string name)
        {
            teamName = name;
        }

        public void setOffRating(double offRating)
        {
            offRtg = offRating;
        }

        public void setDefRating(double defRating)
        {
            defRtg = defRating;
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

        public double getOffRating()
        {
            return offRtg;
        }

        public double getDefRating()
        {
            return defRtg;
        }

        public Boolean getHome()
        {
            return home;
        }
    }
}
