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
            // Ensure DLL is copied.
            //SqlProviderServices ensureDLLIsCopied = (SqlProviderServices.Instance);
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}
