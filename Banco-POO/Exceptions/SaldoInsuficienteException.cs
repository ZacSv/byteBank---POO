using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_POO.Exceptions
{
    public class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException() //Opção de construtor sem nenhum argumento
        {

        }

        public SaldoInsuficienteException(double saldo, double valorSaque) //Construtor que recebe parâmetro de mensagem como argumento
            : this($"Tentativa de saque de um valor de R${valorSaque} em uma conta com saldo de R${saldo}") 
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        public SaldoInsuficienteException(string mensagem) :base(mensagem) //Construtor que recebe parâmetro de mensagem como argumento
        {
                
        }
    }
}
