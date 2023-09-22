using CQRSDP.Domain.Entity;

namespace CQRSDP.DataAccess.Context
{
    public class ApplicationDbContext
    {
        public static List<Product> ProductList = new()
        {
            new (){Id=1,Name="PC",Price=10000,CreateTime=DateTime.Now,Quantity=5},
            new (){Id=2,Name="Phone",Price=5000,CreateTime=DateTime.Now,Quantity=3},
            new (){Id=3,Name="Mouse",Price=200,CreateTime=DateTime.Now,Quantity=10},
        };
    }
}
