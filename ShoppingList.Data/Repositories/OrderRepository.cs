using Microsoft.EntityFrameworkCore;
using ShoppingList.Core.Models;
using ShoppingList.Core.Repositories;
using System.Data.SqlClient;

namespace ShoppingList.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext? _context;

        public OrderRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Order> AddOrder(Order order)
        {
            await _context.Order.AddAsync(order);
            await _context.SaveChangesAsync();
            return order;
        }

        public async Task<List<Order>> GetAllOrderAsync()
        {
            try
            {
                List<Order> orderList = await _context.Order
              .Include(o => o.Products) // טוען גם את המוצרים של כל הזמנה
              .ToListAsync();
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

