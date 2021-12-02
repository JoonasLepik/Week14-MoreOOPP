﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace MoviesFromFile
{
    class Program
    {        
        class Movie
        {
            string name;
            string rating;
            string year;
            public Movie(string _name, string _rating, string _year )
            {
                name = _name;
                rating = _rating;
                year = _year;
            }
            public string Name
            {
                get { return name; }

            }
            public string Rating
            {
                get { return rating; }

            }
            public string Year
            {
                get { return year; }

            }

        }
        static void Main(string[] args)
        {
            List<string> movieListFromFile = getMoviesFromFile().ToList();
            List<Movie> listOfMovies = new List<Movie>();
            foreach(string movieRecord in movieListFromFile)
            {
                string[] tempArray = movieRecord.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                Movie newMovie = new Movie(tempArray[0], tempArray[1], tempArray[2]);
                listOfMovies.Add(newMovie);
            }
            foreach (Movie movie in listOfMovies)
            {
                Console.WriteLine($"Title: {movie.Name} - Rating: {movie.Rating} stars - Year: {movie.Year}");
            }
        }
        public static string[] getMoviesFromFile()
        {
            string filepath = @"C:\Users\opilane\samples\Movies.txt";
            string[] dataFromFile = File.ReadAllLines(filepath);
            return dataFromFile;
        }
        public static void ShowDataFromArray(string[] someArray)
        {
            foreach(string line in someArray)
            {
                Console.WriteLine(line);
            }
        }

    }
}
