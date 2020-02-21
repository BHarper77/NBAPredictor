using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Coursework
{
    class FuzzyLogic
    {
        //double totalPossiblePoints = 7.18;

        public struct winChance
        {
            public const double bigLoss = -5;
            public const double smallLoss = -2.5;
            public const double smallWin = 2.5;
            public const double bigWin = 5;
        }

        public void fuzzify(double[] finalScores)
        {
            double diff = Math.Abs(finalScores[0] - finalScores[1]);


        }
    }
}
