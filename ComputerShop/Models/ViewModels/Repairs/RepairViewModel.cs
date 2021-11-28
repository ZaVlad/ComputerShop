using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models.Enums;
using UseCases.Models;

namespace ComputerShop.Models.ViewModels.Repairs
{
    public class RepairViewModel
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
        public static RepairViewModel AsViewModel(this RepairDto dto)
        {
            return new RepairViewModel()
            {
                Code = dto.Code,
                GoodsTypeId = dto.GoodsTypeId,
                HaveGuarantee = dto.HaveGuarantee,
                Price = dto.Price,
                ProductCodeId = dto.ProductCodeId,
                RepairId = dto.RepairId,
                RepairStage = dto.RepairStage
            };
        }
    }
}
