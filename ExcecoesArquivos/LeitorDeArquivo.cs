using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcecoesArquivos
{
    public class LeitorDeArquivo : IDisposable
    {
        public string Arquivo { get; set; }

        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;
            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }
        public string Fechar()
        {
            return "Fechando Arquivo";
        }
        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");
            throw new IOException();
            return "Linha do Arquivo";
        }
        public string LerProximaLinhaUsing() // Utilizando no contexto using - neste não precisa lançar a excecao
        {
            Console.WriteLine("Lendo linha...");
            return "Linha do Arquivo";
        }
        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo"); // é invocado após a verificação de referência nula.
        }
    }
}
