using System;
using System.Collections.Generic;

namespace Test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = $@"C:\Users\Admin\desktop\Test\Test_3\country.csv";
            var csv = new CsvReader(path);
           
            csv.ReadAllCountry();
            foreach (var item in csv.Countrylist.Values)
            {
                Console.Write($"{item.Name} \t {item.Code} \t {item.Continent} \t {item.Population} \n");

            }
            Console.ReadLine();
        }

       
        
    }
}
