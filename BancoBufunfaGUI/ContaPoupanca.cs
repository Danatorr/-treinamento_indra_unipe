using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBufunfaGUI
{
    class ContaPoupanca : Conta
    {
        private double rendimento;

        public bool SetSaldoSaquePoupanca(double value)
        {
            if (this.saldo < value)
                return false

            this.saldo -= value;
            return true;
        }

        //Juros compostos de 0.02% ao mês
        public double GetRendimento()
        {
            rendimento = this.saldo * 0.002
        }
    }
}
