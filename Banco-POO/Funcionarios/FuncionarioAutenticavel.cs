using Banco_POO.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_POO.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, Autenticavel
    {
        public string Senha { get; set; }
        public FuncionarioAutenticavel(string cpf, double salario) :base(cpf, salario)
        {

        }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
