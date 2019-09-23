using System;

namespace Test_x2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = $@"C:\Users\Admin\Desktop\Test\Test_x2\country.csv";
            var csv = new CsvReader2(Path);
            csv.ReadNCountry(10);
            var x = new Country("x", "y", "z", 10);
            //AddCountryFrom(csv.CountryList, x);

            foreach (var item in csv.CountryList)
            {
                Console.Write($"{item.Name} \t {item.Code} \t {item.Continent} \t {item.Population} \n");
            }
            Console.ReadKey();
        }

        //private static void AddCountryFrom(Country[] list, Country x)
        //{
        //    Console.WriteLine("after what country ?");
        //    string _country = Console.ReadLine();
        //    bool found = false;
        //    for (var i = 0; i < list.Length - 1; i++)
        //    {
        //        if (list[i].Name == _country)
        //        {
        //            var listt = new Country[100];
        //            list = listt;
                    
        //        }

        //    }
        //}
    }
}
