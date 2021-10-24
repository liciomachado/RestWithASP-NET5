using RestCrudApi.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestCrudApi.Model
{
    [Table("endereco")]
    public class Endereco : BaseEntity
    {

        [Column("estado")]
        public string Estado { get; set; }

        [Column("cidade")]
        public string Cidade { get; set; }

        [Column("logradouro")]
        public string Logradouro { get; set; }

        [Column("numero")]
        public long Numero { get; set; }
    }
}