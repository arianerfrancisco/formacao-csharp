using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 8 - Calcula Poupança");

        double investimento = 1000;
        double rendimento = 0.005; // rendimento de 0,5% ao mês
        int mes = 1;
        
        while (mes <= 12)
        {
            investimento = investimento +  investimento * rendimento;
            Console.WriteLine("O rendimento do seu investimento no final do mês: " + mes + " será de: " + investimento + "reais");
            mes += 1;
        }
   

        Console.WriteLine("Tecle enter para fechar");

        Console.ReadLine();

    }

}

