using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variáveis");

        int idade = 10; // estaticamente tipada
        int soma = idade + 10;
        Console.WriteLine("Minha idade é " + soma + " anos");
        // Console.Write: não pula linha
        Console.Write("Minha idade é " + soma + " anos");

        Console.WriteLine("Tecle enter para fechar");

        Console.ReadLine();

    }

}
