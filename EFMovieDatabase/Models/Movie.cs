using System;
using System.Collections.Generic;

namespace EFMovieDatabase.Models
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public double? Runtime { get; set; }

        public void SearchByGenre()
        {
            MoviesContext mc = new MoviesContext();
            Console.WriteLine("\nWhat genre are you searching for?");
            string input = Console.ReadLine();
            List<Movie> movieList = mc.Movies.Where(mov => mov.Genre.ToLower().Contains(input.ToLower())).ToList();

            foreach (Movie movie in movieList)
            {
                Console.WriteLine($"\nTitle: {movie.Title}\nGenre: {movie.Genre}\nRuntime: {movie.Runtime}");
            }
        }
        public void SearchByTitle()
        {
            MoviesContext mc = new MoviesContext();
            Console.WriteLine("What movie title would you like to search for?\nPlease select by ID.");
            int input = int.Parse(Console.ReadLine());

            Movie output = mc.Movies.Find(input);
            Console.WriteLine($"\nTitle: {output.Title}\nGenre: {output.Genre}\nRuntime: {output.Runtime}");
        }
    }
}
