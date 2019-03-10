using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StellarCoffeeData.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public int ReceiptTypeId { get; set; }
        public string Name { get; set; }
        public string IdentityCardNumber { get; set; }
        public string RNC { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; } = true;

        [ForeignKey("ReceiptTypeId")]
        public virtual ReceiptType ReceiptType { get; set; }
    }
}
