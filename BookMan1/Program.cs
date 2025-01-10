using System;
using BookMan1.Controllers;

namespace BookMan1
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new MovieController();
            while (true)
            {
                Console.WriteLine("\n=== Movie Management Software ===");
                Console.WriteLine("1. Display all movies");
                Console.WriteLine("2. Add a new movie");
                Console.WriteLine("3. Delete a movie");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        controller.DisplayAllMovies();
                        break;
                    case "2":
                        controller.AddMovie();
                        break;
                    case "3":
                        controller.DeleteMovie();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}