using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Test_App.Models.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Actor_Movie> Actor_Movies { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new { am.ActorId, am.MovieId });

            modelBuilder.Entity<Actor_Movie>().HasOne(am => am.Actor).WithMany(act => act.Actor_Movies).HasForeignKey(am => am.ActorId);

            modelBuilder.Entity<Actor_Movie>().HasOne(am => am.Movie).WithMany(act => act.Actor_Movies).HasForeignKey(am => am.MovieId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
