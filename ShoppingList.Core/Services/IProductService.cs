using ShoppingList.Core.Models;
using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Core.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductAsync();
        Task <Product> GetProductById(int id);
        Task<Product> AddProductAsync(ProductPostModel productPostModel);
        Task DeleteProductAsync(int productId);
    }
}
