using AutoMapper;
using CQRSDP.Data.Commands.Request;
using CQRSDP.Domain.Entity;

namespace CQRSDP.Business.Mapping
{
    public class ProductMapping:Profile
    {
        public ProductMapping()
        {
            CreateMap<CreateProductCommandRequest, Product>();
            CreateMap<Product, CreateProductCommandRequest>();
            CreateMap<Product, DeleteProductCommandRequest>();
            CreateMap<DeleteProductCommandRequest, Product>();
        }
    }
}
