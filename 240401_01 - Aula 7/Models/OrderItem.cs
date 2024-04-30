using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240401_01___Aula_7.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public Product Product { get; set; }
        public double Quantity { get; set; }
        public double PurchasePrice { get; set; }

    }
}