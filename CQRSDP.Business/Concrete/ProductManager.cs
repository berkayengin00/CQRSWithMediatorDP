using AutoMapper;
using CQRSDP.Business.Abstract;
using CQRSDP.Core.Utilities.Result;
using CQRSDP.Data.Commands.Request;
using CQRSDP.Data.Queries.Response;
using CQRSDP.DataAccess.Abstract;
using CQRSDP.Domain.Entity;

namespace CQRSDP.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductReadDal _productReadDal;
        private readonly IProductWriteDal _productWriteDal;
        private readonly IMapper _mapper;

        public ProductManager(IProductReadDal productReadDal , IProductWriteDal productWriteDal,IMapper mapper)
        {
            _productReadDal = productReadDal;
            _productWriteDal = productWriteDal;
            _mapper = mapper;
        }

        public Result CreateProduct(CreateProductCommandRequest createProductCommandRequest)
        {
            var product = _mapper.Map<Product>(createProductCommandRequest);
            _productWriteDal.Add(product);
           
            return new Result(true,"Başarılı");
        }

        public Result Delete(DeleteProductCommandRequest request)
        {
            var product = _mapper.Map<Product>(request);
            _productWriteDal.Delete(product);

            return new Result(true, "Başarılı");
        }

        public DataResult<List<GetAllProductQueryResponse>> GetAllProduct()
        {
            var result = _productReadDal.GetAll();

            return new DataResult<List<GetAllProductQueryResponse>>(true,"Datalar Geldi",result);
        }
    }
}
