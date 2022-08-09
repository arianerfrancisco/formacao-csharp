using System;

class Programa
{
    static void Main(string[] args)
    {
        int fatorial = 1;
        for (int i = 1; i < 11; i++)
        {
            fatorial *= i;
            Console.WriteLine("Fatorial de " + i + " = " + fatorial);
        }

        Console.WriteLine("Tecle enter para fechar");

        Console.ReadLine();

    }

}
