using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StellarCoffeeData.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdentityCardNumber { get; set; }
        public string RNC { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; } = true;
    }
}
