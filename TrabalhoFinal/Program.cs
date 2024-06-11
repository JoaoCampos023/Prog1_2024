using TrabalhoFinal.Models;
using TrabalhoFinal.View;
using TrabalhoFinal.Controller;

bool aux = true;

do{
    Console.WriteLine("***********************");
    Console.WriteLine("Meu Programa de Pedidos");
    Console.WriteLine("***********************");
    Console.WriteLine();

    Console.WriteLine("1 - Restaurante");
    Console.WriteLine("0 - Sair");

    int menu = 0;

    try
    {
        menu = Convert.ToInt32(Console.ReadLine());
        switch(menu)
        {
            case 1:
                RestauranteView restauranteView = new RestauranteView();
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