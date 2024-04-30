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
            address.AddressId = this.GetNextId();
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

        public List<Address> Retrieve()
        {
            return DataSet.Addresses;
        }
        
        private int GetNextId()
        {
            int n = 0;
            foreach(var a in DataSet.Addresses)
            {
                if(a.AddressId > n)
                    n = a.AddressId;
            }

            return n++;
        }
    }
}