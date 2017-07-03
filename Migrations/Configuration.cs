namespace CreatingDB_ASPNET_MVC.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CreatingDB_ASPNET_MVC.MovieDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "CreatingDB_ASPNET_MVC.MovieDb";
        }

        protected override void Seed(CreatingDB_ASPNET_MVC.MovieDb context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
        new Movies
        {
            Title = "When Harry Met Sally",
            ReleaseDate = DateTime.Parse("1989-1-11"),
            Genre = "Romantic Comedy",
            Price = 7.99M,
            Rating="G"
        },

         new Movies
         {
             Title = "Ghostbusters ",
             ReleaseDate = DateTime.Parse("1984-3-13"),
             Genre = "Comedy",
             Price = 8.99M,
             Rating = "G"
         },

         new Movies
         {
             Title = "Ghostbusters 2",
             ReleaseDate = DateTime.Parse("1986-2-23"),
             Genre = "Comedy",
             Price = 9.99M,
             Rating = "G"
         },

       new Movies
       {
           Title = "Rio Bravo",
           ReleaseDate = DateTime.Parse("1959-4-15"),
           Genre = "Western",
           Price = 3.99M,
           Rating = "G"
       }
   );
        }
    }
}
