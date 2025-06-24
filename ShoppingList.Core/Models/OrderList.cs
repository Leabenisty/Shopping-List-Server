using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Core.Models
{
    public class OrderList
    {
        public int Id {  get; set; }
        public string CustomerName  { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
