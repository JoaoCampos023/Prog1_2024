using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trabalho_Final.Models;
using Trabalho_Final.Data;

namespace Trabalho_Final.Repository
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