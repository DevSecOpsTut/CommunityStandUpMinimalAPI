using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace MovieDb.Models
{

    public class MovieContext : DbContext
    {

        public MovieContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cast> Casts { get; set; }


    }


    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }

        public List<Cast> Cast { get; set; } = new();
    }
    public class Cast
    {
        public int CastId { get; set; }
        public string CastName { get; set; }
    }
}
