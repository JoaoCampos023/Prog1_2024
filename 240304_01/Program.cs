using System;

Console.WriteLine("Qual a Operação ?");

Console.WriteLine(" 1 - Adição ");

Console.WriteLine(" 2 - Subtração ");

int escolha = Convert.ToInt32(Console.ReadLine());

switch(escolha){
    case 1:
        Console.WriteLine(" Você escolheu adição !!");
        Console.WriteLine(" Digite o primeiro numero ");
        double numero1 = Convert.ToDouble( Console.ReadLine());
        Console.WriteLine(" Digite o Segundo numero ");
        double numero2 = Convert.ToDouble( Console.ReadLine());
        double resultadoAdicao = numero1 + numero2;
        Console.WriteLine($"Resultado: {numero1} + {numero2} =" + resultadoAdicao);
    break;

    case 2:
        Console.WriteLine(" Voce escolheu Subtração !!");
        Console.WriteLine(" Digite o primeiro numero ");
        double numero3 = Convert.ToDouble( Console.ReadLine());
        Console.WriteLine("Digite o Segundo numero ");
        double numero4 = Convert.ToDouble(Console.ReadLine());
        double resultadoSubtracao = numero3 - numero4;
        Console.WriteLine($"Resultado: {numero3} - {numero4} = " + resultadoSubtracao);
    break;
    default:
    break;
}

// teste //
