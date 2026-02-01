using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(Pessoa titular) : base( titular)
        {

        }

        public override void Saque(double valor)
        {
            double taxa = 0.50;
            Saldo = Saldo - (valor + taxa);

            Console.WriteLine($"Saque de {valor:C2} realizado com taxa de {taxa:C2}.");


        }

        public override void Deposito(double saldo)
        {
            base.Deposito(saldo);
        }
    }
}
