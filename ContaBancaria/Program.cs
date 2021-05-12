using System;
using System.Globalization;
namespace ContaBancaria
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Conta conta;
            Console.Write("Entre com o número da conta: (ex 0000)");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o Titular da Conta: ");
            string titularConta = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n) ? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com valor de deposito inicial: $");
                double saldoConta = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero, titularConta, saldoConta);
            }
            else
            {
                conta = new Conta(numero, titularConta);
            }

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com valor do deposito: $ ");
            double Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(Valor);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Seu Saldo em conta é de: $ " + conta.SaldoConta.ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("Entre com valor que deseja sacar: $ ");
            Valor = double.Parse(Console.ReadLine());
            conta.Sacar(Valor);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();
            
         

            
        }
    }
}
