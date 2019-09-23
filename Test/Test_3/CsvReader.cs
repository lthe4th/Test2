using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Test_3
{
    class CsvReader
    {
        public string path { get; set; }
        public Dictionary<string, Country> Countrylist = new Dictionary<string, Country>();
        public CsvReader(string _path)
        {
            path = _path;
        }

        public Dictionary<string, Country> ReadAllCountry()
        {
            var cr = new StreamReader(path);
            cr.ReadLine();
            string str;
            while ((str = cr.ReadLine()) != null)
            {
               Countrylist.Add(ReadCountryFromCsvLine(str).Code, ReadCountryFromCsvLine(str)) ;
            }
            cr.Close();
            return Countrylist;

        }

        private Country ReadCountryFromCsvLine(string str)
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
