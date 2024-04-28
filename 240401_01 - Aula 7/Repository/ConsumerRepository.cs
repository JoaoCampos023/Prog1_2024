using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01___Aula_7.Models;
using _240401_01___Aula_7.Data;

namespace _240401_01___Aula_7.Repository
{
    public class ConsumerRepository
    {
        private List<Consumer> consumers;

        public ConsumerRepository()
        {
            consumers = new List<Consumer>
            {
                new Consumer { ConsumerId = 1, Name = "Matheus"},
                new Consumer { ConsumerId = 2, Name = "Pedro"},
                new Consumer { ConsumerId = 3, Name = "Paulo"},
                new Consumer { ConsumerId = 4, Name = "Julia"},
                new Consumer { ConsumerId = 5, Name = "Alice"},
            };
        }

        public List<Consumer> SearchConsumers(string query)
        {
            if (string.IsNullOrWhiteSpace(query) || query.Length < 4)
            {   
                throw new ArgumentException("A consulta deve conter pelo menos 5 caracteres.", nameof(query));
            }
            return consumers.Where(c => c.Name.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        public void Save(Consumer consumer)
        {
            DataSet.Consumers.Add(consumer);
        }

        public Consumer Retrieve(int id)
        {
            foreach(var c in DataSet.Consumers)
            {
                if(c.ConsumerId == id)
                return c;
            }
            return null;
        }

        public List<Consumer> Retrieve()
        {
            return DataSet.Consumers;
        }
    }
}