using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01___Aula_7.Date;
using _240401_01___Aula_7.Models;

namespace _240401_01___Aula_7.Repository
{
    public class OrderRepository
    {
        public void Save(Order order)
        {
            DateSet.Orders.Add(order);
        }

        public Order Retrieve(int id)
        {
            foreach(var o in DateSet.Orders)
            {
                if(o.OrderId == id)
                return o;
            }

            return null;
        }
    }
}