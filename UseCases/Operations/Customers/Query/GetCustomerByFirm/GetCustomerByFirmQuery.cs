using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Enums;
using MediatR;
using UseCases.Models;

namespace UseCases.Operations.Customers.Query.GetCustomerByFirm
{
    public class GetCustomerByFirmQuery : IRequest<List<CustomerByFirmDto>>
    {
        public Firm Firm { get; set; }

    }
}
