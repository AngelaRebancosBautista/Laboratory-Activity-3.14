using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<(string Country, string Capital)> countries = new List<(string, string)>
        {
            ("Italy", "Rome"),
            ("Mexico", "Mexico City"),
            ("Philippines", "Manila"),
            ("Japan", "Tokyo"),
            ("Australia", "Canberra"),
            ("India", "New Delhi"),
            ("Canada", "Ottawa"),
            ("Brazil", "Brasília"),
            ("France", "Paris"),
            ("Germany", "Berlin"),
        };
            Console.Write("Enter a country name: ");
            string input = Console.ReadLine();

            bool found = false;
            foreach (var pair in countries)
            {
                if (pair.Country.Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"\nCapital of {pair.Country} is {pair.Capital}");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("\nCountry not found.");
            }
        }
    }
}

       
