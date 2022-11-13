using Microsoft.EntityFrameworkCore;

namespace ProductCrudAPI.Models
{
    public class ProdutoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=Cursomvc;Integrated Security=True");
        }

        public DbSet<Produto> Produtos { get; set; } = null!;
    }
}
