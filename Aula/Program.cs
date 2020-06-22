using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {

            Colossos conta;

            Console.Write("Entre com o número da Conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o Titular da Conta: ");
            string nome = Console.ReadLine();
            Console.Write("Hávera deposito inicial (S/N)? ");
            char resp = char.Parse(Console.ReadLine());
            Console.WriteLine();


            if (resp == 's' || resp == 'S' )
            {
                Console.Write("Entre com o Valor do Depósito: ");
                double depositoInicial = double.Parse(Console.ReadLine().ToString());
                conta = new Colossos(numConta, nome, depositoInicial);
                Console.WriteLine();
            }
            else
            {
                conta = new Colossos(numConta, nome);
            }


            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.Write(conta);
            Console.WriteLine();


            Console.WriteLine();
            Console.Write("Entre com o valor de Depósito: ");
            double quantia = double.Parse(Console.ReadLine().ToString());
            conta.SomaDeposito(quantia);
            Console.WriteLine("Dados da Conta Atualozados: ");
            Console.Write(conta);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Entre Um valor para Saque: ");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine(conta);
            
        }
    }
}
