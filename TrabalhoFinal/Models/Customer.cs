using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoFinal.Models
{
    public class Customer
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public List<Endereco> Enderecos { get; set; } = new List<Endereco>();

        public  Customer (string nome, string telefone, Endereco endereco)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }

        public override string ToString()
        {
            return $"Nome: {Nome},\n Telefone: {Telefone},\n Endereço: {Endereco}";
        }
    }
}