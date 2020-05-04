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

        public Country ReadCountryFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(',');

            string name = parts[0];
            string code = parts[1];
            string region = parts[2];
            int population = int.Parse(parts[3]);

            return new Country(name, code, region, population);
        }
    }
}