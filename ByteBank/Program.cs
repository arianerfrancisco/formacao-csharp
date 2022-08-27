using ByteBank;
using ByteBank.ByteBank.Exceptions;

//Teste();
//TesteSaque();
//TesteSaqueInnerException();

static void Teste()
{
    try
    {
        ContaCorrente conta = new ContaCorrente(5025, 52665);
        conta.Depositar(50);
        Console.WriteLine(conta.Saldo);
        conta.Sacar(50);
        Console.WriteLine(conta.Saldo);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
        Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
        Console.WriteLine(ex.Message);
    }
    Console.ReadLine();
}
static void TesteSaque()
{
    try
    {
        ContaCorrente conta = new ContaCorrente(5025, 52665);
        conta.Depositar(50);
        Console.WriteLine(conta.Saldo);
        conta.Sacar(500);
        Console.WriteLine(conta.Saldo);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
        Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
        Console.WriteLine(ex.Message);
    }
    catch (SaldoInsuficienteException ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
    }

    Console.ReadLine();
}
static void TesteSaqueInnerException()
{
    try
    {
        ContaCorrente conta = new ContaCorrente(5265, 52665);
        ContaCorrente conta2 = new ContaCorrente(5245, 52425);

        conta.Depositar(50);
        Console.WriteLine(conta.Saldo);
        //conta.Sacar(500);
        conta.Transferir(500, conta2);
        Console.WriteLine(conta.Saldo);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
        Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
        Console.WriteLine(ex.StackTrace);
        Console.WriteLine(ex.Message);
    }
    catch (OperacaoFinanceiraException ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.StackTrace);

        Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");
        //informações da inner exception não são exibidas para o usuário da aplicação,

        Console.WriteLine(ex.InnerException.Message);
        Console.WriteLine(ex.InnerException.StackTrace);
    }
    Console.ReadLine();
}