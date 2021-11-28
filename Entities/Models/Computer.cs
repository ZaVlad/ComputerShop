using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Enums;

namespace Entities.Models
{
    public class Computer
    {
        public int ComputerId { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public string Color { get; set; }
        public int Discount { get; set; }
        public string ProcessorName { get; set; }
        public string VideoCardName { get; set; }
        public int GuaranteeId { get; set; }
        public Guarantee Guarantee { get; set; }
        public string Description { get; set; }
        public Firm Firm { get; set; }
        public int ProductCodeId { get; set; }
        public ProductCode ProductCode { get; set; }
        public int GoodsTypeId { get; set; }
        public GoodsType GoodsType { get; set; }
    }
}
