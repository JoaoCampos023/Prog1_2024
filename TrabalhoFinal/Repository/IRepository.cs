using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoFinal.Repository
{
    public interface IRepositorio<T>
    {
        void Adicionar(T item);
        void Remover(string nome);
        T Buscar(string termo);
        List<T> Listar();
    }
}