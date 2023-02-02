using System;
namespace MVC_Countries
{
	public class CountryListView
	{
		public List <Country> Countries { get; set; }

		public CountryListView(List<Country> _countries)
		{
			Countries = _countries;
		}

		public void Display()
		{
			int index = 0;
			foreach(Country c in Countries)
			{
                Console.WriteLine($"{index}: {c.Name}");
                index++;
            }
		}
	}
}

