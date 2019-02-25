using StellarCoffeeData.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StellarCoffeeData.Context 
{
    public class StellarCoffeeDbContext : DbContext
    {
        public StellarCoffeeDbContext() : base("Data Source=192.168.1.181;Initial Catalog=StellarCoffee;Persist Security Info=True;User ID=stellarcoffee;Password=A1!2@3#4$")
        {

        }

        public virtual DbSet<Product> Products { get; set; }
    }
}
