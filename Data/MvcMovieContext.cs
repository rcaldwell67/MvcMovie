using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
        public DbSet<MvcMovie.Models.Wager> Wager { get; set; } = default!;
        public DbSet<MvcMovie.Models.Movie> BetSlips { get; set; } = default!;
        public DbSet<MvcMovie.Models.Movie> Leagues { get; set; } = default!;
        public DbSet<MvcMovie.Models.Movie> SiteProps { get; set; } = default!;
        public DbSet<MvcMovie.Models.Movie> Sports { get; set; } = default!;
        public DbSet<MvcMovie.Models.Movie> Sports_History { get; set; } = default!;
        public DbSet<MvcMovie.Models.Movie> SportsBooks { get; set; } = default!;
        public DbSet<MvcMovie.Models.Movie> SportsStats { get; set; } = default!;
        public DbSet<MvcMovie.Models.Movie> Teams { get; set; } = default!;
        public DbSet<MvcMovie.Models.Movie> Wager_History { get; set; } = default!;

    }
}
