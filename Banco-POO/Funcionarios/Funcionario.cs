using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_POO.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected set; }

        public Funcionario(string cpf, double salarioBase)
        {
            this.Salario = salarioBase;
            this.CPF = cpf;
            TotalDeFuncionarios += TotalDeFuncionarios;
        }

        public abstract void AumentaSalario();
        public abstract double GetBonificacao();
      
    }
}
