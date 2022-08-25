using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {
            Console.WriteLine("Criando um gerente de contas");
        }

        public override double getBonificacao()
        {
            return Salario * 0.25;
        }
        public override void AumentarSalario() // void: permite que este metodo seja reescrito pela classe filha.
        {
            this.Salario *= 1.05;
        }
    }
}
