using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var csv = new CsvReader($@"C:\Users\Admin\Desktop\Test\test\country.csv");
            var x = new Country("x", "y", "z", 0);
            csv.readAllCountry();

            AddfromName(csv.CountryList, x);
            foreach (var item in csv.CountryList)
            {
                Console.Write($"{item.Name} \t {item.Code} \t {item.Continent} \t {item.Population} \n");
            }
            Console.ReadKey();

        }

        private static void AddfromName(List<Country> list, Country x)
        {
            Console.WriteLine("Add after which Country ? ");
            string _name = Console.ReadLine();
            bool found = false;
            foreach (var item in list)
            {
                if (item.Name == _name)
                {
                    int index = list.IndexOf(item);
                    list.Insert(index+1, x);
                    found = true;
                    break;
                }
                
            }
            if (!found)
            {
                Console.WriteLine("no such Country in List");
            }

        }
    }
}
