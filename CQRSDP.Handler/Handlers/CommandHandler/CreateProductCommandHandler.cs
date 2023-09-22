using CQRSDP.Business.Abstract;
using CQRSDP.Core.Utilities.Result;
using CQRSDP.Data.Commands.Request;
using MediatR;

namespace CQRSDP.Handler.Handlers.CommandHandler
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest , Result>
    {
        private readonly IProductService _productService;
        public CreateProductCommandHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<Result> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            return _productService.CreateProduct(request);
        }
               
    }
}
