using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Sevices
{
    internal class OdeToFoodDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurant {get;set;}  
    }
}
