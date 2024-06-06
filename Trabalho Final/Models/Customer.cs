using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_Final.Models
{
    public class Customer
    {
        private static int _idCounter = 1;
        public Customer()
        {
            CustomerId = _idCounter++;
        }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();

        public string PrintToExportDelimited()
        {
            return $"{CustomerId};{Name};{EmailAddress}";
        }

        public override string ToString()
        {
            return $"Id: {CustomerId}, Nome: {Name}, Email: {EmailAddress}";
        }
    }
}