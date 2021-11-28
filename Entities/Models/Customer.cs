using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string BillingCity { get; set; }
        public string BillingCountry{ get; set; }
        public string ShipRegion { get; set; }
        public string ShipCountry { get; set; }
        public DateTime DateEntered { get; set; }

    }
}
