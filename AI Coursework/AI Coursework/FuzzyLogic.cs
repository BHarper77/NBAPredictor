using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FLS;
using FLS.Rules;

namespace AI_Coursework
{
    class FuzzyLogic
    {
        public void fuzzify(double value)
        {
            //Declaring linguistic variable for input membership function
            var diff = new LinguisticVariable("diff");
            var low = diff.MembershipFunctions.AddZShaped("low", 0, (WeightingData.totalPossiblePoints / 2));
            var medium = diff.MembershipFunctions.AddGaussian("medium", 0, WeightingData.totalPossiblePoints);
            var high = diff.MembershipFunctions.AddSShaped("high", (WeightingData.totalPossiblePoints / 2), WeightingData.totalPossiblePoints);

            //Membership function for output
            var winSize = new LinguisticVariable("winSize");
            var close = winSize.MembershipFunctions.AddTriangle("close", 0, 1, 3);
            var small = winSize.MembershipFunctions.AddTriangle("small", 4, 1, 6);
            var big = winSize.MembershipFunctions.AddTriangle("big", 7, 1, 10);

            IFuzzyEngine fuzzyEngine = new FuzzyEngineFactory().Default();

            //Create and add rules
            var rule1 = Rule.If(diff.Is(low)).Then(winSize.Is(close));
            var rule2 = Rule.If(diff.Is(medium)).Then(winSize.Is(small));
            var rule3 = Rule.If(diff.Is(high)).Then(winSize.Is(big));
            fuzzyEngine.Rules.Add(rule1, rule2, rule3);

            //Get result using the diff between two scores
            var result = fuzzyEngine.Defuzzify(new { diff = value });
        }
    }
}
