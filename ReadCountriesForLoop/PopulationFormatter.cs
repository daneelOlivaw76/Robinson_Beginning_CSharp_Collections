using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.BegCShCollections.ReadCountriesForLoop
{
    class PopulationFormatter
    {
        public static string FormatPopulation(int population)
        {
            if (population == 0)
                return "(Unknown)";

            int popRounded = RoundPopulation4(population);
            return $"{popRounded:### ### ### ###}".Trim();
        }

        private static int RoundPopulation4(int population)
        {
            int accuracy = Math.Max((int)(GetHighestPowerofTen(population) / 10_000L), 1);

            return RoundToNEarest(population, accuracy);
        }

        private static int RoundToNEarest(int population, int accuracy)
        {
            int adjusted = population + accuracy / 2;
            return adjusted - adjusted % accuracy;
        }

        private static long GetHighestPowerofTen(int population)
        {
            long result = 1;
            while (population > 0)
            {
                population /= 10;
                result *= 10;
            }
            return result;
        }
    }
}
