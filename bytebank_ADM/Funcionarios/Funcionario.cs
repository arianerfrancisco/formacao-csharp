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
        public string Cpf { get; private set; } // private set: bloqueia a alteracao deste valor
        public double Salario { get; protected set; } // protected: apenas as classes filhas podem alterar este valor
        public static int totalFuncionarios { get; private set; }
        // static: torna uma propriedade da classe e não dos objetos instanciados nela.
        // private set: bloqueia inserções de valores nesta propriedade
        public virtual double getBonificacao()
        {
              return  Salario * 0.1;
        }
        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            totalFuncionarios++;
        }

        public virtual void AumentarSalario() // void: permite que este metodo seja reescrito pela classe filha.
        {
            this.Salario *=  1.1 ;
        }
    }
}
