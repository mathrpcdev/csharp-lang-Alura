using System;

namespace pontoFLutuante
{
    class pontoFlutuante
    {
        static void Main(string[] args)
        {

            Console.WriteLine("PROJETO 3 - VARIÁVEIS PONTO FLUTUANTE");

            double salario = 3000.10;

            Console.WriteLine("Meu salário é: " + salario);
            Console.WriteLine("-----------------------------------------------------------------------------------------");

            // VARIÁVEL TESTE NÃO USADA
            double teste = 125.50;


            int divisao = 7 / 5;
            Console.WriteLine("Dividindo números fracionário usando INT TYPE: --> int divisao = 7 / 5 = " + divisao);

            double divisaoComPontoFlutuante = 7.0 / 5.0;
            Console.WriteLine("O resultado da divisão com PONTO FLUTUANTE é: --> double divisaoComPontoFlutuante = 7.0 / 5.0 = " + divisaoComPontoFlutuante);

            //OU PODEMOS UTILIZAR O (DECIMAL) TYPE

            decimal usoDecimal = 7.0m / 5.0m;
            Console.WriteLine("Usando o tipo DECIMALé igual a: " + usoDecimal);
        }
    }
}