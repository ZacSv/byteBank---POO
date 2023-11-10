using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco_POO;
using Banco_POO.Exceptions;

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
        public int NumeroAgencia { get; }
        public int NumeroConta{ get; }
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
        public static int quantidadeContas { get; private set; }


        public double DescontaTaxa(double valorOperacao)
        {
            return (valorOperacao * TaxaParaOperacao) / 100; //Encontra o valor da taxa baseado no valor da operação;
        }

        public void SacaDinheiro(double ValorSaque)
        {
            try
            {
                if (ValorSaque > this._Saldo)
                {
                    throw new SaldoInsuficienteException($"Saldo insuficiente para a operação, saldo atual de: {this._Saldo}");
                }
                if(ValorSaque <= 0)
                {
                    throw new ArgumentException($"Você está tentando sacar um valor inválido.", nameof(ValorSaque));
                }
                else
                {
                    this.Saldo -= ValorSaque;
                    Console.WriteLine($"Saque efetuado com sucesso, saldo restante: {this._Saldo}");
                }
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
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

        public void FazOPix(double valorTransferencia, ContaCorrente contaDestino)
        {
            try
            {
                if (valorTransferencia < 0)
                {
                    throw new ArgumentException("Valor inválido para a tranferência", nameof(valorTransferencia));
                }


                SacaDinheiro(valorTransferencia);
                contaDestino.Deposita(valorTransferencia);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
  
        }
        
        public ContaCorrente(int numeroAgencia, int numeroConta)
        {

            if(numeroAgencia <= 0)
            {
                throw new ArgumentException("O numero da agencia deve ser maior e diferente de zero", nameof(numeroAgencia));
            }
            if(numeroConta <= 0)
            {
                throw new ArgumentException("O numero da conta do cliente deve ser maior e diferente de zero", nameof(numeroConta));
            }

            NumeroAgencia = numeroAgencia;
            NumeroConta = numeroConta;
            quantidadeContas++;
            TaxaParaOperacao = 20 / quantidadeContas; //A taxa é regressiva, quanto mais contas menor a taxa
        }
    }
}    