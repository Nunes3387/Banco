using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class ContaBancaria : IContaBancaria
    {
        private decimal saldo;
        private int numero;

        public ContaBancaria(int numero)
        {
            this.numero = numero;
            this.saldo = 0;
        }

        public void Depositar(decimal valor)
        {
            saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
            }
            else
            {
                throw new Exception("Saldo insuficiente");
            }
        }

        public decimal ConsultarSaldo()
        {
            return saldo;
        }
    }
}
