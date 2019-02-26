using StellarCoffeeData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StellarCoffeeData.Repositories.Entities
{
    public class UserRepository : BaseRepository<User>
    {
        public User Login(string username, string password)
        {
            return Context.Users.FirstOrDefault(user => user.UserName == username && user.Password == password);
        }
    }
}
