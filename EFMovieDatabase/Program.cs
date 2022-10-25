using EFMovieDatabase.Models;
using System.Runtime.Intrinsics.X86;

namespace EFMovieDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my movie database!");

            MoviesContext db = new MoviesContext();
            List<Movie> list = db.Movies.ToList();

            Movie m = new Movie();
            
            Console.WriteLine("\nWould you like to search for a movie by title or genre?");
            string input = Console.ReadLine().ToLower().Trim();
            if(input == "genre")
            {
                m.SearchByGenre();
            }
            else if (input == "title")
            {
                PrintMovies(list);
                m.SearchByTitle();
            }
            else
            {
                Console.WriteLine("I didn't understand that. Try again.");
                return;
            }
        }   
        public static void PrintMovies(List<Movie> movies)
        {
            Console.WriteLine("Here is our list of movies:");
            foreach(Movie movie in movies)
            {
                Console.WriteLine(movie.Id + " " + movie.Title);
            }
        }
    }
}