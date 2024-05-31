using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01___Aula_7.Models;
using _240401_01___Aula_7.Data;

namespace _240401_01___Aula_7.Repository
{
    public class CustumerRepository
    {
        
        public void Save(Custumer custumer)
        {
            custumer.CustumerId = this.GetNextId();
            DataSet.Custumers.Add(custumer);
        }

        public Custumer Retrieve(int id)
        {
            foreach(var c in DataSet.Custumers)
            {
                if(c.CustumerId == id)
                return c;
            }

            return null;
        }

        public void Delete(Custumer custumer)
        {
            DataSet.Custumers.Remove(custumer);
        }

        public List<Custumer> Retrieve()
        {
            return DataSet.Custumers;
        }

        public List<Custumer> RetrieveByName(string name)
        {
            List<Custumer> retorno = new List<Custumer>();
            foreach(var c in DataSet.Custumers)
            {
                if(c.Name.Contains(name))
                {
                    retorno.Add(c);
                }
            }

            return retorno;
        }

        private int GetNextId()
        {
            int n = 0;
            foreach(var c in DataSet.Custumers)
            {
                if(c.CustumerId > n)
                    n = c.CustumerId;
            }

            return ++n;
        }
    }
}