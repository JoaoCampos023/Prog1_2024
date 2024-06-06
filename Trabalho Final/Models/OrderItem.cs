using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_Final.Models
{    
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public Product Product { get; set; }
        public double Quantity { get; set; }
        public double PurchasePrice { get; set; }

    }
}