using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Test_x2
{
    class CsvReader2
    {
        public string Path { get; set; }
        public Country[] CountryList { get; set; }
        public CsvReader2(string _Path)
        {
            Path = _Path;
        }

        public Country[] ReadNCountry(int number)
        {
            CountryList = new Country[number];
            var cr = new StreamReader(Path);
            cr.ReadLine();
            for (var i = 0; i < number; i++)
            {
                var str = cr.ReadLine();
                CountryList[i] = ReadCountryFromCsvLine(str);
            }
            cr.Close();
            return CountryList;

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
