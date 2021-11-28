using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models.Enums;
using UseCases.Models;

namespace ComputerShop.Models.ViewModels.Repairs
{
    public class RepairByGuaranteeViewModel
    {
        public int RepairId { get; set; }
        public int GoodsTypeId { get; set; }
        public int ProductCodeId { get; set; }
        public decimal Price { get; set; }
        public bool HaveGuarantee { get; set; }
        public Guid Code { get; set; }
        public RepairStage RepairStage { get; set; }
    }

    public static partial class ViewModelMapperExtensions
    {
        public static RepairByGuaranteeViewModel AsViewModel(this RepairByGuaranteeDto byGuaranteeDto)
        {
            return new RepairByGuaranteeViewModel()
            {
                Code = byGuaranteeDto.Code,
                GoodsTypeId = byGuaranteeDto.GoodsTypeId,
                HaveGuarantee = byGuaranteeDto.HaveGuarantee,
                Price = byGuaranteeDto.Price,
                ProductCodeId = byGuaranteeDto.ProductCodeId,
                RepairId = byGuaranteeDto.RepairId,
                RepairStage = byGuaranteeDto.RepairStage
            };
        }
    }
}
