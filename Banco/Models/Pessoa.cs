using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Banco.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Carteira { get; set; }


        public Pessoa(string Nome, int Idade)
        {
            this.Nome = Nome;
            this.Idade = Idade;
        }


    }
}
