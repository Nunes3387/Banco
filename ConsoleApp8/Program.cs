using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria(1111);

            decimal n1, n2;

            Console.WriteLine("Digite o valor do Deposito:");
            n1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do Saque:");
            n2 = decimal.Parse(Console.ReadLine());

            conta.Depositar(n1);
            conta.Sacar(n2);
            decimal saldo = conta.ConsultarSaldo();
            Console.WriteLine("Saldo atual: " + saldo); 

            Console.ReadKey();

        }
    }
}
