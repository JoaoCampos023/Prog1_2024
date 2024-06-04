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
        /*
        public void Save(Custumer custumer)
        {
            custumer.CustumerId = this.GetNextId();
            DataSet.Custumers.Add(custumer);
        }*/

        public void Save(Custumer custumer, bool autoGenerateId = true)
        {
            if(autoGenerateId)
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

        public bool ImportFromTxt(string line, string delimiter)
        {
            if(string.IsNullOrWhiteSpace(line))
                return false;

            string[] data = line.Split(delimiter);
            
            if(data.Count() < 1)
                return false;

            Custumer c = new Custumer{
                CustumerId = Convert.ToInt32((data[0] == null ? 0 : data[0])),
                Name = (data[1] == null ? string.Empty : data[1]),
                EmailAddress = (data[2] == null ? string.Empty : data[2])
            };

            // Entre chaves = é um hack para encurtação de codigo em C#.

            Save(c, false);
            return true;
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