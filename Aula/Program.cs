using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número da Conta: ");
            int NumConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o Titular da Conta: ");
            string Nome = Console.ReadLine();
            Console.Write("Hávera deposito inicial (S/N)? ");
            char S = char.Parse(Console.ReadLine().ToUpper());

            if ('N' != S )
            {
                Console.Write("Entre com o Valor a ser Depositado: ");
            }
            else
            {
                Console.WriteLine("Sem valor para Deposito");
            }
            
            double Deposito = double.Parse(Console.ReadLine().ToString());
            Console.WriteLine();


            Colossos p = new Colossos(Nome, NumConta, Deposito);
            Console.WriteLine("Dados da Conta: ");
            Console.Write(p);

        }
    }
}
