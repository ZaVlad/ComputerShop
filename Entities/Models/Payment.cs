using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Enums;

namespace Entities.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public PaymentType PaymentType { get; set; }
        public bool Allowed { get; set; }
    }
}
