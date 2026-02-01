using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    internal class ContaPoupanca : ContaBancaria
    {

        public ContaPoupanca(Pessoa titular) : base( titular)
        {
        }


        public override void Deposito(double valor)
        {
            base.Deposito(valor);
        }
    }
}
