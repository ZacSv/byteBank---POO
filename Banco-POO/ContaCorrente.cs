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
        public static double TaxaParaOperacao { get; private set; }
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


        public double DescontaTaxa(double valorOperacao)
        {
            return (valorOperacao * TaxaParaOperacao) / 100; //Encontra o valor da taxa baseado no valor da operação;
        }

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
                this._Saldo = this._Saldo - DescontaTaxa(valor) - valor; //Calculando o valor que restará na conta
                Console.WriteLine($"Tranferência efetuada com sucesso ! Seu saldo atual é {this._Saldo}");
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
            TaxaParaOperacao = 20 / quantidadeContas; //A taxa é regressiva, quanto mais contas menor a taxa
        }
    }
}    