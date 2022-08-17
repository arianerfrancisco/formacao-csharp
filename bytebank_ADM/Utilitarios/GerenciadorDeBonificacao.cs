using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Utilitarios
{
    public class GerenciadorDeBonificacao
    {
        private double _totalBonificacao { get; set; }

        public void Registrar(Funcionario funcionario)
        {
            this._totalBonificacao += funcionario.getBonificacao();
        }

        public double GetBonificacao()
        {
           return this._totalBonificacao;
        }
    }
}
