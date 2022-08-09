using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeJoao = 18;
        
        if(idadeJoao >= 18)
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
