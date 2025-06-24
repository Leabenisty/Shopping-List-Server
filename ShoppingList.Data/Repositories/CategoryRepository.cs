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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext? _context;
     
        public CategoryRepository(DataContext context) 
        { 
            _context = context;
        }

        public async Task<List<Category>> GetAllCategoryAsync()
        {
            try
            {
                List<Category> addNewRequests = await _context.DataCategory.ToListAsync();
                return addNewRequests;

            }
            catch (SqlException sqlEx)
            {

                Console.WriteLine($"SQL connection Error: {sqlEx.Message}");
                throw new DatabaseException("SQL connection error occurred.😥", sqlEx);
            }
            catch (DbUpdateException dbEx)
            {

                Console.WriteLine($"Database Qery Error: {dbEx.Message}");
                throw new DatabaseException("Database query error occurred.😓", dbEx);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw new DatabaseException("An unexpected error occurred.😕", ex);
            }
        }
    }
}
