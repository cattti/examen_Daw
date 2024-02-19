using System;
using Microsoft.EntityFrameworkCore;
using examen.Models;
namespace examen.Data
{
    public class clasaContext : DbContext
    {


        public DbSet<Actor> Actors { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Actor_Film> Actors_Films {get; set;}


    public clasaContext(DbContextOptions<clasaContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelbuilder)
    {


            modelbuilder.Entity<Actor_Film>()
                .HasKey(af => new { af.ActorId, af.FilmId });

            modelbuilder.Entity<Actor_Film>()
                .HasOne(af => af.Actor)
                .WithMany(a => a.Actors_Films)
                .HasForeignKey(af => af.ActorId);

            modelbuilder.Entity<Actor_Film>()
                .HasOne(af => af.Film)
                .WithMany(f => f.Actors_Films)
                .HasForeignKey(af => af.FilmId);



            base.OnModelCreating(modelbuilder);
    }

    }
}