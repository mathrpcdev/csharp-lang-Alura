using System;

namespace varBoolean
{

    class varExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando Variáveis");
            int idade = 27;
            Console.WriteLine("--------------Mostra idade----------\n" + idade);


            idade = 27 - 5;
            Console.WriteLine("--------------Mostra idade----------\n" + idade);

            idade = 5 * 2 - 6;
            Console.WriteLine("--------------Mostra idade----------\n" + idade);


            idade = (5 - 2) * 3;
            Console.WriteLine("--------------Mostra idade----------\n" + idade);

            Console.WriteLine("Tecle enter para fechar...");
            Console.ReadLine();


        }
    }

}




