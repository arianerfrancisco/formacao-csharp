using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais2");

        int idadeJoao = 15;
        int qtdePessoas = 2;

        if (idadeJoao >= 18 || qtdePessoas >1)
        {
            Console.WriteLine("Pode entrar");
        }
        else
        {
            Console.WriteLine("Não pode entrar");
        }

        Console.WriteLine("Tecle enter para fechar");

        Console.ReadLine();

    }

}
