using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBufunfaGUI
{
    class Conta
    {
        private int saldo = 10;
        public int numeroConta;

        public Conta(int numero)
        {
            Console.WriteLine("Insira o número da conta: ");
            numero = Convert.ToInt32(Console.ReadLine());
            this.SetNumeroConta(numero);
        }

        public void SetNumeroConta(int numero)
        {
            this.numeroConta = numero;
        }

        public int GetNumeroConta()
        {
            return this.numeroConta;
        }

        public double GetSaldo()
        {
            return saldo;
        }

        public void SetSaldoDeposito(double value)
        {
            this.saldo += value;
        }
    }
}
