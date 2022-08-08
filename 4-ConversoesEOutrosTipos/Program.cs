using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 - Conversão e outros tipos");

        double salario = 3000.15;

        int salarioInteiro;

        salarioInteiro = (int)salario; // casting, no entanto, o valor 0.15 é desconsiderado

        Console.WriteLine(salario);
        Console.WriteLine("Com o casting, no entanto, o valor 0.15 é desconsiderado");
        Console.WriteLine(salarioInteiro);

        long x = 2000000000000000000; //  o long, que guarda cerca de 64 bits de informação

        short y = 15000; // Para trabalhar com números menores, temos a variável do tipo short, que armazena até 16 bits(ou seja, tem um limite menor).

        float altura = 1.62f; // perde-se precisão na casas após a virgula se comparada com a variavel double


        Console.WriteLine("Tecle enter para fechar");

        Console.ReadLine();

    }

}