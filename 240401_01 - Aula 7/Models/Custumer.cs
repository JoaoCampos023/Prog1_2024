using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240401_01___Aula_7.Models
{
    public class Custumer
    {
        public int CustumerId { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }

        public Custumer()
        {
            
        }

        public Custumer(int id)
        {
            CustumerId = id;
        }
        
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Name))
            {
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }
            return isValid;
        }

        public Custumer Retrieve(int custumerId)
        {
            return new Custumer();
        }

        public List<Custumer> Retrieve()
        {
            return new List<Custumer>();
        }

        public void Save(Custumer custumer)
        {

        }
    }
}