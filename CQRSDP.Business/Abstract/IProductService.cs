using CQRSDP.Core.Utilities.Result;
using CQRSDP.Data.Commands.Request;
using CQRSDP.Data.Queries.Response;

namespace CQRSDP.Business.Abstract
{
    public interface IProductService
    {
        Result CreateProduct(CreateProductCommandRequest request);
        Result Delete(DeleteProductCommandRequest request);
        DataResult<List<GetAllProductQueryResponse>> GetAllProduct();
    }
}
