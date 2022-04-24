using CQRSExample.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSExample.Data
{
    public class ProductContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ProductContext(DbContextOptions<ProductContext> options):base(options)
        {

        }
    }
}
