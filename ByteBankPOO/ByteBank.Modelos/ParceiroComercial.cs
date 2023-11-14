using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class ParceiroComercial : IAutenticavel
    {
        private HelperAutenticacao _Autentica = new HelperAutenticacao();
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return _Autentica.CompararSenhas(this.Senha, senha);
        }
    }
}