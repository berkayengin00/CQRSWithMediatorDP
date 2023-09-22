using CQRSDP.Data.Queries.Response;

namespace CQRSDP.DataAccess.Abstract
{
    public interface IProductReadDal
    {
        public List<GetAllProductQueryResponse> GetAll();
    }
}
