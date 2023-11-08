using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_POO.Funcionarios
{
    public class FuncionarioOperacional : Funcionario
    {
        public FuncionarioOperacional(string cpf, double salarioBase) :base(cpf, salarioBase)
        {

        }

        public override void AumentaSalario()
        {
            Salario *= 0.05;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
