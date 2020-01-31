using System;
using System.Collections.Generic;

namespace Lab10_MovieApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int userCategorySelect;
            string userContinue = "y";
            //bool userContinue;

            List<Movie> movies = new List<Movie>
            {
                new Movie("Terminator", "Scifi", 1), new Movie("Terminator II", "Scifi", 1), new Movie("Terminator III Rise of the Machines", "Scifi", 1),
                new Movie("Lost in Space", "Scifi", 1), new Movie("Texas Chainsaw Massacre", "Horror", 2), new Movie("Childs Play", "Horror", 2),
                new Movie("Holloween", "Horror", 2), new Movie("Jeepers Creeprs", "Horror", 2), new Movie("Power Rangers", "Scifi", 1),
                new Movie("The Great Mouse Detective", "Animated", 3), new Movie("Rocky I", "Drama", 4), new Movie("Rocky II", "Drama", 4),
                new Movie("Rocky III", "Drama", 4), new Movie("Rocky IV", "Drama", 4), new Movie("Rocky V", "Drama", 4), new Movie("Rocky Balboa", "Drama", 4),
                new Movie("Creed I", "Drama", 4), new Movie("Creed II", "Drama", 4), new Movie("Good Will Hunting", "Drama", 4)
            };

            while(userContinue == "y")
            {
                Movie.PrintCategories(movies);
                userCategorySelect = GetUserInput($"ENTER A NUMBER THAT CORRESPONDS TO THE ABOVE CATEGORIES TO VIEW A LIST OF AVAILABLE MOVIES: ", movies.Count);
                userContinue = Movie.PrintMovies(4, userCategorySelect, movies);
            }
        }

        public static string GetUserInput(string message)
        {
            string userInput;
            Console.WriteLine(message);
            userInput = Console.ReadLine();

            return userInput;
        }

        public static int GetUserInput(string message, int i)
        {
            string userInput;
            Console.WriteLine(message);
            userInput = Console.ReadLine();
            int value = ValidateUserInput(userInput, i);

            return value;
        }

        public static int ValidateUserInput(string userInput, int categoryNum)
        {
            int categoryOption;

            try
            {
                categoryOption = int.Parse(userInput);
                //return categoryOption;
            }

            catch (FormatException)
            {
                return ValidateUserInput(GetUserInput("Could not parse your entry to an int.  Make sure you're entering in a number"), categoryNum);
            }
            if (categoryOption >= 1 && categoryOption <= categoryNum)
            {
                return categoryOption;
            }
            else
            {
                return ValidateUserInput(GetUserInput("Value is not a valid option.  Please select a number between 1 and {categoryNum}"), categoryNum);
            }

        }
    }
}
