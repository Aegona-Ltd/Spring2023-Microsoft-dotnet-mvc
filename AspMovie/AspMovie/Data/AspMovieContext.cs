using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspMovie.Models;

namespace AspMovie.Data
{
    public class AspMovieContext : DbContext
    {
        public AspMovieContext (DbContextOptions<AspMovieContext> options)
            : base(options)
        {
        }

        public DbSet<AspMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
