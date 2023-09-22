using CQRSDP.Core.Utilities.Result;
using MediatR;

namespace CQRSDP.Data.Commands.Request
{
    public class CreateProductCommandRequest : IRequest<Result>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;
    }
}
