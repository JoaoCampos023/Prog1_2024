using Trabalho_Final.Views;
using Trabalho_Final.Models;

bool aux = true;
do
{
    Console.WriteLine("**********************");
    Console.WriteLine("Restaurante / Delivery");
    Console.WriteLine("**********************");
    Console.WriteLine();

    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Produtos");
    Console.WriteLine("3 - Pedidos");
    Console.WriteLine("0 - Sair");

    int menu = 0;

    try
    {
        menu = Convert.ToInt32(Console.ReadLine());
        switch(menu)
        {
            case 1:
                CustomerView custumerView = new CustomerView();
            break;
            case 2:
                ProductView productView = new ProductView();
            break;
            case 3:
                OrderView orderView = new OrderView();
            break;
            case 0:
                aux = false;
                Console.WriteLine("OBRIGADO E VOLTE SEMPRE");
            break;
            default:
                Console.WriteLine("Opção Invalida.");
            break;
        }
    }
    catch
    {
        Console.WriteLine("Opção Invalida");
        aux = true;
        menu = -1;
    } 

}while(aux);
