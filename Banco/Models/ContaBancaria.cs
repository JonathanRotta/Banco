using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    public abstract class ContaBancaria
    {
        private static int contadorContas = 1000;
        public int NumeroConta {  get; set; }
        public double Saldo {  get; protected set; }

        public Pessoa Titular { get; set; }

        public ContaBancaria(Pessoa titular)
        {
            contadorContas++;

            NumeroConta = contadorContas;
            this.Titular = titular;

        }
        public virtual void Deposito(double saldo) { 
            Saldo += saldo;
        }
        public virtual  void Saque(double saldo)
        {
            Saldo -= saldo;
        }
    }
}
