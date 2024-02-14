using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.WriteLine("Entre o Número da Conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o Titular da Conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Deseja entrar com Saldo inicial? (S/N)");
            char resposta = char.Parse(Console.ReadLine().ToUpper());
            if (resposta == 'S')
            {
                Console.WriteLine("Digite o valor que deseja adicionar inicialmente: $");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numeroConta, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numeroConta, titular);
            }
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta);
            Console.Write("Entre o valor para o depósito: $");
            double deposito=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine($"Dados da Conta Atualizados: {conta}");
            Console.WriteLine();

            Console.Write("Entre o valor para o saque: $");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine($"Dados da Conta Atualizados: {conta}");


        }
        
    }
}