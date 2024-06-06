using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trabalho_Final.Models;

namespace Trabalho_Final.Data
{
    public class DataSet
    {
        public static List<Address> Addresses { get; set; } = new List<Address>();
        public static List<Customer> Customers { get; set; } = new List<Customer>();
        public static List<Product> Products { get; set; }
        public static List<Order> Orders { get; set; }
        public static List<OrderItem> OrderItems { get; set; }
        
    }
}