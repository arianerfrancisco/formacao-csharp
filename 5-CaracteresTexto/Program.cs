using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e Textos");

        char letra = 'a'; // armazena 1 caractere
        Console.WriteLine(letra);

        string primeiraFrase = "Olá!!!! ";
        Console.WriteLine(primeiraFrase + "Tudo bem?"); // o @ aceita quebra de linha
        Console.WriteLine(@"
A
B
C
D
E
F");

        Console.WriteLine("Tecle enter para fechar");

        Console.ReadLine();

    }

}
