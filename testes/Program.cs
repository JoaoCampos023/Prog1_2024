// Solicitação do operador aritmético
WriteLine("Digite o operador aritmético desejado (+, -, *, /): ");
char operador = ReadKey().KeyChar; // Lê o primeiro caractere digitado pelo usuário

// Validação do operador
if (operador != '+' && operador != '-' && operador != '*' && operador != '/')
{
    WriteLine("\n Operador inválido.");
    return; // Encerra o programa se o operador for inválido
}

WriteLine($"\nTabuada do operador {operador}:");

// Laço de repetição for para iterar de 1 a 9 (multiplicandos)
for (int i = 1; i <= 9; i++)
{
// Laço de repetição for para iterar de 1 a 9 (multiplicadores)
    for (int j = 1; j <= 9; j++)
    {
        int resultado = 0;

        // Calcula o resultado com base no operador aritmético
        switch (operador)
        {
            case '+':
                resultado = i + j;
                break;
            case '-':
                resultado = i - j;
                break;
            case '*':
                resultado = i * j;
                break;
            case '/':
                if (j != 0) // Evita divisão por zero
                    resultado = i / j;
                break;
        }

        // Imprime o resultado formatado na tela
        Write($"{i} {operador} {j} = {resultado,-3}\t");
    }
    WriteLine(); // Quebra de linha para imprimir a próxima linha da tabuada
}

