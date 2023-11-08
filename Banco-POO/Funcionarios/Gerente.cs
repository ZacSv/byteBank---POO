using Banco_POO.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_POO.Funcionarios
{
    internal class Gerente : FuncionarioAutenticavel
    {
        public Gerente(string cpf, double salarioBase) : base(cpf, salarioBase)
        {

        }
        public override double GetBonificacao()
        {
            return 
                Salario * 0.5;
        }

        public override void AumentaSalario()
        {
             Salario *= 0.2;
        }
    }
}
