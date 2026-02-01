using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public class ContaBancaria
    {
        public int NumeroConta {  get; set; }
        private int Saldo { get; set; }

        public Pessoa Titular { get; set; }

        public ContaBancaria(int numeroConta, Pessoa titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;

        }

        private void Deposito(int saldo) { 
            Saldo = saldo;
        }
        public void Saque(int saldo)
        {
            Saldo -= saldo;
            Saldo -= saldo;
        }
    }
}
