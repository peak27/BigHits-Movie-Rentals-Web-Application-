using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BigHits.Models
{
    public class MovieContext : DbContext
    {

        public MovieContext() : base("BigHits")
        {
            Database.SetInitializer(new MovieDatabaseInitializer());

        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        //public DbSet<EmailFormModel> ContactUs { get; set; }
    }
}