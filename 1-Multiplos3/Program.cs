using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desafio multiplos de 1 a 100");

        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
                Console.WriteLine(i);
                                    
        }

        Console.WriteLine("Tecle enter para fechar");

        Console.ReadLine();

    }

}
