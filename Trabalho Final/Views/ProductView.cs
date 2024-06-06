using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_Final.Views
{
    public class ProductView
    {
        public ProductView()
        {
            this.Init();
        }

        public void Init()
        {
            Console.WriteLine("MENU PRODUCT");
            Console.WriteLine("*************");
            Console.WriteLine();

            bool aux = true;
            do{
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir Produto");
                Console.WriteLine("2 - Pesquisar Produto");
                Console.WriteLine("3 - Listar Produto");
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
                            Console.WriteLine("Produto 1");
                            Console.WriteLine("");
                        break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Produto pesquisa 2");
                            Console.WriteLine("");
                        break;
                        case 3:
                            Console.WriteLine("");
                            Console.WriteLine("Listar Produto 1");
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