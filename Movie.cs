using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_MovieApp
{
    class Movie
    {
        private string title;
        private string category;
        private int intCategory;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public int IntCategory
        {
            get { return intCategory; }
            set { intCategory = value; }
        }

        public Movie(string title, string category, int intCategory)
        {
            this.title = title;
            this.category = category;
            this.intCategory = intCategory;
        }

        //public static string GetUserInput(string message)
        //{
        //    string userInput;
        //    Console.WriteLine(message);
        //    userInput = Console.ReadLine();

        //    return userInput;
        //}

        //public static int GetUserInput(string message, int i)
        //{
        //    string userInput;
        //    Console.WriteLine(message);
        //    userInput = Console.ReadLine();
        //    int value = ValidateUserInput(userInput, i);

        //    return value;
        //}

        //public static int ValidateUserInput(string userInput, int categoryNum)
        //{
        //    int categoryOption;
            
        //    try
        //    {
        //        categoryOption = int.Parse(userInput);
        //        //return categoryOption;
        //    }

        //    catch (FormatException)
        //    {
        //        return ValidateUserInput(GetUserInput("Could not parse your entry to an int.  Make sure you're entering in a number"), categoryNum);
        //    }
        //    if (categoryOption >= 1 && categoryOption <= categoryNum)
        //    {
        //        return categoryOption;
        //    }
        //    else
        //    {
        //        return ValidateUserInput(GetUserInput("Value is not a valid option.  Please select a number between 1 and {categoryNum}"), categoryNum);
        //    }

        //}

        private static List<string> GetCategories(List<Movie> movies)
        {
            List<string> categories = new List<string>();
            
            foreach(Movie cat in movies)
            {
                if(!categories.Contains(cat.category))
                {
                    categories.Add(cat.category.ToString());
                }
            }

            return categories;
        }

        public static void PrintCategories(List<Movie> movies)
        {
            List<string> categories = new List<string>();
            
            categories = GetCategories(movies);
            
            int i = 1;
            Console.WriteLine("MOVIE CATEGORY LISTING");
            Console.WriteLine("======================");
            
            foreach(string cat in categories)
            {
                Console.WriteLine($"{i}. {cat}");
                i++;
            }
        }

        public static string PrintMovies( int maxEntry, int category, List<Movie> movies)
        {
           
            string Continue;
            if (category <= maxEntry) 
            {
                Console.WriteLine($"AVAILABLE MOVIES FOR THE SELECTED CATEGORY: ");
                Console.WriteLine("===========================================");
                foreach (Movie movie in movies)
                {
                    if (movie.intCategory == category)
                    {
                        Console.WriteLine(movie.title);
                    }
                }
                Console.WriteLine("Would you like to look up another category? y/n: ");
                Continue = Console.ReadLine();
                while (Continue != "y" && Continue != "n")
                {
                    Console.WriteLine("Please enter y to continue or n to exit the program: ");
                    Continue = Console.ReadLine();
                }

                return Continue;
            }
            else
            {
                Console.WriteLine("That category does not exist.  Would you like to continue? y/n: ");
                Continue = Console.ReadLine();
                while (Continue != "y" && Continue != "n")
                {
                    Console.WriteLine("Please enter y to continue or n to exit the program: ");
                    Continue = Console.ReadLine();
                }

                return Continue;
            }
        }
    }
}
