using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBufunfaGUI
{
    class ContaCorrente
    {
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
        {
            if (saldo < value * 1.038)
                return false;

            this.saldo -=  value + (value * 0.038);
            return true;
        }

        public int GetNumeroConta()
        {
            return this.numeroConta;
        }
    }
}
