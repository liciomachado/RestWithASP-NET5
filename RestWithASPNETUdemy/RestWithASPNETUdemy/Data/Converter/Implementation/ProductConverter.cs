using RestCrudApi.Data.Converter.Contract;
using RestCrudApi.Data.VO;
using RestCrudApi.Model;
using System.Collections.Generic;
using System.Linq;

namespace RestCrudApi.Data.Converter.Implementation
{
    public class ProductConverter : IParser<ProductVO, Product>, IParser<Product, ProductVO>
    {
        public Product Parse(ProductVO origin)
        {
            if (origin == null) return null;
            return new Product
            {
                Id = origin.Id,
                Descricao = origin.Description,
                LaunchDate = origin.LaunchDate,
                Price = origin.Price,
                Item = origin.Item
            };
        }

        public ProductVO Parse(Product origin)
        {
            if (origin == null) return null;
            return new ProductVO
            {
                Id = origin.Id,
                Description = origin.Descricao,
                LaunchDate = origin.LaunchDate,
                Price = origin.Price,
                Item = origin.Item
            };
        }

        public List<Product> Parse(List<ProductVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
                  
        }

        public List<ProductVO> Parse(List<Product> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
