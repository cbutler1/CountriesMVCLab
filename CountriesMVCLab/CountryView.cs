using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesMVCLab
{
    public class CountryView
    {
        public CountryView(Country country)
        {
            DisplayCountry = country;
        }
        public Country DisplayCountry { get; set; }
        public void Display()
        {
            string colors = "";
            DisplayCountry.Colors.ForEach(i => colors += i + ", ");
            Console.WriteLine("Country Name: " + DisplayCountry.Name);
            Console.WriteLine("Continent: " + DisplayCountry.Continent);
            Console.WriteLine("Flag Colors: " + colors);
            Console.WriteLine();
        }
    }
}
