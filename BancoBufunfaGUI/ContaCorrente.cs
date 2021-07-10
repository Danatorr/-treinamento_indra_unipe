using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBufunfaGUI
{
    class ContaCorrente
    {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        private double saldo = 10;
        public int numeroConta;

        public double GetSaldo()
        {
            return saldo;
        }

        public void SetSaldoDeposito(double value)
        {
            this.saldo += value;
        }

        public bool SetSaldoSaque(double value)
=======
        Random randomId = new Random();
        //Construtor Conta Corrente
        public ContaCorrente(int numero)
>>>>>>> Stashed changes
        {
            Console.WriteLine("Gerando o número da conta...  ");
            numero = randomId.Next(1, 999999999);
            this.SetNumeroConta(numero);
        }

        public int GetNumeroConta()
        {
            return this.numeroConta;
=======
        Random randomId = new Random();
        //Construtor Conta Corrente
        public ContaCorrente(int numero)
        {
            Console.WriteLine("Gerando o número da conta...  ");
            numero = randomId.Next(1, 999999999);
            this.SetNumeroConta(numero);
>>>>>>> Stashed changes
        }
    }
}
