using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Enums;

namespace Entities.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public int PaymentId { get; set; }
        public Payment Payment { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
        public Shipper Shipper { get; set; }
        public int ShipperId { get; set; }
        public bool Paid { get; set; }
        public DateTime PaymentDate { get; set; }
        public DeliveryStatus DeliveryStatus { get; set; }
    }
}
