using AutoMapper;
using ShoppingList.Core.Models;
using ShoppingList.Core.Repositories;
using ShoppingList.Core.Services;
using ShoppingList.Models;

namespace ShoppingList.Service.Services
{
    //public class ProductService : IProductService
    //{
    //    private readonly IProductRepository repository;
    //    private readonly IMapper mapper;

    //    public ProductService(IMapper mapper, IProductRepository repository)
    //    {
    //        this.mapper = mapper;
    //        this.repository = repository;
    //    }
    //    public async Task<List<Product>> GetAllProductAsync()
    //    {
    //        var products = await repository.GetAllProductAsync();
    //        //var PhysicalItemsDto = mapper.Map<List<PhysicalItemDto>>(PhysicalItems);
    //        return products;
    //    }
    //    public async Task<Product> GetProductById(int id)
    //    {
    //        return await repository.GetProductById(id);
    //    }
    //    public async Task<Product> AddProductAsync(ProductPostModel productPostModel)
    //    {
    //        if (productPostModel == null)
    //        {
    //            throw new ArgumentNullException(nameof(productPostModel));
    //        }
    //        try
    //        {
    //            var isExist = repository.GetAllProductAsync().Result.FirstOrDefault(p => p.Name.ToLower() == productPostModel.Name.ToLower() && p.CategoryID == productPostModel.CategoryId);
    //            if (isExist != null) { }
    //            var newProduct = mapper.Map<Product>(productPostModel);


    //            //newProduct.CreatedAt = DateTime.Now;
    //            return await repository.AddProductAsync(newProduct);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine($"Error occurred while adding item: {ex.Message}");
    //            throw;
    //        }

    //    }

    //    public async Task DeleteProductAsync(int productId)
    //    {
    //        await repository.DeleteProductAsync(productId);
    //    }


    //}
}
