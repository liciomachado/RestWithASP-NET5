using Microsoft.EntityFrameworkCore;

namespace RestCrudApi.Model.Context
{
    public class MySqlContext :DbContext
    {
        public MySqlContext()
        {

        }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        { 

        }
        public DbSet<Product> Product { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

    }
}
