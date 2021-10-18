using RestCrudApi.Data.Converter.Implementation;
using RestCrudApi.Model;
using RestCrudApi.Repository;
using System.Collections.Generic;

namespace RestCrudApi.Business.Implementations
{
    public class ProductBusinessImplementation : IProductBusiness
    {
        private readonly IRepository<Product> _repository;
        private readonly ProductConverter _converter;


        public ProductBusinessImplementation(IRepository<Product> repository)
        {
            _repository = repository;
            _converter = new ProductConverter();
        }
        public ProductVO Create(ProductVO Product)
        {

            var personEntity = _converter.Parse(Product);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<ProductVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public ProductVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public ProductVO Update(ProductVO Product)
        {
            var personEntity = _converter.Parse(Product);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }
    }
}
