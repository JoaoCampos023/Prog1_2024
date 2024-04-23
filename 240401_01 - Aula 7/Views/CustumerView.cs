using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240401_01___Aula_7.Views
{
    public class CustumerView
    {
        public CustumerView()
        {
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