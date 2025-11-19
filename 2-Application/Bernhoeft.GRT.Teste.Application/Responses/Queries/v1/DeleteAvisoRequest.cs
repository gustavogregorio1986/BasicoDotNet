using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Bernhoeft.GRT.Teste.Application.Responses.Queries.v1
{
    public class DeleteAvisoRequest : IRequest
    {
        public int Id { get; set; }
    }
}
