using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Continent { get; set; }
        public int Population { get; set; }
       public Country(String _name, string _code, string _continent, int _population)
        {
            Name = _name;
            Code = _code;
            Continent = _continent;
            Population = _population;
        }
    }
}
