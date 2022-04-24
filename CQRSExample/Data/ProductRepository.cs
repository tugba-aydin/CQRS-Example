using CQRSExample.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSExample.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext productContext;
        public ProductRepository(ProductContext _productContext)
        {
            productContext = _productContext;
        }
        public async Task<Product> CreateProduct(Product product)
        {
            productContext.Products.Add(product);
            await productContext.SaveChangesAsync();
            return product;
        }

        public async Task<int> DeleteProduct(int id)
        {
            var product = await productContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            productContext.Products.Remove(product);
            return await productContext.SaveChangesAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await productContext.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Product>> GetProductsList()
        {
            return await productContext.Products.ToListAsync();
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            productContext.Products.Update(product);
            await productContext.SaveChangesAsync();
            return product;
        }
    }
}
