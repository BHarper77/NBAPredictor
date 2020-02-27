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
        public double fuzzify(double value)
        {
            double points = WeightingData.totalPossiblePoints;

            //Declaring linguistic variable for input membership function
            var diff = new LinguisticVariable("diff");
            var low = diff.MembershipFunctions.AddTrapezoid("low", 0, 0, (points / 4), (points / 2));
            var medium = diff.MembershipFunctions.AddTriangle("medium", (points / 4), (points / 2), (points - (points / 4)));
            var high = diff.MembershipFunctions.AddTrapezoid("high", (points / 2), (points - (points / 4)), points, points);

            //Membership function for output
            var winSize = new LinguisticVariable("winSize");
            var close = winSize.MembershipFunctions.AddTrapezoid("close", 0, 0, 4, 6);
            var small = winSize.MembershipFunctions.AddTriangle("small", 4, 8, 12);
            var big = winSize.MembershipFunctions.AddTriangle("big", 10, 16, 22);
            var blowout = winSize.MembershipFunctions.AddTrapezoid("blowout", 18, 22, 40, 40);

            IFuzzyEngine fuzzyEngine = new FuzzyEngineFactory().Default();

            //Create and add rules
            var rule1 = Rule.If(diff.Is(low)).Then(winSize.Is(close));
            var rule2 = Rule.If(diff.Is(medium)).Then(winSize.Is(small));
            var rule3 = Rule.If(diff.Is(high)).Then(winSize.Is(big));
            var rule4 = Rule.If(diff.Is(blowout)).Then(winSize.Is(big));
            fuzzyEngine.Rules.Add(rule1, rule2, rule3, rule4);

            //Get result using the diff between two scores
            var result = fuzzyEngine.Defuzzify(new { diff = value });

            return Math.Round(result);
        }
    }
}
