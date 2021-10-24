using RestCrudApi.Data.Converter.Contract;
using RestCrudApi.Data.VO;
using RestCrudApi.Model;
using System.Collections.Generic;
using System.Linq;

namespace RestCrudApi.Data.Converter.Implementation
{
    public class EnderecoConverter : IParser<EnderecoVO, Endereco>, IParser<Endereco, EnderecoVO>
    {
        public Endereco Parse(EnderecoVO origin)
        {
            if (origin == null) return null;
            return new Endereco
            {
                Id = origin.Id,
                Estado = origin.Estado,
                Cidade = origin.Cidade,
                Logradouro = origin.Logradouro,
                Numero = origin.Numero
            };
        }

        public EnderecoVO Parse(Endereco origin)
        {
            if (origin == null) return null;
            return new EnderecoVO
            {
                Id = origin.Id,
                Estado = origin.Estado,
                Cidade = origin.Cidade,
                Logradouro = origin.Logradouro,
                Numero = origin.Numero
            };
        }

        public List<Endereco> Parse(List<EnderecoVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
                  
        }

        public List<EnderecoVO> Parse(List<Endereco> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
