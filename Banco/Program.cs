using Banco.Models;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BEM-VINDO AO SISTEMA BANCÁRIO ===");
            Console.WriteLine("Qual o seu nome?: ");
            string nomePessoa = Console.ReadLine();

            Console.WriteLine("Qual sua idade?: ");
            int idadePessoa = int.Parse(Console.ReadLine());


            Pessoa pessoa = new Pessoa(nomePessoa, idadePessoa);

            Console.WriteLine("\nQual tipo de conta deseja abrir? (1-Corrente / 2-Poupança)");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("Depósito obrigatório para criação da conta corrente: ");
            }

            double depositoInicial = double.Parse(Console.ReadLine()); 

            try
            {
                ContaBancaria conta = ContaFactory.CriarConta(opcao, pessoa);

                Console.WriteLine($"\nSucesso! Conta {conta.NumeroConta} criada.");

                conta.Deposito(100);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na criação: {ex.Message}");
            }




        }
    }
}
