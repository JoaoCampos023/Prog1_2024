using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240401_01___Aula_7.Models
{
    public class Consumer
    {
        public int ConsumerId { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string SearchConsumers { get; set; }
        public List<Address> Addresses { get; set; }

        public Consumer()
        {

        }

        public Consumer(int id)
        {
            ConsumerId = id;
        }

        public bool Validate()
        {
            var isValid = true;
            if(string.IsNullOrWhiteSpace(Name))
            {
                isValid = false;
            }
            if(string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }
            return isValid;
        }

        public Consumer Retrieve(int consumerId)
        {
            return new Consumer();
        }

        public List<Consumer> Retrieve()
        {
            return new List<Consumer>();
        }

        public void Save(Consumer consumer)
        {

        }
    }
}