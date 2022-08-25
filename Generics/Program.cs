
using Generics;

MinhaClasseGenerica<string> objGenerico = new MinhaClasseGenerica<string>();
objGenerico.ExibirDados("Olá mundo!");

MinhaClasseGenerica<int> objGenerico2 = new MinhaClasseGenerica<int>();
objGenerico2.ExibirDados(3);


Pessoa andre = new Pessoa() { Idade = 18, Nome = "André" };
MinhaClasseGenerica<Pessoa> objGenerico3 = new MinhaClasseGenerica<Pessoa>();
objGenerico3.ExibirDados(andre);


public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public override string ToString()
    {
        return $"Nome = {this.Nome} com Idade = {this.Idade}";
    }
}