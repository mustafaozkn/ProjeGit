using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Book.Mvc.Entity
{
    public class DataContext:DbContext
    {
        public DataContext():base("dataConnection")
        {
            Database.SetInitializer(new DataInitializer());

        }
        public DbSet<Kitap>  Kitaplar { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}