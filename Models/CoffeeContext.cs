using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;

namespace Cinema.Models
{
    public class CoffeeContext : DbContext
    {
        public DbSet<Coffee> Coffee { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}