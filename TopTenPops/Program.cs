using System;
using System.Reflection.PortableExecutable;

namespace Pluralsight.BegCShCollections.IntroColls.TopTenPops
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Rui Reis\program\learning\dotnet\pluralsight\Robinson_Beginning_CSharp_Collections\code\Pop by Largest Final.csv";

            CsvReader reader = new CsvReader(filePath);

            Country[] countries = reader.ReadFirstNCountries(10);

            foreach (Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: { country.Name}");
            }
        }
    }
}
