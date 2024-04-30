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

        public CustumerView()
        {
            custumerController = new CustumerController();
            this.Init();
        }


        public void Init()
        {
            Console.WriteLine("MENU CUSTUMER");
            Console.WriteLine("*************");
            Console.WriteLine();

            bool aux = true;
            do{
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir Consumidor");
                Console.WriteLine("2 - Pesquisar Consumidor");
                Console.WriteLine("3 - Listar Consumidor");
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
                        break;
                        case 2:
                        break;
                        case 3:
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
                        // carga endereço
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
            
        }
    }
}