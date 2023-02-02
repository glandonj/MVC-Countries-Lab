using System;
namespace MVC_Countries
{
	public class CountryController
	{
		List<Country> CountryDb = new List<Country>()
		{
			new Country("USA", "North America", new List<string>{"Red", "White", "Blue"}),
			new Country("Georgia", "Europe/Asia", new List<string>{"Red", "White"}),
			new Country("Brazil", "South America", new List<string>{"Green", "Yellow", "Blue"}),
			new Country("Russia", "Asia/Europe", new List<string>{"White", "Blue", "Red"}),
			new Country("Mexico", "North America", new List<string>{"Green", "White", "Red"}),
			new Country("New Zealand", "Oceania", new List<string>{"Black", "White", "Red"}),
			new Country("Italy", "Europe", new List<string>{ "Green", "White", "Red"}),
			new Country("Zimbabwe", "Africa", new List<string>{ "Black", "Yellow","Red", "Green", "White"}),
			new Country("China", "Asia", new List<string>{"Red", "Yellow"}),
			new Country("Antartica", "The Frozen Continent", new List<string>{"White", "Blue", "Gray" })
		};

		public void CountryAction(Country c)
		{
			CountryView view = new CountryView(c);
			view.Display();
		}

		public void WelcomeAction()
		{
			CountryListView viewlist = new CountryListView(CountryDb);
			Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list: ");
			viewlist.Display();
			int choice = -1;
			while (choice < 0 || choice > CountryDb.Count - 1)
			{
				while (int.TryParse(Console.ReadLine(), out choice) == false)
                {
					Console.WriteLine("Invalid input");
				}
				if (choice < 0 || choice > CountryDb.Count - 1)
				{
					Console.WriteLine("Number out of range.");
				}
			}
			Console.Clear();
			CountryAction(CountryDb.ElementAt(choice));
		}
	}
}
