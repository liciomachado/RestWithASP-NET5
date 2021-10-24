using RestCrudApi.Model;
using System.Collections.Generic;

namespace RestCrudApi.Business
{
    public interface IEnderecoBusiness
    {
        EnderecoVO Create(EnderecoVO Product);
        EnderecoVO FindById(long id);
        List<EnderecoVO> FindAll();
        EnderecoVO Update(EnderecoVO Product);
        void Delete(long id);
    }
}
