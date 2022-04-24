using CQRSExample.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSExample.Data
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsList();
        Task<Product> GetProductById(int id);
        Task<Product> CreateProduct(Product product);
        Task<Product> UpdateProduct(Product product);
        Task<int> DeleteProduct(int id);
    }
}
