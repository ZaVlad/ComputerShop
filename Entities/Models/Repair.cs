using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Enums;

namespace Entities.Models
{
    public class Repair
    {
        public int RepairId { get; set; }
        public decimal Price { get; set; }
        public bool HaveGuarantee { get; set; }
        public int ProductCodeId{ get; set; }
        public ProductCode ProductCode { get; set; }
        public RepairStage RepairStage { get; set; }
    }
}
