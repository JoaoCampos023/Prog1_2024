using _240401_01___Aula_7.Models;

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
