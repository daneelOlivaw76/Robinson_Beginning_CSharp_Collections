using System;
using System.Collections.Generic;
using static System.Console;
using Pluralsight.BegCShCollections.IntroColls.TopTenPops;

namespace Pluralsight.BegCShCollections.DictSnippets
{
    class Program
    {
        static void Main(string[] args)
        {
            Country norway = new Country("Norway", "NOR", "EUROPE", 5_282_223);
            Country finland = new Country("Finland", "FIN", "EUROPE", 5_511_303);

            var countries = new Dictionary<string, Country>
            {
                {norway.Code, norway},
                {finland.Code, finland}
            };

            Country selectedCountry = countries["NOR"];
            WriteLine(selectedCountry.Name);

            foreach(var country in countries.Values)
            {
                WriteLine(country.Name);
            }

            bool exists = countries.TryGetValue("MUS", out Country c);

            if(exists)
            {
                WriteLine(c.Name);
            }
            else
            {

                WriteLine("There is no counry with the code MUS");
            }
        }
    }
}
