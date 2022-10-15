using System;
class Programa
{

    static void Main(string[] args)
    {

        float pontoFlutuante = 334.4243f; // FLOAT e INT comporta 32 bits.
        Console.WriteLine(pontoFlutuante);


        double salario = 1270.50; // DOUBLE armazena 64 bits.
        int valor = (int)salario;  // Aqui é necessário o uso de CASTING. Converter um número MAIOR para um número MENOR, pois o INT apenas comporta 32 bits.
        Console.WriteLine(salario);
        Console.WriteLine();

        double primeiroValor = 3000.10;
        double segundoValor = primeiroValor + 70;
        double total = segundoValor + 09.67;

        Console.WriteLine(total);
        Console.WriteLine();

        double idade = 30.0;
        Console.WriteLine("A idade de Marcos é " + (int)idade + "!");

    }
}