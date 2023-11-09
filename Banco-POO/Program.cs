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

            int a = 10;
            int b = 0;
            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
           
            Console.ReadKey();

        }
    }   
}
