using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoFinal.Models;

namespace TrabalhoFinal.Repository
{
    public class PratoRepository : IRepositorio<Prato>
    {
        private List<Prato> cardapio;

        public PratoRepository()
        {
            cardapio = new List<Prato>();
        }

        public void Adicionar(Prato prato)
        {
            cardapio.Add(prato);
        }

        public void Remover(string nome)
        {
            Prato pratoARemover = cardapio.FirstOrDefault(p => p.Nome == nome);
            if(pratoARemover != null)
            {
                cardapio.Remove(pratoARemover);
                Console.WriteLine($"Prato {nome} removido com sucesso.");
            }
            else
            {
                Console.WriteLine($"Prato {nome} não encontrado.");
            }
        }

        public Prato Buscar(string termo)
        {
            return cardapio.FirstOrDefault(p => p.Nome.Contains(termo) || p.Descricao.Contains(termo));
        }

        public List<Prato> Listar()
        {
            return new List<Prato>(cardapio);
        }
    }
}