using ApplicationTemplate.Models;
using System;

namespace ApplicationTemplate.Services;

/// <summary>
///     You would need to inject your interfaces here to execute the methods in Invoke()
///     See the commented out code as an example
/// </summary>
public class MainService : IMainService
{

    public MainService()
    {

    }
    public void Invoke()
    {
        Media media1 = new Movie();
        Media media2 = new Show();
        Media media3 = new Video();

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Display Movies");
            Console.WriteLine("2. Display Shows");
            Console.WriteLine("3. Display Videos");
            Console.WriteLine("4. Quit\n");
            var choice = Console.ReadLine();



            if (choice == "1")
            {
                media1.Display();
            }
            else if (choice == "2")
            {
                media2.Display();
            }
            else if (choice == "3")
            {
                media3.Display();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("That is not an input");
            }
        }

    }
}