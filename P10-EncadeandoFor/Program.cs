using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Encadeando laço for");

        for( int contadorLinhas=1; contadorLinhas <10; contadorLinhas++ )
        {
            string str = new string('*', contadorLinhas);
            Console.WriteLine(str);
        }

        Console.WriteLine("Tecle enter para fechar");

        Console.ReadLine();

    }

}