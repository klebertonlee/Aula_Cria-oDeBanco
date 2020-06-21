using System;
using System.Collections.Generic;
using System.Text;

namespace Aula
{
    class Colossos
    {
        private string nome;
        private int numConta;
        private double deposito;

        public Colossos(string nome, int numConta, double deposito)
        {
            Nome = nome;
            NumConta = numConta;
            Deposito = deposito;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int NumConta
        {
            get { return numConta; }
            set { numConta = value; }
        }
        public double Deposito
        {
            get { return deposito; }
            set { deposito = value; }
        }

        


        public override string ToString()
        {
            return "Conta: "
                + numConta
                + ", "
                + "Titular: "
                + nome
                + ", "
                + "Saldo: $ "
                + deposito.ToString("F2");
        }
    }
}
