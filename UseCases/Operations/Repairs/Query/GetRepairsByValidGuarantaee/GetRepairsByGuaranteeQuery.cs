using System.Collections.Generic;
using MediatR;
using UseCases.Models;

namespace UseCases.Operations.Repairs.Query.GetRepairsByValidGuarantaee
{
    public class GetRepairsByGuaranteeQuery :IRequest<List<RepairDto>>
    {
        public bool HaveGuarantee { get; set; }
    }
}
