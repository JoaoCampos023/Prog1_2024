using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using _240401_01___Aula_7.Date;
using _240401_01___Aula_7.Models;

namespace _240401_01___Aula_7.Repository
{
    public class ProductRepository
    {
        public void Save(Product product)
        {
            DateSet.Products.Add(product);
        }

        public Product Retrieve(int id)
        {
            foreach(var p in DateSet.Products)
            {
                if(p.ProductId == id)
                return p;
            }

            return null;
        }
    }
}