using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trabalho_Final.Models;
using Trabalho_Final.Data;

namespace Trabalho_Final.Repository
{
    public class ProductRepository
    {
        public void Save(Product product)
        {
            DataSet.Products.Add(product);
        }

        public Product Retrieve(int id)
        {
            foreach(var p in DataSet.Products)
            {
                if(p.ProductId == id)
                return p;
            }

            return null;
        }
    }
}