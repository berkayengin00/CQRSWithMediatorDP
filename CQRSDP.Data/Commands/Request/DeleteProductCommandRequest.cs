using CQRSDP.Core.Utilities.Result;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSDP.Data.Commands.Request
{
    public class DeleteProductCommandRequest : IRequest<Result>
    {
        public int Id { get; set; }
    }
}
