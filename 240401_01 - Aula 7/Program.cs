using _240401_01___Aula_7.Models;
using _240401_01___Aula_7.Views;


bool aux = true;
do{
    Console.WriteLine("***********************");
    Console.WriteLine("Meu Programa de Pedidos");
    Console.WriteLine("***********************");
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
                CustumerView custumerView = new CustumerView();
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




















/*
Console.WriteLine("Hello, World!");

Custumer c1 = new Custumer();
c1.Name = "Joao";
c1.EmailAddress = "joaovcampos023@gmail.com";

// Construtor por Instanciação
Custumer c2 = new Custumer(2);
c1.Name = "Joao Vitor";
c1.EmailAddress = "joaovitorcampos23@gmail.com";

// Construtor por atribuição 
Custumer c3 = new Custumer{
    CustumerId = 3,
    Name = "Jaguara",
    EmailAddress = "jaguara023@gmail.com"
};
*/

