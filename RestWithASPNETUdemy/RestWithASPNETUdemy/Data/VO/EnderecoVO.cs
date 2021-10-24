using RestCrudApi.HypermediaFilterOptions;
using RestCrudApi.HypermediaFilterOptions.Abstract;
using System;
using System.Collections.Generic;

namespace RestCrudApi.Model
{
    public class EnderecoVO : ISupportsHyperMedia
    {
        public long Id { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public long Numero { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

    }
}
