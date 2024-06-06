using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trabalho_Final.Models;
using Trabalho_Final.Data;

namespace Trabalho_Final.Repository
{
    public class OrderRepository
    {
        public void Save(Order order)
        {
            DataSet.Orders.Add(order);
        }

        public Order Retrieve(int id)
        {
            foreach(var o in DataSet.Orders)
            {
                if(o.OrderId == id)
                return o;
            }

            return null;
        }
    }
}