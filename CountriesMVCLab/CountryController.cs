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
            new Country("Albania", "continent", new List<string>(){"Red", "Black" }),
            new Country("Angola", "continent", new List<string>(){"Red", "Black", "Gold" }),
            new Country("Bahrain", "continent", new List<string>(){"Red", "White" }),
            new Country("Belize", "continent", new List<string>(){"Red", "Blue", "White", "Green" }),
            new Country("Bolivia", "continent", new List<string>(){"Red", "Yellow", "Green" }),
            new Country("Cameroon", "continent", new List<string>(){"Red", "Green", "Yellow" }),
            new Country("Ecuador", "continent", new List<string>(){"Red", "Blue", "Yellow" }),
            new Country("Denmark", "continent", new List<string>(){"Red", "White" }),
            new Country("Japan", "continent", new List<string>(){"Red", "White" }),
            new Country("Jordan", "continent", new List<string>(){"Red", "Black", "Green", "White" }),
            new Country("Kuwait", "continent", new List<string>(){"Red", "Black", "Green", "White" }),
            new Country("Laos", "continent", new List<string>(){"Red", "Blue", "White" }),
            new Country("Madagascar", "continent", new List<string>(){"Red", "White", "Green" }),
            new Country("Mali", "continent", new List<string>(){"Red", "Yellow", "Green" }),
            new Country("Monaco", "continent", new List<string>(){"Red", "White" }),
            new Country("Poland", "continent", new List<string>(){"Red", "White" }),
            new Country("Syria", "continent", new List<string>(){"Red", "Black", "White", "Green" }),
            new Country("The United States", "continent", new List<string>(){"Red", "White", "Blue" })
        };

        public void CountryAction(Country c)
        {
            int selection = GetSelection();
            var countryView = new CountryView(CountryDb[selection - 1]);
            countryView.Display();
        }
        public void WelcomeAction()
        {
            var listView = new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app.  Please select a country from the following list:");
            listView.Display();
            GetSelection();
            CountryActon();
            
            
            

            Console.WriteLine("Would you like to learn about another country? y/n");
        }

        public int GetSelection()
        {
            Console.WriteLine("Please select a country by using the associated number.");
            return int.Parse(Console.ReadLine());
        }
    }
}
