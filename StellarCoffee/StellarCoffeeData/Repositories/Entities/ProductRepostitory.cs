using StellarCoffeeData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StellarCoffeeData.Repositories.Entities
{
    public class ProductRepostitory : BaseRepository<Product>
    {
        public IEnumerable<Product> Search(string stringSearch)
        {
            IEnumerable<Product> products = Context.Products.Where(
                product => product.Name.Contains(stringSearch)
            )
            .OrderBy(product => product.Name);

            return products;
        }
    }
}
