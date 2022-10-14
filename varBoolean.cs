using System;

namespace varBoolean
{

    class varBoolean
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Projeto 3 - Boolean Variables");
            decimal salario = 3000.10m;
            Console.WriteLine(salario);

            // O tipo DOUBLE também aceita boolean values.
            double salario2 = 800.45;
            Console.WriteLine(salario2);

            //O tipo INT recebe números inteiros, logo, no output irá sair um número inteiro e não boolean (fracionário)
            double idade1 = 7 / 5;
            Console.Write(idade1 + "\n");

            // o tipo DOUBLE guarda números fracionários**
            double idade;
            idade = 7.0 / 5;
            Console.WriteLine("7.0 / 5 = " + idade);


            //O tipo DECIMAL guarda números boolean type
            decimal idadeDois;
            idadeDois = 7.0m / 5m;
            Console.WriteLine("7.0m / 5m = " + idadeDois);


            Console.WriteLine("Tecle enter para fechar...");
            Console.ReadLine();
        }
    }
}