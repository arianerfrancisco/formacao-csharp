using ExcecoesArquivos;


//CarregarContas();
//UtilizandoUsing();

static void CarregarContas() // utilizando try/catch
{
    LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");
    try
    {
        // variáveis definidas neste escopo, ficam restritas a aqui.
        leitor.LerProximaLinha();
        leitor.LerProximaLinha();
        leitor.LerProximaLinha();
    }
    catch (IOException e)
    {
        Console.WriteLine("Exceção do tipo IOException capturada e tratada! ");
    }
    finally
    {
        leitor.Fechar();
    }
}

static void UtilizandoUsing()
{
    using (LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"))
    {
        leitor.LerProximaLinhaUsing();
        leitor.LerProximaLinhaUsing();
        leitor.LerProximaLinhaUsing();
    }
}