using RestCrudApi.Data.Converter.Implementation;
using RestCrudApi.Model;
using RestCrudApi.Repository;
using System.Collections.Generic;

namespace RestCrudApi.Business.Implementations
{
    public class EnderecoBusinessImplementation : IEnderecoBusiness
    {
        private readonly IRepository<Endereco> _repository;
        private readonly EnderecoConverter _converter;


        public EnderecoBusinessImplementation(IRepository<Endereco> repository)
        {
            _repository = repository;
            _converter = new EnderecoConverter();
        }
        public EnderecoVO Create(EnderecoVO endereco)
        {

            var personEntity = _converter.Parse(endereco);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<EnderecoVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public EnderecoVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public EnderecoVO Update(EnderecoVO Product)
        {
            var personEntity = _converter.Parse(Product);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }
    }
}
