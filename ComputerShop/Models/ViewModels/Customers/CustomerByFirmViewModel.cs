using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UseCases.Models;

namespace ComputerShop.Models.ViewModels.Customers
{
    public class CustomerByFirmViewModel
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string BillingCity { get; set; }
        public string BillingCountry { get; set; }
        public string ShipRegion { get; set; }
        public string ShipCountry { get; set; }
        public DateTime DateEntered { get; set; }
        public string FirmName { get; set; }
    }

    public static partial class ViewModelMapperExtensions
    {
        public static CustomerByFirmViewModel AsViewModel(this CustomerByFirmDto dto)
        {
            return new CustomerByFirmViewModel()
            {
                Adress = dto.Adress,
                BillingCity = dto.BillingCity,
                BillingCountry = dto.BillingCountry,
                City = dto.City,
                CustomerId = dto.CustomerId,
                DateEntered = dto.DateEntered,
                Email = dto.Email,
                FirmName = dto.Firm.ToString(),
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                ShipCountry = dto.ShipCountry,
                ShipRegion = dto.ShipRegion,
                Phone = dto.Phone
            };
        }
    }
}
