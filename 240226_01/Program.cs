using System;

string nome = string.Empty;
Console.WriteLine( "Qual é o seu nome?");
nome = Console.ReadLine();

Console.WriteLine("\n");

string email = string.Empty;
Console.WriteLine("Qual o seu email?");
email = Console.ReadLine();

Console.WriteLine("\n");

string nascimento = string.Empty;
Console.WriteLine( "Qual a data de seu nascimento?");
nascimento = Console.ReadLine();

Console.WriteLine("\n");

string genero = string.Empty;
Console.WriteLine( "Qual é o seu genero?");
genero = Console.ReadLine();

Console.WriteLine("\n");

string cep = string.Empty;
Console.WriteLine( "Qual é o seu cep?");
cep = Console.ReadLine();

Console.WriteLine("\n");

string rua = string.Empty;
Console.WriteLine( "Qual a sua rua?");
rua = Console.ReadLine();

Console.WriteLine("\n");

string numero = string.Empty;
Console.WriteLine( "Qual o numero de sua casa?");
numero = Console.ReadLine();

Console.WriteLine("\n");

string bairro = string.Empty;
Console.WriteLine( "Qual o seu bairro?");
bairro = Console.ReadLine();

Console.WriteLine("\n");

string cidade = string.Empty;
Console.WriteLine( "Qual a sua cidade?");
cidade = Console.ReadLine();

Console.WriteLine("\n");

string uf = string.Empty;
Console.WriteLine( "Qual o seu UF?");
uf = Console.ReadLine();

Console.WriteLine("\n");

string pais = string.Empty;
Console.WriteLine( "Qual o seu pais?");
pais = Console.ReadLine();

Console.WriteLine("\n");

string resultado = $"Oi, {nome}, cujo email é {email}, nascido {nascimento},cujo genero é {genero}, o seu endereço é rua {rua}, {bairro}, {cep}, {cidade}, {uf}, e o pais é {pais}";
Console.WriteLine(resultado);
