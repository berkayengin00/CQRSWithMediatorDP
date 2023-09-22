using CQRSDP.Business.Abstract;
using CQRSDP.Core.Utilities.Result;
using CQRSDP.Data.Queries.Request;
using CQRSDP.Data.Queries.Response;
using MediatR;

namespace CQRSDP.Handler.Handlers.QueryHandler
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest , DataResult<List<GetAllProductQueryResponse>>>
    {
        private readonly IProductService _productService;
        public GetAllProductQueryHandler(IProductService productService)
        {
            _productService = productService;
        }
        
        public async Task<DataResult<List<GetAllProductQueryResponse>>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            return _productService.GetAllProduct();
        }
    }
}
