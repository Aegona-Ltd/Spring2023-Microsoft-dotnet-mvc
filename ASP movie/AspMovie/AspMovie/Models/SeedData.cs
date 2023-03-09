
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;
namespace AspMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AspMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AspMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        RelesaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Rating = "R",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        RelesaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Rating = "C",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        RelesaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Rating = "C",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        RelesaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Rating = "W",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}