using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        private int _tipo;     
        public string Cpf { get; set; }
        public double Salario { get; set; }
        public virtual double getBonificacao()
        {
              return _tipo == 1 ? Salario: Salario * 0.1;
        }
    }
}
