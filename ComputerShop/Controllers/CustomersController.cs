using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerShop.Models.ViewModels.Customers;
using Entities.Models.Enums;
using MediatR;
using UseCases.Operations.Customers.Query.GetCustomerByFirm;

namespace ComputerShop.Controllers
{
    [ApiController]
    public class CustomersController : Controller
    {
        private readonly ISender _sender;
        public CustomersController(ISender sender)
        {
            _sender = sender;
        }
        [HttpGet("[controller]/[action]/{firm:int}")]
        public async Task <IActionResult> GetCustomersByFirm(Firm firm)
        {
            var customers = await _sender.Send(new GetCustomerByFirmQuery() { Firm = firm });
            return Ok(customers.Select(s=>s.AsViewModel()).ToList());
        }
    }
}
