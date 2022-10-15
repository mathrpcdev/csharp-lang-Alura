using System;
class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Cursos de C# alura " + 2022);
        Console.WriteLine("---------------------------------------------------------");
        float pontoFlutuante = 334.4243f; // FLOAT e INT comporta 32 bits.
        Console.WriteLine("O float comporta até 32 bits. Ex: " + pontoFlutuante + "\n");


        double salario = 1270.50; // DOUBLE armazena 64 bits.
        int valor = (int)salario;  // Aqui é necessário o uso de CASTING. Converter um número MAIOR para um número MENOR, pois o INT apenas comporta 32 bits.
        Console.WriteLine("O DOUBLE armazena ponto flutuantes de até 32 bits. Ex: " + salario + "\n");

        double primeiroValor = 3000.10;
        double segundoValor = primeiroValor + 70;
        double total = segundoValor + 09.67;

        Console.WriteLine("Primeira variável fracionária + segunda variável fracionária = " + total);
        Console.WriteLine();

        double idade = 30.0;
        Console.WriteLine("Para armazenarmos um double no int precisamos do casting Ex: ");
        Console.WriteLine("double variávelDouble1 = (int)variávelDouble2");
        Console.WriteLine("A idade de Marcos é " + (int)idade + "!");

        // o CHAR comporta apenas UM valor. Ex ' ' ou 'T'.
        char letra = 't';
        Console.WriteLine(letra);
        Console.WriteLine("CASTING de INT para CHAR é: \n");
        Console.WriteLine("char exemplo = (char)103");
        char value = (char)103;   // CASTING de número para CHAR
        Console.WriteLine(value);

        // OUTROS EXEMPLOS DE CASTING DE NÚMERO PARA CHAR.
        value = (char)(value + 1);
        Console.WriteLine(value); //B

        int letra2 = (int)value + 3;
        Console.WriteLine(letra2);

        //******************************************  FIM  ************************************************************************************************
    }
}
