using MVC_Countries;
bool runProgram = true;
while (runProgram)
{
    CountryController controller = new CountryController();
    Console.Clear();
    controller.WelcomeAction();
    while (true)
    {
        Console.WriteLine("\n\nWould you like to learn about another country? y/n");
        string result = Console.ReadLine().ToLower().Trim();
        if (result == "y" || result == "yes")
        {
            runProgram = true;
            break;
        }
        else if (result == "n" || result == "no")
        {
            Console.WriteLine("Goodbye!");
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}




Console.ReadLine();

