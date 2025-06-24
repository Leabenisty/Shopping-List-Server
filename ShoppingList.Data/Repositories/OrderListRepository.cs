using Microsoft.EntityFrameworkCore;
using ShoppingList.Core.Models;
using ShoppingList.Core.Repositories;
using System.Data.SqlClient;

namespace ShoppingList.Data.Repositories
{
    public class OrderListRepository : IOrderListRepository
    {
        private readonly DataContext? _context;

        public OrderListRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<OrderList>> GetAllOrderListAsync()
        {
            try
            {
                List<OrderList> orderList = await _context.DataOrderList.ToListAsync();
                return orderList;

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

