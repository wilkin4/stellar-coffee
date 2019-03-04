using StellarCoffeeData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StellarCoffeeData.Repositories.Entities
{
    public class ClientRepository : BaseRepository<Client>
    {
        public IEnumerable<Client> Search(string searchString)
        {
            IEnumerable<Client> clients = Context.Clients.Where(
                client => client.Name.Contains(searchString) ||
                client.IdentityCardNumber.Contains(searchString) ||
                client.RNC.Contains(searchString) ||
                client.Address.Contains(searchString)
            )
            .OrderBy(client => client.Name)
            .ToList();

            return clients;
        }
    }
}
