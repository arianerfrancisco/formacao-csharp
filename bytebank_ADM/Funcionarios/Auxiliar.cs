using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {
        }
        public override double getBonificacao()
        {
            return Salario * 0.2;
        }
        public override void AumentarSalario() // void: permite que este metodo seja reescrito pela classe filha.
        {
            this.Salario *= 1.1;
        }
    }
    
}
