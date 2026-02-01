using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    internal class ContaPoupanca : ContaBancaria
    {

        public ContaPoupanca(int numeroConta, Pessoa titular) : base(numeroConta, titular)
        {
        }


        public override void Deposito(double valor)
        {

        }
    }
}
