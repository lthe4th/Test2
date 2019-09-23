using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace test
{
    class CsvReader
    {
       public string Path { get; set; }
        public List<Country> CountryList { get; set; }

        public CsvReader(string _path)
        {
            Path = _path;
        }

        public List<Country> readAllCountry()
        {
            CountryList = new List<Country>();
            var cr = new StreamReader(Path);
            cr.ReadLine();
            string perString;
            while ((perString = cr.ReadLine()) != null)
            {
                CountryList.Add(ReadCountyFromCvsLine(perString));
            }
              cr.Close();
            return CountryList;
        }

        private Country ReadCountyFromCvsLine(string str)
        {
            string[] stp = str.Split(",");

            Country _country;

            if (stp.Length > 4)
            {
                string Name = stp[0] + "," + stp[1];
                Name = Name.Replace("\"", null);
                return _country = new Country(Name, stp[2], stp[3], int.Parse(stp[4]));

            }
            if (stp[3] == "..")
            {
                return _country = new Country(stp[0], stp[1], stp[2], 0);
            }

            return _country = new Country(stp[0], stp[1], stp[2], int.Parse(stp[3]));
        }

    }
}
