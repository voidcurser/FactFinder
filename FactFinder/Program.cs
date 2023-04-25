// See https://aka.ms/new-console-template for more information


using FactFinderBL;
using Microsoft.AspNetCore.Components.Forms;

int choice = 0;
while (choice != 3)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Question 1");
    Console.WriteLine("2. Question 2");
    Console.WriteLine("3. Quit");

    Console.Write("Enter your choice: ");
    if (int.TryParse(Console.ReadLine(), out choice))
    {
        var input = string.Empty;
        switch (choice)
        {
            case 1:
                Console.Write("Enter string you want to get the middle character: ");
                input = Console.ReadLine();
                if (input is not null)
                    Console.WriteLine($"{input.GetMiddle()}");
                else
                    Console.WriteLine("has to be a valid string!");
                Console.WriteLine($"{input}");
                break;
            case 2:
                Console.Write("Enter string you want to get the Header HTML: ");
                input = Console.ReadLine();
                if (input is not null)
                    Console.WriteLine($"{input.GetHTMLHeader()}");
                else
                    Console.WriteLine("has to be a valid string!");
                break;
            case 3:
                Console.WriteLine("Bye!");
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid choice");
    }
}
Console.ReadKey();
