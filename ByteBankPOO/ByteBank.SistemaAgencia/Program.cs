using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenteDeConta Isac = new GerenteDeConta("123456789");
            Isac.Senha = "123";
            Isac.Autenticar("123");
            Console.ReadKey();
        }
    }
}
