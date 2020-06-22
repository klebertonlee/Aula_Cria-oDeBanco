using System;
using System.Collections.Generic;
using System.Text;

namespace Aula
{
    class Colossos
    {
        private string Nome;
        public int NumConta;
        private double Deposito;


        public string nome
        {
            get { return Nome; }
            set { Nome = value; }
        }
        public int numConta
        {
            get { return NumConta; }
            set { NumConta = value; }
        }
        public double deposito
        {
            get { return Deposito; }
            set { Deposito = value; }
        }

        public Colossos(int numConta, string nome)
        {
            Nome = nome;
            NumConta = numConta;
            
        }

        public Colossos(int numConta, string nome, double deposito) : this (numConta, nome)
        {
            Deposito = deposito;
        }

       

        public void SomaDeposito(double quantia)
        {
             Deposito += quantia;
        }

        public void Saque(double quantia)
        {
            Deposito -= quantia + 5.0;
        }
       

        public override string ToString()
        {
            return "Conta: "
                + NumConta                
                + ", Titular: "
                + Nome                
                + ", Saldo: $ "
                + Deposito.ToString("F2");
        }
    }
}
