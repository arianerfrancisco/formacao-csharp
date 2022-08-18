using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitarios;

Console.WriteLine("Boas vindas ao ByteBank ADM");

CalcularBonificao();
void CalcularBonificao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Diretor maria = new Diretor("475754");
    maria.Nome = "Maria";
    gerenciador.Registrar(maria);

    Auxiliar ana = new Auxiliar("451212121");
    ana.Nome = "Ana";
    gerenciador.Registrar(ana);

    Designer jose = new Designer("47575fsff4");
    jose.Nome = "José";
    gerenciador.Registrar(jose);

    GerenteDeContas pedro= new GerenteDeContas("475dsds754");
    pedro.Nome = "Pedro";
    gerenciador.Registrar(pedro);

    Console.WriteLine("Total de Bonificacao: " + gerenciador.GetBonificacao());

}

Console.ReadKey();