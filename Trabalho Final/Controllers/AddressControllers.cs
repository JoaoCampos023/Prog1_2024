using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trabalho_Final.Models;
using Trabalho_Final.Repository;
using Trabalho_Final.Data;

namespace Trabalho_Final.Controllers
{
    public class AddressController
    {
        private AddressRepository addressRepository;

        public AddressController()
        {
            this.addressRepository = new AddressRepository();
        }

        public Address Insert(Address address)
        {
            this.addressRepository.Save(address);
            return address;
        }

        public Address Get(int id)
        {
            return addressRepository.Retrieve(id);
        }

        public List<Address> Get()
        {
            return addressRepository.Retrieve();
        }

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