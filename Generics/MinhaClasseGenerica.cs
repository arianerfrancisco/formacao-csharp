using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MinhaClasseGenerica<T>
    {
        public T PropriedadeGenerica { get; set; }
        public void ExibirDados(T t)
        {
            Console.WriteLine($"Dado Informado = {t.ToString()}");
            Console.WriteLine($"Tipo = {t.GetType()}");
        }
    }
}
