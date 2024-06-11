using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoFinal.Models;
using TrabalhoFinal.Repository;
using TrabalhoFinal.View;

namespace TrabalhoFinal.Controller
{
    public class RestauranteController
    {
        private IRepositorio<Prato> pratoRepository;
        private List<Pedido> pedidos;

        public RestauranteController()
        {
            pratoRepository = new PratoRepository();
            pedidos = new List<Pedido>();
        }

        public void InserirPrato(string nome, string descricao, decimal preco)
        {
            Prato novoPrato = new Prato(nome, descricao, preco);
            pratoRepository.Adicionar(novoPrato);
        }

        public void RemoverPrato(string nome)
        {
            pratoRepository.Remover(nome);
        }

        public Prato BuscarPrato(string termo)
        {
            return pratoRepository.Buscar(termo);
        }

        public List<Prato> ListarPratos()
        {
            return pratoRepository.Listar();
        }

        public Pedido RegistrarPedido(Customer customer)
        {
            Pedido pedido = new Pedido(customer);
            pedidos.Add(pedido);
            return pedido;
        }
    }
}