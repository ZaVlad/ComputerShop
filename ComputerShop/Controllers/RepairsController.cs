using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerShop.Models.ViewModels.Repairs;
using MediatR;
using UseCases.Operations.Repairs.Query.GetRepairsByValidGuarantaee;

namespace ComputerShop.Controllers
{
    [ApiController]
    public class RepairsController : Controller
    {
        private readonly ISender _sender;

        public RepairsController(ISender sender)
        {
            _sender = sender?? throw new ArgumentNullException(nameof(sender));
        }
        [HttpGet("[controller]/[action]/{validGuarantee:bool}")]
        public async Task<IActionResult> GetByGuarantee(bool validGuarantee)
        {
            var repairs = await _sender.Send(new GetRepairsByGuaranteeQuery(){HaveGuarantee = validGuarantee});
            return Ok(repairs.Select(s=>s.AsViewModel()).ToList());
        }
    }
}
