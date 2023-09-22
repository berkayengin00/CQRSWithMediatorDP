using CQRSDP.Core.Utilities.Result;
using CQRSDP.Data.Queries.Response;
using MediatR;

namespace CQRSDP.Data.Queries.Request
{
    public class GetAllProductQueryRequest : IRequest<DataResult<List<GetAllProductQueryResponse>>>
    {

    }
}
