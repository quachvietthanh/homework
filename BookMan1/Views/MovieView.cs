using System;
using System.Collections.Generic;
using BookMan1.Models;

namespace BookMan1.Views
{
    public class MovieView
    {
        public void DisplayMovies(List<Movie> movies)
        {
            Console.WriteLine("=== Movie List ===");
            foreach (var movie in movies)
            {
                Console.WriteLine($"ID: {movie.Id}, Title: {movie.Title}, Genre: {movie.Genre}, Director: {movie.Director}, Year: {movie.ReleaseYear}");
            }
        }

        public Movie GetMovieInput()
        {
            Console.WriteLine("Enter movie details:");
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Genre: ");
            string genre = Console.ReadLine();
            Console.Write("Director: ");
            string director = Console.ReadLine();
            Console.Write("Release Year: ");
            int year = int.Parse(Console.ReadLine());

            return new Movie
            {
                Id = new Random().Next(1, 1000), // Auto-generate ID for simplicity
                Title = title,
                Genre = genre,
                Director = director,
                ReleaseYear = year
            };
        }

        public int GetMovieIdInput()
        {
            Console.Write("Enter Movie ID: ");
            return int.Parse(Console.ReadLine());
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}