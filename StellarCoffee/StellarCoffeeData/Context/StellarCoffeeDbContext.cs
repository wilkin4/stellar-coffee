using StellarCoffeeData.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StellarCoffeeData.Context
{
    public class StellarCoffeeDbContext : DbContext
    {
        public StellarCoffeeDbContext() : base("StellarCoffee")
        {

        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ReceiptType> ReceiptTypes { get; set; }
    }
}
