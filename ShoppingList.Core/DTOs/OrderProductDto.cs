﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Core.DTOs
{
    public class OrderProductDto
    {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public int Quantity { get; set; }
     
    }
}
