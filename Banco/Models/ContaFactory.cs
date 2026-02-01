using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    public static class ContaFactory
    {
        public static ContaBancaria CriarConta(int opcao, Pessoa titular)
        {
            switch (opcao)
            {
                case 1:
                    return new ContaCorrente(titular);
                case 2:
                    return new ContaPoupanca(titular);
                default:
                    
                    throw new ArgumentException("Tipo de conta inválido.");
            }
        }
    }
}
