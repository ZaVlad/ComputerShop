using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Entities.Models.Enums;

namespace UseCases.Models
{
   public class RepairByGuaranteeDto
    {
        public int RepairId { get; set; }
        public int GoodsTypeId { get; set; }
        public int ProductCodeId { get; set; }
        public decimal Price { get; set; }
        public bool HaveGuarantee { get; set; }
        public Guid Code { get; set; }
        public RepairStage RepairStage { get; set; }
    }
}
