namespace MvcMovie.Migrations
{
    using MvcMovie.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MvcMovieContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcMovie.Models.MvcMovieContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Films.AddOrUpdate(i => i.Title,
        new Film
        {
            Title = "Sisterhood of the Treaveling Pants",
            ReleaseDate = DateTime.Parse("2005-1-11"),
            Genre = "Romantic Comedy",
            Price = 7.99M
        },

        new Film
        {
            Title = "The Thing",
            ReleaseDate = DateTime.Parse("1984-3-13"),
            Genre = "Horror",
            Price = 8.99M
        },

        new Film
        {
            Title = "Bridesmaids",
            ReleaseDate = DateTime.Parse("2012-2-23"),
            Genre = "Comedy",
            Price = 19.99M
        },

        new Film
        {
            Title = "Brave",
            ReleaseDate = DateTime.Parse("1959-4-15"),
            Genre = "Family",
            Price = 3.99M
        });
        }
    }
}
