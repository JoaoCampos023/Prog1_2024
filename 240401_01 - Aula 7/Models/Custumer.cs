using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240401_01___Aula_7.Models
{
    public class Custumer
    {
        private static int _idCounter = 1;
        public Custumer()
        {
            CustumerId = _idCounter++;
        }
        public int CustumerId { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();

        public string PrintToExportDelimited()
        {
            return $"{CustumerId};{Name};{EmailAddress}";
        }

        public override string ToString()
        {
            return $"Id: {CustumerId}, Nome: {Name}, Email: {EmailAddress}";
        }

    }
}