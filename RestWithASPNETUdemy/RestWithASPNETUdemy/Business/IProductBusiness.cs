using RestCrudApi.Model;
using System.Collections.Generic;

namespace RestCrudApi.Business
{
    public interface IProductBusiness
    {
        ProductVO Create(ProductVO Product);
        ProductVO FindById(long id);
        List<ProductVO> FindAll();
        ProductVO Update(ProductVO Product);
        void Delete(long id);
    }
}
