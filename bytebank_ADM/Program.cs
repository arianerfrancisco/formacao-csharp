// See https://aka.ms/new-console-template for more information
using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitarios;

Console.WriteLine("Boas vindas ao ByteBank ADM");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Funcionario joao = new Funcionario();
joao.Nome = "João";
joao.Cpf = "545452485";
joao.Salario = 2000;

gerenciador.Registrar(joao);

Diretor maria= new Diretor();
maria.Nome = "Maria";
maria.Cpf = "475754";
maria.Salario = 30000;
gerenciador.Registrar(maria);

Console.WriteLine(joao.Nome);
Console.WriteLine("Bonificacao Funcionário: " + joao.getBonificacao());

Console.WriteLine(maria.Nome);
Console.WriteLine("Bonificacao Diretor: " + maria.getBonificacao());


Console.WriteLine("Total Bonificação: " + gerenciador.GetBonificacao());