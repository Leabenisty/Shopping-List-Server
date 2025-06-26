using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Data
{
    public class DatabaseException: Exception
    {
        public DatabaseException(string message) : base(message)
        {
            Debug.WriteLine($"DatabaseException: {message}");
        }
        public DatabaseException(string message, Exception innerException) : base(message, innerException)
        {
            Debug.WriteLine($"DatabaseException: {message}. Inner exception: {innerException.Message}");

        }

    }
}
