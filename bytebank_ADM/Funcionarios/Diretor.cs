﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor:Funcionario
    {
        public Diretor(string cpf) : base(cpf,5000) // base(cpf)> invocar o construtor da classe base
        {
        }
        public override double getBonificacao()
        {
            return Salario * 0.5;
        }
        public override void AumentarSalario() // void: permite que este metodo seja reescrito pela classe filha.
        {
            this.Salario *= 1.5;
        }
    }
}
