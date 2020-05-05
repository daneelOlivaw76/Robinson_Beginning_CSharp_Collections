using System;
using System.Collections.Generic;
using static System.Console;

namespace Pluralsight.BegCShCollections.ReadCountriesForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Rui Reis\program\learning\dotnet\pluralsight\Robinson_Beginning_CSharp_Collections\code\Pop by Largest Final.csv";

            // Country[] countries = reader.ReadFirstNCountries(10);

            CsvReader reader = new CsvReader(filePath);
            List<Country> countries = reader.ReadAllCountries();
            reader.RemoveCommaCountries(countries);

            WriteLine("Enter no. of countries to display> ");
            bool inputIsInt = int.TryParse(ReadLine(), out int userInput);
            if(!inputIsInt || userInput < 0)
            {
                WriteLine("You must type in a positive integer. Exiting...");
                return;
            }

            int i = 0;
            //int j = 0;
            //foreach (Country country in countries)

            for (i = 0; i < countries.Count; i++)
            //for (i = countries.Count - 1; i >= 0; i--)
            {
                //if (j > 0 && (j % userInput == 0))
                if (i > 0 && (i % userInput == 0))
                {
                    WriteLine($"Listed {i} countries.");
                    WriteLine("Hit return to continue, anything else to quit> ");
                    if (ReadLine() != "")
                        break;
                }
                Country country = countries[i];
                //WriteLine($"{j++ + 1, -3}: {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: { country.Name}");
                WriteLine($"{i + 1,-3}: {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: { country.Name}");
            }            
        }
    }
}
