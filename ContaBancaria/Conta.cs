using System;
using System.Globalization;

namespace ContaBancaria
{
    class Conta
    {
        public int NumeroConta { get; private set; }
        public string TitularConta { get; set; }
        public double SaldoConta { get; private set; }

        public Conta(int numeroConta, string titularConta)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
            
        } 
        
        public Conta(int numeroConta, string titularConta, double depositoInicial) : this (numeroConta, titularConta)
        {
            Depositar(depositoInicial);
        }
        
        public void Depositar(double valor)
        {
            SaldoConta += valor;
        }

        public void Sacar(double valor)
        {
            if (valor < SaldoConta)
            {
                SaldoConta -= valor;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("[NEGADO] Valor solicitado Maior que o Disponível!");
            }

        }
        public override string ToString()
        {
            return "Conta: " + NumeroConta + ", Titular: " + TitularConta + ", Saldo: $ " + SaldoConta.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
