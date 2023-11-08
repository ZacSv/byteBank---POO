using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco_POO;

namespace Banco_POO
{
    internal class ContaCorrente
    {
        private Cliente _Titular;
        public Cliente titular
        {
            get { return _Titular; }
            set { _Titular = value; }
        }
        public int NumeroAgencia { get; set; }

        public int NumeroConta { get; set; }

        private double _Saldo;
        public double Saldo
        {
            get
            {
                return _Saldo;
            }
            set 
            { 
             if(value < 0)
                {
                    return;
                }
                _Saldo = value;
            } 
        }

        public static int quantidadeContas { get; set; }

        public void SacaDinheiro(double Valor)
        {
               if(Valor <= this._Saldo)
               {
                this._Saldo -= Valor;
               
               }
            else
            {
                Console.WriteLine("O valor que deseja sacar é menor que o saldo de sua conta, seu saldo atual é: " + _Saldo);
            }       
        }

        public void Deposita(double Valor)
        {
            if (Valor > 0)
            {
                this._Saldo += Valor;
                Console.WriteLine("Deposito efetuado. Saldo atual: " + this._Saldo);
            }
            else
            {
                Console.WriteLine("Você está tentando depositar um valor negativo");
            }
        }

        public void FazOPix(double valor, ContaCorrente contaDestino)
        {
            if(valor <= this._Saldo)
            {
                contaDestino._Saldo += valor;
                Console.WriteLine("Tranferência efetuada com sucesso");
            }
            else
            {
                Console.WriteLine("Você está tentando transferir um valor maior do que o possuido, seu saldo atual é: " + this._Saldo);
            }
        }
        public ContaCorrente(int agencia, int numeroConta)
        {
            this.NumeroAgencia = agencia;
            this.NumeroConta = numeroConta;
            quantidadeContas++;
        }
    }
}    