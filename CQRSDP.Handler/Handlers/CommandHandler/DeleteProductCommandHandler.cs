using CQRSDP.Business.Abstract;
using CQRSDP.Core.Utilities.Result;
using CQRSDP.Data.Commands.Request;
using MediatR;

namespace CQRSDP.Handler.Handlers.CommandHandler
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, Result>
    {
        private readonly IProductService _productService;
        public DeleteProductCommandHandler(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<Result> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            return _productService.Delete(request);
        }
    }
}
