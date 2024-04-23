using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240401_01___Aula_7.Views
{
    public class OrderView
    {
        public OrderView()
        {
            this.Init();
        }

        public void Init()
        {
            Console.WriteLine("MENU ORDER");
            Console.WriteLine("*************");
            Console.WriteLine();

            bool aux = true;
            do{
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir Pedido");
                Console.WriteLine("2 - Pesquisar Pedido");
                Console.WriteLine("3 - Listar Pedido");
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
                            Console.WriteLine("");
                            Console.WriteLine("Pedido 1");
                            Console.WriteLine("");
                        break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Pedido pesquisa 2");
                            Console.WriteLine("");
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
    }
}