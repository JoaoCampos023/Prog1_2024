using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoFinal.Controller;
using TrabalhoFinal.Models;
using TrabalhoFinal.Repository;

namespace TrabalhoFinal.View
{
    public class RestauranteView
    {
        private RestauranteController controller;

        public RestauranteView(RestauranteController controller)
        {
            this.controller = controller;
        }

        public void MostrarMenu()
        {
            while(true)
            {
                Console.WriteLine("\nSistema de Gerenciamento de Restaurante");
                Console.WriteLine("1 - Inserir Prato");
                Console.WriteLine("2 - Remover Prato");
                Console.WriteLine("3 - Buscar Prato");
                Console.WriteLine("4 - Listar Pratos");
                Console.WriteLine("5 - Registrar Pedido");
                Console.WriteLine("6 - Sair");
                Console.WriteLine("Escolha uma opção:");

                string opcao = Console.ReadLine();
                switch(opcao)
                {
                    case 1:
                        InserirPrato();
                    break;
                    case 2:
                        RemoverPrato();
                    break;
                    case 3:
                        BuscarPrato();
                    break;
                    case 4:
                        ListarPrato();
                    break;
                    case 5:
                        RegistrarPedido();
                    break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Opção Invalida.");
                    break;
                }
            }
        }

        private void InserirPrato()
        {
            Console.WriteLine("Nome do Prato: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Descrição do Prato: ");
            string descricao = Console.ReadLine();
            Console.WriteLine("Preço do Prato: ");
            decimal preco;
            if(decimal.TryParse(Console.ReadLine(), out preco) && preco > 0)
            {
                controller.InserirPrato(nome, descricao, preco);
            }
            else
            {
                Console.WriteLine("Preço invalido.");
            }
        }

        private void RemoverPrato()
        {
            Console.WriteLine("Nome do prato a remover:");
            string nomeARemover = Console.ReadLine();
            controller.RemoverPrato(nomeARemover);
        }

        private void BuscarPrato()
        {
            Console.WriteLine("Digite o nome ou descrição do prato para buscar:");
            string termoBusca = Console.ReadLine();
            Prato prato = controller.BuscarPrato(termoBusca);
            if(prato != null)
            {
                Console.WriteLine(prato);
            }
            else
            {
                Console.WriteLine($"Nenhum prato encontrado com o termo '{termoBusca}'.");
            }
        }

        private void ListarPrato()
        {
            List<Prato> pratos = controller.ListarPratos();
            if(pratos.Count > 0)
            {
                foreach(var prato in pratos)
                {
                    Console.WriteLine(prato);
                }
            }
            else
            {
               Console.WriteLine("Nenhum prato cadastrado."); 
            }
        }

        private void RegistrarPedido()
        {
            Console.WriteLine("Nome do consumidor:");
            string nomeCustomer = Console.ReadLine();
            Console.WriteLine("Telefone do consumidor:");
            string telefoneCustomer = Console.ReadLine();
                        
            Console.WriteLine("Rua:");
            string rua = Console.ReadLine();
            Console.WriteLine("Número:");
            string numero = Console.ReadLine();
            Console.WriteLine("Bairro:");
            string bairro = Console.ReadLine();
            Console.WriteLine("Cidade:");
            string cidade = Console.ReadLine();
            Console.WriteLine("Estado:");
            string estado = Console.ReadLine();
            Console.WriteLine("CEP:");
            string cep = Console.ReadLine(); 

            Endereco endereco = new Endereco(rua, numero, bairro, cidade, estado, cep);
            Customer customer = new Customer(nomeCustomer, telefoneCustomer, endereco);

            Pedido pedido = controller.RegistrarPedido(customer);

            while(true)
            {
                Console.WriteLine("Digite o nome do prato para adicionar ao pedido (ou 'sair' para finalizar):");
                string nomePrato = Console.ReadLine();
                if(nomePrato.ToLower() == "sair")
                {
                    break;
                }

                Prato prato = controller.BuscarPrato(nomePrato);
                if(prato != null)
                {
                    Console.WriteLine("Digite a quantidade: ");
                    int quantidade;
                    if(int.TryParse(Console.ReadLine(), out quantidade) && quantidade > 0)
                    {
                        pedido.AdicionarPrato(prato, quantidade);
                    }
                    else
                    {
                        Console.WriteLine("Quantidade inválida.");
                    }
                }
                else
                {
                    Console.WriteLine($"Prato {nomePrato} não encontrado.");
                }
                Console.WriteLine("Pedido registrado:");
                Console.WriteLine(pedido);
            }
        }
    }
}