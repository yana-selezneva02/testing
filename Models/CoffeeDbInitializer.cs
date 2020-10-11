using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Cinema.Models
{
    public class CoffeeDbInitializer : DropCreateDatabaseAlways<CoffeeContext>
    {
        protected override void Seed(CoffeeContext db)
        {
            db.Coffee.Add(new Coffee { Volume = 120, Name = "Фраппуччино", Price = 150 });
            db.Coffee.Add(new Coffee { Volume = 250, Name = "Капучино", Price = 100 });
            db.Coffee.Add(new Coffee { Volume = 110, Name = "Ванильно-сливочный Фраппуччино", Price = 120 });
           

            base.Seed(db);
        }
    }
}