using System;
using System.Collections.Generic;
using static System.Console;


namespace Pluralsight.BegCShCollections.CountriesByRegion
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Rui Reis\program\learning\dotnet\pluralsight\Robinson_Beginning_CSharp_Collections\code\Pop by Largest Final.csv";

            CsvReader reader = new CsvReader(filePath);
            var countries = reader.ReadAllCountries();

            foreach (string region in countries.Keys)
                WriteLine(region);

            Write("Which of the above regions do you want? ");
            string chosenRegion = ReadLine();

            if (countries.ContainsKey(chosenRegion))
            {
                foreach (Country country in countries[chosenRegion].GetRange(0,10))
                {
                    Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: { country.Name.PadRight(35)} - " +
                        $"{country.Region}");
                }
            }
            else
            {
                WriteLine("That is not a valid region. Exiting...");
            }
        }
    }
}
