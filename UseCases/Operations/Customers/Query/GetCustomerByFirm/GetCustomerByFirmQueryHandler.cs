using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using DataAccess.MsSql;
using Entities.Models.Enums;
using MediatR;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using UseCases.Models;

namespace UseCases.Operations.Customers.Query.GetCustomerByFirm
{
    public class GetCustomerByFirmQueryHandler:IRequestHandler<GetCustomerByFirmQuery,List<CustomerByFirmDto>>
    {
        private readonly IDbConnection _dbConnection;

        public GetCustomerByFirmQueryHandler(IOptions<MyOptions> options)
        {
            _dbConnection = options.Value is null ? throw new ArgumentNullException(nameof(options)) : new SqlConnection(options.Value.DefaultConnection);
        }
        public async Task<List<CustomerByFirmDto>> Handle(GetCustomerByFirmQuery request, CancellationToken cancellationToken)
        {
            var customersDto =await 
                _dbConnection.QueryAsync<CustomerByFirmDto>("spCustomer_GetByFirmGoods", request,
                    commandType: CommandType.StoredProcedure);
            return customersDto.ToList();
        }
    }
}
