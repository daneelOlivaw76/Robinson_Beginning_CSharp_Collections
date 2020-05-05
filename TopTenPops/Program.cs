using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.PortableExecutable;

namespace Pluralsight.BegCShCollections.IntroColls.TopTenPops
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Rui Reis\program\learning\dotnet\pluralsight\Robinson_Beginning_CSharp_Collections\code\Pop by Largest Final.csv";

            CsvReader reader = new CsvReader(filePath);

            // Country[] countries = reader.ReadFirstNCountries(10);

            List<Country> countries = reader.ReadAllCountries();

            Country lilliput = new Country("Lilliput", "LIL", "Somewhere", 2_000_000);
            int lilliputIndex = countries.FindIndex(x => x.Population < 2_000_000);
            countries.Insert(lilliputIndex, lilliput);
            countries.RemoveAt(lilliputIndex);

            foreach (Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population),-15}: { country.Name}");
            }

            Console.WriteLine($"{countries.Count} countries.");
        }
    }
}
