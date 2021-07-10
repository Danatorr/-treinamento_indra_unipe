using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBufunfaGUI
{
    public class Conta
    {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
        private double saldo = 10;
>>>>>>> Stashed changes
=======
        private double saldo = 10;
>>>>>>> Stashed changes
=======
        private double saldo = 10;
>>>>>>> Stashed changes
        public int numeroConta;

        public void SetNumeroConta(int numero)
        {
            this.numeroConta = numero;
        }
<<<<<<< Updated upstream
=======

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

        public bool SetSaldoSaquePoupanca(double value)
        {
            if (this.GetSaldo() < value)
                return false;

            this.saldo -= value;
            return true;
        }
        public bool SetSaldoSaqueContaCorrente(double value)
        {
            if (this.saldo < value * 1.038)
                return false;

            this.saldo -= value + (value * 0.038);
            return true;
        }
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    }
}
