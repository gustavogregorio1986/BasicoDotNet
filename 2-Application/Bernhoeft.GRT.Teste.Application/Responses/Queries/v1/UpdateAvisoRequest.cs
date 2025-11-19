using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Bernhoeft.GRT.Teste.Application.Responses.Queries.v1
{
    public class UpdateAvisoRequest : IRequest<UpdateAvisoResponse>
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool Ativo { get; set; }
    }
}
