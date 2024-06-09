using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoFinal.Models
{
    public class Prato
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public Prato(string nome, string descricao, decimal preco)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;   
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Descrição: {Descricao}, Preço: {Preco:C}";
        }
    }
}