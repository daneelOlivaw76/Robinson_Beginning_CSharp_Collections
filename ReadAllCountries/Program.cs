using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;


namespace Pluralsight.BegCShCollections.ReadAllCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Rui Reis\program\learning\dotnet\pluralsight\Robinson_Beginning_CSharp_Collections\code\Pop by Largest Final.csv";

            CsvReader reader = new CsvReader(filePath);
            List<Country> countries = reader.ReadAllCountries();

            //foreach (Country country in countries.GetRange(0, 20))
            foreach (Country country in countries.OrderBy(x => x.Name).ToList().GetRange(0,10))
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: { country.Name}");
            }

            //Console.WriteLine($"{countries.Count} countries.");
        }
    }
}
