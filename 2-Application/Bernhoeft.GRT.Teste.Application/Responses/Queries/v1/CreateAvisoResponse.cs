using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bernhoeft.GRT.ContractWeb.Domain.SqlServer.ContractStore.Entities;

namespace Bernhoeft.GRT.Teste.Application.Responses.Queries.v1
{
    public class CreateAvisoResponse
    {
        public int Id { get; set; }

        public static implicit operator CreateAvisoResponse(AvisoEntity entity) => new()
        {
            Id = entity.Id
        };
    }
}
