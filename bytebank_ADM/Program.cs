// See https://aka.ms/new-console-template for more information
using bytebank_ADM.Funcionarios;

Console.WriteLine("Boas vindas ao ByteBank ADM");

Funcionario funcionario1 = new Funcionario(2);
funcionario1.Nome = "João";
funcionario1.Cpf = "545452485";
funcionario1.Salario = 4854;

Console.WriteLine(funcionario1.Salario);
Console.WriteLine(funcionario1.getBonificacao()); 