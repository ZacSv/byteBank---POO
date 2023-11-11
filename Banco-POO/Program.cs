using Banco_POO.Funcionarios;
using Banco_POO.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente A = new ContaCorrente(123, 123);
            ContaCorrente Isac = new ContaCorrente(123, 123);
            Isac.Deposita(100);

            Isac.SacaDinheiro(10); 
            Console.ReadKey();
        }
    }   
}
