using CQRSDP.Domain.Entity;

namespace CQRSDP.DataAccess.Abstract
{
    public interface IProductWriteDal
    {
        public void Add(Product product);
        public void Delete(Product product);
        public void Update(Product product);
    }
}
