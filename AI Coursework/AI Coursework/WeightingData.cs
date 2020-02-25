using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Coursework
{
    public partial class WeightingData
    {
        //Class to hold all weighting on data, access total possible points
        public const double homeAdvantage = 0.18;

        #region offence
        public const double pace = 0.4;
        public const double assists = 0.5;
        public const double offensiveRebounds = 0.3;
        public const double threePointPercentage = 0.8;
        public const double ftPercentage = 0.6;
        public const double offensiveRating = 0.9;
        #endregion

        #region defence
        public const double steals = 0.5;
        public const double blocks = 0.6;
        public const double fouls = 0.7;
        public const double defensiveRebounds = 0.8;
        public const double defensiveRating = 0.9;
        #endregion

        public const double totalPossiblePoints = pace + assists + offensiveRebounds + threePointPercentage + ftPercentage + offensiveRating + 
                                     steals + blocks + fouls + defensiveRebounds + defensiveRating;

        //public double getTotalPossiblePoints() { return totalPossiblePoints; }
    }
}
