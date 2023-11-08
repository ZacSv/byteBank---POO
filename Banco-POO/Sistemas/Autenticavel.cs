using Banco_POO.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_POO.Sistemas
{
    public interface Autenticavel
    {
        bool Autenticar(string senha);
    }
}
