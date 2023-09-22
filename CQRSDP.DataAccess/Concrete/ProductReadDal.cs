using CQRSDP.Data.Queries.Response;
using CQRSDP.DataAccess.Abstract;
using CQRSDP.DataAccess.Context;

namespace CQRSDP.DataAccess.Concrete
{
    public class ProductReadDal : IProductReadDal
    {

        public List<GetAllProductQueryResponse> GetAll()
        {
            return ApplicationDbContext.ProductList.Select(x => new GetAllProductQueryResponse()
            {
                Id = x.Id,
                CreateTime = x.CreateTime,
                Name = x.Name,
                Price = x.Price,
                Quantity = x.Quantity,
            }).ToList();
        }
    }
}
