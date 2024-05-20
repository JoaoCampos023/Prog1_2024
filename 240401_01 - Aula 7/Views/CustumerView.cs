using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using _240401_01___Aula_7.Controllers;
using _240401_01___Aula_7.Models;
using _240401_01___Aula_7.Repository;

namespace _240401_01___Aula_7.Views
{
    public class CustumerView
    {
        private CustumerController custumerController;
        private AddressView addressView;

        public CustumerView()
        {
            addressView = new AddressView();
            custumerController = new CustumerController();
            this.Init();
        }


        public void Init()
        {
            Console.WriteLine("*************");
            Console.WriteLine("MENU CUSTUMER");
            Console.WriteLine("*************");
            Console.WriteLine();

            bool aux = true;
            do{
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir Consumidor");
                Console.WriteLine("2 - Pesquisar Consumidor");
                Console.WriteLine("3 - Listar Consumidor");
                Console.WriteLine("4 - Deletar Consumidor");
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
                            InsertCustumer();
                        break;
                        case 2:
                            SearchCustumer();
                        break;
                        case 3:
                            ListCustumer();
                        break;
                        case 4:
                            DeleteCustumer();
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

        private void InsertCustumer()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("INSERIR NOVO CONSUMIDOR");
            Console.WriteLine("***********************");

            Custumer custumer = new Custumer();
            
            Console.Write("Nome: ");
            custumer.Name = Console.ReadLine();
            Console.WriteLine("");
            
            Console.Write("Email: ");
            custumer.EmailAddress = Console.ReadLine();
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
                        custumer.Addresses.Add(addressView.Insert());
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
                custumerController.Insert(custumer);
                Console.WriteLine("Custumer inserido com sucesso!");  
            }
            catch
            {
                Console.WriteLine("Ops! Ocorreu um erro. ");
            }
        }

        private void SearchCustumer()
        {

            int aux = -1;

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
                        int id = Convert.ToInt32(Console.ReadLine());
                        ShowCustumerById(id);
                    break;
                    case 2:
                        Console.WriteLine("Informe o Nome: ");
                        string name = Console.ReadLine();
                        ShowCustumerByName(name);                    
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

        private void ShowCustumerById(int id)
        {
            Custumer c = custumerController.Get(id);
            if(c != null)
            {
                Console.WriteLine(c.ToString());
            }
            else
            {
                Console.WriteLine($"Consumidor de id {id} não encontrado");
            }
        }

        private void ShowCustumerByName(string name)
        {
            List<Custumer>result = custumerController.GetByName(name);
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

            foreach(Custumer custumer in result)
            {
                Console.WriteLine(custumer.ToString());
            }
        }

        private void ListCustumer()
        {
            List<Custumer>result = custumerController.Get();
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

            foreach(Custumer custumer in result)
            {
                Console.WriteLine(custumer.ToString());
            }            
        }

        private void DeleteCustumer()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("DELETAR CONSUMIDOR");
            Console.WriteLine("*********************");

            Console.Write("Informe o Id do Consumidor: ");
            int id = Convert.ToInt32(Console.ReadLine());

            try
            {
                bool suceess = custumerController.Delete(id);
                if(suceess)
                {
                    Console.WriteLine("Consumidor deletado com sucesso!");
                }
                else
                {
                    Console.WriteLine($"Consumidor de id {id} não encontrado.");
                }
            }
            catch
            {
                Console.WriteLine("Ops! Ocorreu um erro.");
            }
        }
    }
}