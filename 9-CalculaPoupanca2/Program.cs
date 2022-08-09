using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 9 - Calcula Poupança 2");

        double investimento = 1000;
        double rendimento = 1.005; // rendimento de 5% ao mês
        
        for(int ano = 1; ano <= 5 ; ano++) // considerando um investimento a longo prazo
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= rendimento;
             }

            rendimento += 0.001;
        }

        Console.WriteLine("O rendimento do seu investimento no final de 5 anos será de: " + investimento + "reais");

        Console.WriteLine("Tecle enter para fechar");

        Console.ReadLine();

    }

}

