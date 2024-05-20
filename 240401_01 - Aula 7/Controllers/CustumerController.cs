using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using _240401_01___Aula_7.Models;
using _240401_01___Aula_7.Repository;

namespace _240401_01___Aula_7.Controllers
{
    public class CustumerController
    {
        private CustumerRepository custumerRepository;
        public CustumerController()
        {
            custumerRepository = new CustumerRepository();
        }
        public void Insert(Custumer custumer)
        {
            custumerRepository.Save(custumer);
        }

        public Custumer Get(int id)
        {
            return custumerRepository.Retrieve(id);
        }

        public List<Custumer> Get()
        {
            return custumerRepository.Retrieve();
        }

        public List<Custumer> GetByName(string name)
        {
            return custumerRepository.RetrieveByName(name);
        }

        public bool Delete(int id)
        {
            var custumer = Get(id);
            if(custumer != null)
            {
                custumers.Remove(custumer);
                return true;
            }
            return false;
        }
    }
}