using System;
using System.Collections.Generic;
using System.IO;

namespace Pluralsight.BegCShCollections.IntroColls.TopTenPops
{
    internal class CsvReader
    {
        private string _csvFilePath;

        public CsvReader(string csvFilePath)
        {
            this._csvFilePath = csvFilePath;
        }

        public Country[] ReadFirstNCountries(int nCountries)
        {
            Country[] countries = new Country[nCountries];

            using (var reader = new StreamReader(this._csvFilePath))
            {
                // read header line
                reader.ReadLine();

                for(int i = 0; i < nCountries; i++)
                {
                    string line = reader.ReadLine();
                    countries[i] = ReadCountryFromCsvLine(line);

                }
            }
            return countries;
        }

        public List<Country> ReadAllCountries()
        {
            List<Country> countries = new List<Country>();

            using (var reader = new StreamReader(this._csvFilePath))
            {
                // read header line
                reader.ReadLine();
                string line;

                while((line = reader.ReadLine()) != null)
                {
                    countries.Add(ReadCountryFromCsvLine(line));
                }
            }
            return countries;
        }

        public Country ReadCountryFromCsvLine(string csvLine)
        {
            string name;
            string code;
            string region;
            int population;
            string[] parts;

            string[] initParts = csvLine.Split('"');

            if (initParts.Length > 1)
            {
                name = initParts[1];
                csvLine = initParts[2];
            }
            else
            {
                name = csvLine.Split(',')[0];
            }
            parts = csvLine.Split(',');

            code = parts[1];
            region = parts[2];
            int.TryParse(parts[3], out population);

            return new Country(name, code, region, population);
        }
    }
}