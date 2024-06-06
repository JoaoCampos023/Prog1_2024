using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trabalho_Final.Models;
using Trabalho_Final.Data;

namespace Trabalho_Final.Repository
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