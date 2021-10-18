using RestCrudApi.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestCrudApi.Model
{
    [Table("products")]
    public class Product : BaseEntity
    {

        [Column("item")]
        public string Item { get; set; }

        [Column("description")]
        public string Descricao { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }
    }
}
