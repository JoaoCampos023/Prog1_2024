using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using _240401_01___Aula_7.Models;
using _240401_01___Aula_7.Date;

namespace _240401_01___Aula_7.Repositor
{
    public class CustumerRepository
    {
        public void Save(Custumer custumer)
        {
            DateSet.Custumers.Add(custumer);

        }

        public Custumer Retrieve(int id)
        {
            foreach(var c in DateSet.Custumers)
            {
                if(c.CustumerId == id)
                return c;
            }

            return null;
        }
    }
}