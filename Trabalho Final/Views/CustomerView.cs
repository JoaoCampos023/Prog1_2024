using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trabalho_Final.Models;
using Trabalho_Final.Repository;
using Trabalho_Final.Controllers;


namespace Trabalho_Final.Views
{
    public class CustomerView
    {
        private CustomerController customerController;
        private AddressView addressView;

        public CustomerView()
        {
            addressView = new AddressView();
            customerController = new CustomerController();
            this.Init();
        }
        
        public void Init()
        {
            Console.WriteLine("********************");
            Console.WriteLine(" MENU DO CONSUMIDOR ");
            Console.WriteLine("********************");
            Console.WriteLine();

            bool aux = true;
            do{
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir Consumidor");
                Console.WriteLine("2 - Pesquisar Consumidor");
                Console.WriteLine("3 - Listar Consumidor");
                Console.WriteLine("4 - Deletar Consumidor");
                Console.WriteLine("5 - Exportar Delimitado");
                Console.WriteLine("0 - Sair");

                int menu = 0;
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch(menu)
                    {
                        case 0:
                            aux = false;
                        break;
                        case 1:
                            InsertCustomer();
                        break;
                        case 2:
                            SearchCustomer();
                        break;
                        case 3:
                            ListCustomer();
                        break;
                        case 4:
                            DeleteCustomer();
                        break;
                        case 5:
                        {
                            if(customerController.ExportToDelimited())
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Exportado com Sucesso!");
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Falha ao Exportar!");
                                Console.WriteLine("");                                
                            }
                            

                        }
                        break;
                        default:
                            Console.WriteLine("Opção invalida.");
                            aux = true;
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

        private void InsertCustomer()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("INSERIR NOVO CONSUMIDOR");
            Console.WriteLine("***********************");

            Customer customer = new Customer();
            
            Console.Write("Nome: ");
            customer.Name = Console.ReadLine();
            Console.WriteLine("");
            
            Console.Write("Email: ");
            customer.EmailAddress = Console.ReadLine();
            Console.WriteLine("");

            
            
            int aux = 0;
            do{
                Console.WriteLine("Deseja informar endereço? ");
                Console.WriteLine("0 = Não");
                Console.WriteLine("1 = Sim");

                try
                {
                    aux = Convert.ToInt32(Console.ReadLine());
                    if(aux == 1)
                    {
                        customer.Addresses.Add(addressView.Insert());
                    }
                    else if(aux == 0)
                    {
                        break;
                    }
                    else
                    {
                        aux = 1;
                        Console.WriteLine("Opção Invalida.");
                        Console.WriteLine("Tente Novamente."); 
                    }
                }
                catch
                {
                    aux = 1;
                    Console.WriteLine("Opção Invalida.");
                    Console.WriteLine("Tente Novamente.");
                }
            }while(aux != 0);

            try
            {
                customerController.Insert(customer);
                Console.WriteLine("Custumer inserido com sucesso!");  
            }
            catch
            {
                Console.WriteLine("Ops! Ocorreu um erro. ");
            }
        }

        private void SearchCustomer()
        {

            int aux = -1;
            int id = -1;

            do{
                Console.WriteLine("PESQUISAR CLIENTE");
                Console.WriteLine("*****************");
                Console.WriteLine(" 1 - Buscar por Id");
                Console.WriteLine(" 2 - Buscar por Nome");
                Console.WriteLine(" 0 - Sair");

                aux = Convert.ToInt16(Console.ReadLine());
            
                switch(aux)
                {
                    case 1:
                        Console.WriteLine("Informe o Id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        ShowCustomerById(id);


                    break;
                    case 2:
                        Console.WriteLine("Informe o Nome: ");
                        string name = Console.ReadLine();
                        ShowCustomerByName(name);  
                        Console.WriteLine("Informe o Id: ");
                        id = Convert.ToInt32(Console.ReadLine());              
                    break;
                    
                    case 0:

                    break;

                    default:
                        aux = -1;
                        Console.WriteLine("Opção Invalida");
                    break;
                }

            }while(aux != 0);
        }

        private void ShowCustomerById(int id)
        {
            Customer c = customerController.Get(id);
            if(c != null)
            {
                Console.WriteLine(c.ToString());
            }
            else
            {
                Console.WriteLine($"Consumidor de id {id} não encontrado");
            }
        }

        private void ShowCustomerByName(string name)
        {
            List<Customer>result = customerController.GetByName(name);
            if(result == null)
            {
                Console.WriteLine("Não Encontrado");
                return;
            }

            if(result.Count == 0)
            {
                Console.WriteLine("Não Encontrado");
                return;                
            }

            foreach(Customer customer in result)
            {
                Console.WriteLine(customer.ToString());
            }
        }

        private void ListCustomer()
        {
            List<Customer>result = customerController.Get();
            if(result == null)
            {
                Console.WriteLine("Não Encontrado");
                return;
            }

            if(result.Count == 0)
            {
                Console.WriteLine("Não Encontrado");
                return;                
            }

            foreach(Customer customer in result)
            {
                Console.WriteLine(customer.ToString());
            }            
        }

        private void DeleteCustomer()
        {
            Console.WriteLine("******************");
            Console.WriteLine("DELETAR CONSUMIDOR");
            Console.WriteLine("******************");

            int id;
            do
            {
                try
                {
                    Console.Write("Informe o Id do Consumidor: ");
                    id = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Valor inserido Invalido! ");
                    id = -1;
                }
            }while(id == -1);

            ShowCustomerById(id);
            Customer c = customerController.Get(id);

            Console.WriteLine("Deseja remover o consumidor acima? ");

            int aux;
            do
            {
                try
                {
                    Console.WriteLine("1 - Sim ");
                    Console.WriteLine("2 - Não ");
                    aux = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Valor inserido Invalido!");
                    aux = -1;
                }
            }while (aux == -1);

            if(aux == 1)
            {
                customerController.Remove(c);
            }

            Console.WriteLine("Consumidor Removido com Sucesso!");
        }
    }
}