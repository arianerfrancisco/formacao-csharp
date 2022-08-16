// See https://aka.ms/new-console-template for more information
using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitarios;

Console.WriteLine("Boas vindas ao ByteBank ADM");

Funcionario funcionario1 = new Funcionario(1);
funcionario1.Nome = "João";
funcionario1.Cpf = "545452485";
funcionario1.Salario = 4854;

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();