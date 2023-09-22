using CQRSDP.DataAccess.Abstract;
using CQRSDP.DataAccess.Context;
using CQRSDP.Domain.Entity;

namespace CQRSDP.DataAccess.Concrete
{
    public class ProductWriteDal : IProductWriteDal
    {
        public void Add(Product product)
        {
            ApplicationDbContext.ProductList.Add(product);
        }

        public void Delete(Product product)
        {
            var result = ApplicationDbContext.ProductList.FirstOrDefault(x=>x.Id==product.Id);
            var index = ApplicationDbContext.ProductList.IndexOf(result);
            ApplicationDbContext.ProductList.RemoveAt(index);
        }

        public void Update(Product product)
        {
            var index = ApplicationDbContext.ProductList.IndexOf(product);
            product.Id = ApplicationDbContext.ProductList[index].Id;
            ApplicationDbContext.ProductList[index] = product;
        }
    }
}
