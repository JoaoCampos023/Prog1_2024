using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_Final.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShippingAddress { get; set; }
        public List<OrderItem> OrderItems { get; set; }

    }
}