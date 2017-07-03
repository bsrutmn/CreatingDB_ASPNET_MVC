using CreatingDB_ASPNET_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CreatingDB_ASPNET_MVC
{
    public class MovieDb:DbContext
    {
        public DbSet<Movies> Movies { get; set; }
        
    }
}