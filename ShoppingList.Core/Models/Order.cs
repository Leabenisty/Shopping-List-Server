using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Core.Models
{
    public class Order
    {
        public int ID{  get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual ICollection<OrderProduct> Products { get; set; }

    }
}
