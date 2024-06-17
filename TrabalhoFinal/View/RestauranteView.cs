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
        private RestauranteController restauranteController;

        public RestauranteView()
        {
            restauranteController = new RestauranteController();
            this.Init();
        }

        public void Init()
        {
            Console.WriteLine("****************");
            Console.WriteLine("MENU RESTAURANTE");
            Console.WriteLine("****************");
            Console.WriteLine();

            bool aux = true;
            do
            {
                Console.WriteLine("\nSistema de Gerenciamento de Restaurante");
                Console.WriteLine("1 - Inserir Prato");
                Console.WriteLine("2 - Remover Prato");
                Console.WriteLine("3 - Buscar Prato");
                Console.WriteLine("4 - Listar Pratos");
                Console.WriteLine("5 - Registrar Pedido");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Escolha uma opção:");

                int menu = 0;

                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch(menu)
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
                        case 0:
                            return;
                        default:
                            Console.WriteLine("Opção Invalida.");
                        break;
                    }                    
                }
                catch
                {
                    Console.WriteLine("Opção invalida.");
                    menu = -1;
                }
            }while(aux);
        }

        private void InserirPrato()
        {
            Console.WriteLine("Nome do Prato: ");
            string? nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Descrição do Prato: ");
            string? descricao = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Preço do Prato: ");
            decimal preco;
            if(decimal.TryParse(Console.ReadLine(), out preco) && preco > 0)
            {
                restauranteController.InserirPrato(nome!, descricao!, preco);
            }
            else
            {
                Console.WriteLine("Preço invalido.");
            }
        }

        private void RemoverPrato()
        {
            Console.WriteLine("Nome do prato a remover:");
            string? nomeARemover = Console.ReadLine();
            restauranteController.RemoverPrato(nomeARemover!);
            Console.WriteLine();
        }

        private void BuscarPrato()
        {
            Console.WriteLine("Digite o nome ou descrição do prato para buscar:");
            string? termoBusca = Console.ReadLine();
            Prato prato = restauranteController.BuscarPrato(termoBusca!);
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
            List<Prato> pratos = restauranteController.ListarPratos();
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
            string? nomeCustomer = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Telefone do consumidor:");
            string? telefoneCustomer = Console.ReadLine();
            Console.WriteLine();
                        
            Console.WriteLine("Rua:");
            string? rua = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Número:");
            string? numero = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Bairro:");
            string? bairro = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Cidade:");
            string? cidade = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Estado:");
            string? estado = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("CEP:");
            string? cep = Console.ReadLine();
            Console.WriteLine();

            Endereco endereco = new Endereco(rua!, numero!, bairro!, cidade!, estado!, cep!);
            Customer customer = new Customer(nomeCustomer!, telefoneCustomer!, endereco);

            Pedido pedido = restauranteController.RegistrarPedido(customer);

            while(true)
            {
                Console.WriteLine("Digite o nome do prato para adicionar ao pedido (ou 'sair' para finalizar):");
                string? nomePrato = Console.ReadLine();
                if(nomePrato!.ToLower() == "sair")
                {
                    break;
                }

                Prato prato = restauranteController.BuscarPrato(nomePrato);
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