using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01___Aula_7.Models;
using _240401_01___Aula_7.Data;

namespace _240401_01___Aula_7.Repository
{
    public class AddressRepository
    {
        public void Save(Address address)
        {
            
            DataSet.Addresses.Add(address);
        }

        public Address Retrieve(int id)
        {
            foreach(var a in DataSet.Addresses)
            {
                if(a.AddressId == id)
                return a;
            }

            return null;
        }
        
    }
}