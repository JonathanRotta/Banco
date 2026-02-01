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

            Console.WriteLine("\nQual tipo de conta deseja abrir?");
            Console.WriteLine("1 - Conta Corrente (com taxa de saque)");
            Console.WriteLine("2 - Conta Poupança (sem taxas)");
            Console.Write("Opção: ");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                ContaCorrente contaPessoa = new ContaCorrente(pessoa);
            }


            Console.WriteLine("Faça seu primeiro depósito: ");

            int valorDepositado = int.Parse(Console.ReadLine());

           

            Console.WriteLine("O saldo da sua conta agora é: " + conta.Saldo);

       

           


            

        }
    }
}
