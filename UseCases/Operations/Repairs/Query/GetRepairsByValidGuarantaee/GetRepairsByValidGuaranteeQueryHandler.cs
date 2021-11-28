using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using DataAccess.MsSql;
using MediatR;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using UseCases.Models;

namespace UseCases.Operations.Repairs.Query.GetRepairsByValidGuarantaee
{
    public class GetRepairsByValidGuaranteeQueryHandler:IRequestHandler<GetRepairsByGuaranteeQuery,List<RepairByGuaranteeDto>>
    {
        
        private readonly IDbConnection _dbConnection;
        public GetRepairsByValidGuaranteeQueryHandler(IOptions<MyOptions> options)
        {
            _dbConnection =options.Value is null ? throw new ArgumentNullException(nameof(options)): new SqlConnection(options.Value.DefaultConnection);
        }
        public async Task<List<RepairByGuaranteeDto>> Handle(GetRepairsByGuaranteeQuery request, CancellationToken cancellationToken)
        {
            var repairs = await _dbConnection.QueryAsync<RepairByGuaranteeDto>("spSupplier_GetByGuarantee", request, commandType:CommandType.StoredProcedure);
            return repairs.ToList();
        }
    }
}
