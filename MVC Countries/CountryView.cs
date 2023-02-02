using System;
namespace MVC_Countries
{
	public class CountryView
	{
		public Country DisplayCountry { get; set; }

		public CountryView(Country _country)
		{
			DisplayCountry = _country;
		}

		public void Display()
		{
			Console.WriteLine($"Name: {DisplayCountry.Name}\nContinent: {DisplayCountry.Continent}");
			Console.Write("Colors: ");
			foreach (string colors in DisplayCountry.Colors)
			{
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colors, true);
                Console.Write($"{colors} ");
				Console.ResetColor();
			}
		}
	}
}

