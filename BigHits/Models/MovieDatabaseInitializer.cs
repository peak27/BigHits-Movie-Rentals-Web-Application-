using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BigHits.Models
{
    public class MovieDatabaseInitializer : DropCreateDatabaseIfModelChanges<MovieContext>
    {

        protected override void Seed(MovieContext context)
        {
            GetGenres().ForEach(g => context.Genres.Add(g));
            GetMovies().ForEach(m => context.Movies.Add(m));
        }

        private static List<Genre> GetGenres()
        {
            var genres = new List<Genre>
            {
                new Genre
                {
                    GenreID = 1,
                    GenreType = "Action"
                },

                new Genre
                {
                    GenreID = 2,
                    GenreType = "Comedy"
                },

                new Genre
                {
                    GenreID = 3,
                    GenreType = "Crime"
                },

                new Genre
                {
                    GenreID = 4,
                    GenreType = "Si-Fi"
                },

            };

            return genres;
        }

        private static List <Movie> GetMovies()
        {
            var movies = new List<Movie>
            {

                    new Movie
                    {
                        MovieID = 1,
                        MoviesName = "Casino Royale",
                        ReYear = 2006,
                        Description = "James Bond goes on his first ever mission as a 00.",
                        UnitPrice = 9.99,
                        Rating = "P",
                        ImgPath = "~Image",

                        GenreID = 1

                    },

                //    new Movie
                //    {
                //        MovieID = 2,
                //        MoviesName = "Logan",
                //        ReYear = 2017,
                //        Description = "Logan is a 2017 American superhero film starring Hugh Jackman as the X-Men character Wolverine.",
                //        UnitPrice = 9.99,
                //        Rating = "P",
                //        ImgPath = "~Image",
                //        GenreID = 1

                //    },

                //    new Movie
                //    {
                //        MovieID = 3,
                //        MoviesName = "Thor: Ragnarok",
                //        ReYear = 2017,
                //        Description = "Imprisoned on the other side of the universe, the mighty Thor finds himself in a deadly gladiatorial contest that pits him against the Hulk, his former ally and fellow Avenger.",
                //        UnitPrice = 9.99,
                //        Rating = "P",
                //        ImgPath = "~Image",
                //        GenreID = 1

                //    },

                //    new Movie
                //    {
                //        MovieID = 4,
                //        MoviesName = "Dumb & Dumber",
                //        ReYear = 1994,
                //        Description = "Dumb and Dumber is a 1994 American comedy film directed by Peter Farrelly, who co-wrote the screenplay with Bobby Farrelly and Bennett Yellin. ",
                //        UnitPrice = 7.99,
                //        Rating = "PG",
                //        ImgPath = "~Image",
                //        GenreID = 2

                //    },

                //    new Movie
                //    {
                //        MovieID = 5,
                //        MoviesName = "The Hangover",
                //        ReYear = 2009,
                //        Description = "The Hangover is a 2009 American comedy film directed by Todd Phillips, co-produced with Daniel Goldberg, and written by Jon Lucas and Scott Moore.",
                //        UnitPrice = 7.99,
                //        Rating = "P",
                //        ImgPath = "~Image",
                //        GenreID = 2

                //    },

                //    new Movie
                //    {
                //        MovieID = 6,
                //        MoviesName = "Heat",
                //        ReYear = 1995,
                //        Description = "Heat is a 1995 American crime film written, produced and directed by Michael Mann, and starring Al Pacino, Robert De Niro and Val Kilmer.  ",
                //        UnitPrice = 6.99,
                //        Rating = "PG",
                //        ImgPath = "~Image",
                //        GenreID = 3

                //    },

                //    new Movie
                //    {
                //        MovieID = 7,
                //        MoviesName = "Sicario",
                //        ReYear = 2009,
                //        Description = "Sicario is a 2015 American crime film directed by Denis Villeneuve, written by Taylor Sheridan and starring Emily Blunt, Benicio del Toro, Josh Brolin, and Victor Garber. ",
                //        UnitPrice = 7.99,
                //        Rating = "PG",
                //        ImgPath = "~Image",
                //        GenreID = 3

                //    },

                //    new Movie
                //    {
                //        MovieID = 8,
                //        MoviesName = "Interstellar",
                //        ReYear = 2014,
                //        Description = "Interstellar is a 2014 science fiction film directed, co-written, and co-produced by Christopher Nolan. It stars Matthew McConaughey, Anne Hathaway, Jessica Chastain.",
                //        UnitPrice = 6.99,
                //        Rating = "P",
                //        ImgPath = "~Image",
                //        GenreID = 4

                //    },

                //    new Movie
                //    {
                //        MovieID = 9,
                //        MoviesName = "Inception",
                //        ReYear = 2015,
                //        Description = "Inception is a 2010 science fiction action film written, co-produced, and directed by Christopher Nolan, and co-produced by Emma Thomas.",
                //        Rating = "PG",
                //        ImgPath = "~Image",

                //        GenreID = 4

                //    },


            };
            return movies;
        }

    }
}