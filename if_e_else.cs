using System;
class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("TESTANDO CONDICIONAIS");
        Console.WriteLine("---------------------------------------------------------\n");

        int quantidadeDePessoas = 1;
        int idade = 10;
        if (idade >= 18)
        {
            Console.WriteLine("A idade é maior ou igual a 18");
        }
        else
        {
            Console.WriteLine("A variável 'idade' é menor que 18");
        }
        if (quantidadeDePessoas >= 2)
        {
            Console.WriteLine("Está acompanhado/a. Pode entrar!");
        }
        else
        {
            if (quantidadeDePessoas < 3)
            {
                Console.WriteLine("Você não tem acompanhante para poder entrar.\n");
            }
        }

        Console.WriteLine("------------------------ABAIXO SEGUEM OS EXERCICIOS COM USO DE ||(OR) e &&(AND) -------------------------------------------\n");

        int Rogério = 68;
        bool ehIdoso = Rogério >= 65; //BOOLEAN TYPE apenas aceita TRU or FALSE
        Console.WriteLine("É idoso? - " + ehIdoso);


        int age = 12;
        int peopleNumbers = 2;
        bool acompanhado = false;

        if (age >= 18 || acompanhado)
        {
            Console.WriteLine("Está desacompanhado mas é maior de idade.");
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            if (age < 18 && peopleNumbers > 1)
            {
                Console.WriteLine("Além de ser menor de idade, não está acompanhado.");
                Console.WriteLine("Infelizmente você não pode entrar!");
            }
        }
    }
}
//******************************************  FIM  ************************************************************************************************