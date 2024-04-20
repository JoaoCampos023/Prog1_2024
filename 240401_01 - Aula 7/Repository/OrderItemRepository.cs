using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01___Aula_7.Models;
using _240401_01___Aula_7.Data;

namespace _240401_01___Aula_7.Repository
{
    public class OrderItemRepository
    {
        public void Save(OrderItem orderItem)
        {
            DataSet.OrderItems.Add(orderItem);
        }

        public OrderItem Retrieve(int id)
        {
            foreach(var oI in DataSet.OrderItems)
            {
                if(oI.OrderItemId == id)
                return oI;
            }
            return null;
        }
    }
}