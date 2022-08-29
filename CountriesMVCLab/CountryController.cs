using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesMVCLab
{
    public class CountryController
    {

        public List<Country> CountryDb { get; set; } = new List<Country>()
        {
            new Country("Albania", "Europe", new List<string>(){"Red", "Black" }),
            new Country("Angola", "Africa", new List<string>(){"Red", "Black", "Gold" }),
            new Country("Bahrain", "Asia", new List<string>(){"Red", "White" }),
            new Country("Belize", "North America", new List<string>(){"Red", "Blue", "White", "Green" }),
            new Country("Bolivia", "South America", new List<string>(){"Red", "Yellow", "Green" }),
            new Country("Cameroon", "Africa", new List<string>(){"Red", "Green", "Yellow" }),
            new Country("Ecuador", "South America", new List<string>(){"Red", "Blue", "Yellow" }),
            new Country("Denmark", "Europe", new List<string>(){"Red", "White" }),
            new Country("Japan", "Asia", new List<string>(){"Red", "White" }),
            new Country("Jordan", "Asia", new List<string>(){"Red", "Black", "Green", "White" }),
            new Country("Kuwait", "Asia", new List<string>(){"Red", "Black", "Green", "White" }),
            new Country("Laos", "Asia", new List<string>(){"Red", "Blue", "White" }),
            new Country("Madagascar", "Africa", new List<string>(){"Red", "White", "Green" }),
            new Country("Mali", "Africa", new List<string>(){"Red", "Yellow", "Green" }),
            new Country("Monaco", "Europe", new List<string>(){"Red", "White" }),
            new Country("Poland", "Europe", new List<string>(){"Red", "White" }),
            new Country("Syria", "Asia", new List<string>(){"Red", "Black", "White", "Green" }),
            new Country("The United States", "North America", new List<string>(){"Red", "White", "Blue" })
        };

        public void CountryAction(Country c)
        {
         
            var countryView = new CountryView(c);
            countryView.Display();
        }
        public void WelcomeAction()
        {
            string nextChoice = "y";
            while (nextChoice == "y")
            {
                var listView = new CountryListView(CountryDb);
                Console.WriteLine("Hello, welcome to the country app.  Please select a country from the following list:");
                listView.Display();
                Console.WriteLine("Please select a country by using the associated number.");
                int selection = int.Parse(Console.ReadLine());
                Console.Clear();
                CountryAction(CountryDb[selection - 1]);
                Console.WriteLine("Would you like to learn about another country? y/n");
                nextChoice = Console.ReadLine().ToLower();
                Console.Clear();
            }
        }

       
        
    }
}
