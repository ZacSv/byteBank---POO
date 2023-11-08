using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco_POO.Funcionarios;

namespace Banco_POO
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        public void RegistraBonificacao(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }
    }
}
