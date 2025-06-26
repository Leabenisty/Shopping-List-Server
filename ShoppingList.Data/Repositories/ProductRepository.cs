using Microsoft.EntityFrameworkCore;
using ShoppingList.Core.Models;
using ShoppingList.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Data.Repositories
{
    //public class ProductRepository: IProductRepository
    //{
    //    private readonly DataContext? _context;

    //    public ProductRepository(DataContext context)
    //    {
    //        _context = context;
    //    }

    //    public async Task<List<Product>> GetAllProductAsync()
    //    {
    //        try
    //        {
    //            List<Product> productsList = await _context.DataProduct.ToListAsync();
    //            return productsList;
    //        }
    //        catch (SqlException sqlEx)
    //        {

    //            Console.WriteLine($"SQL connection Error: {sqlEx.Message}");
    //            throw new DatabaseException("SQL connection error occurred.😥", sqlEx);
    //        }
    //        catch (DbUpdateException dbEx)
    //        {

    //            Console.WriteLine($"Database Qery Error: {dbEx.Message}");
    //            throw new DatabaseException("Database query error occurred.😓", dbEx);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine($"An error occurred: {ex.Message}");
    //            throw new DatabaseException("An unexpected error occurred.😕", ex);
    //        }
    //    }
    //    public async Task<Product> GetProductById(int id)
    //    {
    //        try
    //        {          
    //            return await _context.DataProduct.FirstAsync(e => e.ID == id);
    //        }
    //        catch (SqlException sqlEx)
    //        {

    //            Console.WriteLine($"SQL connection Error: {sqlEx.Message}");
    //            throw new DatabaseException("SQL connection error occurred.😥", sqlEx);
    //        }
    //        catch (DbUpdateException dbEx)
    //        {

    //            Console.WriteLine($"Database Qery Error: {dbEx.Message}");
    //            throw new DatabaseException("Database query error occurred.😓", dbEx);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine($"An error occurred: {ex.Message}");
    //            throw new DatabaseException("An unexpected error occurred.😕", ex);
    //        }
    //    }
    //    public async Task<Product> AddProductAsync(Product product)
    //    {

    //        try
    //        {
    //            await _context.DataProduct.AddAsync(product);
    //            await _context.SaveChangesAsync();
    //            return product;
    //        }
    //        catch (SqlException sqlEx)
    //        {

    //            Console.WriteLine($"SQL connection Error: {sqlEx.Message}");
    //            throw new DatabaseException("SQL connection error occurred.😥", sqlEx);
    //        }
    //        catch (DbUpdateException dbEx)
    //        {

    //            Console.WriteLine($"Database Qery Error: {dbEx.Message}");
    //            throw new DatabaseException("Database query error occurred.😓", dbEx);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine($"An error occurred: {ex.Message}");
    //            throw new DatabaseException("An unexpected error occurred.😕", ex);
    //        }
    //    }

    //    public async Task DeleteProductAsync(int productId)
    //    {
    //        var product = _context.DataProduct.Find(productId);
    //        if (product != null)
    //            _context.DataProduct.Remove(product);
    //        await _context.SaveChangesAsync();
    //    }

       
    //}
}
