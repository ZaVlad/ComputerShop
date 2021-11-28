using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ProductCode
    {
        public int ProductCodeId { get; set; }
        public Guid Code { get; set; }
        public int GoodsTypeId { get; set; }
        public GoodsType GoodsType { get; set; }

    }
}
