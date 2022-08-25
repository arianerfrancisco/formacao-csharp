using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Util
{
    public class ListaDeContasCorrentes
    {
        private ContaCorrente[] _itens = null;
        // Criaremos uma instância do array _itens no momento em que criarmos um objeto ListaDeContasCorrentes
        private int _proximaPosicao = 0;
        public ListaDeContasCorrentes(int tamanhoInicial = 5)
        {
            _itens = new ContaCorrente[tamanhoInicial];
        }
        // No momento em que invocarmos o construtor, _itens receberá um novo vetor de ContaCorrentes.O tamanho desse vetor será informado pelo parâmetro tamanhoInicial, que definiremos como 5 por padrão:
        // Desse modo, caso não passemos nenhum valor ao invocar o construtor, a variável tamanhoInicial terá o tamanho padrão de 5. Do contrário, tamanhoInicial assumirá o valor informado.
        public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
            VerificarCapacidade(_proximaPosicao + 1);
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return; // para de executar o VerificarCapacidade
            }
            Console.WriteLine("Aumentando a capacidade da lista!");
            ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];
            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
            }
            _itens = novoArray;
        }

        public void Remover(ContaCorrente conta)
        {
            int indiceItem = -1;
            for (int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente contaAtual = _itens[i];
                if (contaAtual == conta)
                {
                    indiceItem = i;
                    break;
                }
            }
            // 0         1       2
            //[conta1][conta2][conta4][conta5][null]
            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }
            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }

        public void ExibeLista()
        {
            for (int i = 0; i < _itens.Length; i++)
            {
                if (_itens[i] != null)
                {
                    var conta = _itens[i];
                    Console.WriteLine($" Indice[{i}] = " +
                        $"Conta:{conta.Conta} - " +
                        $"N° da Agência: {conta.Numero_agencia}");
                }
            }
        }
        public ContaCorrente RecuperarContaNoIndice(int indice)
        {
            if(indice<0 || indice>=_proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];
        }

        public int Tamanho {
            get
            {
                return _proximaPosicao;
            }
        }

        public ContaCorrente this[int indice] // criando um indexador
        {
            get
            {
                return RecuperarContaNoIndice(indice);
            }
        }
    }
}
