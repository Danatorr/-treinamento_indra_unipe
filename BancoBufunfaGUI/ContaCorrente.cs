using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBufunfaGUI
{
    class ContaCorrente : Conta
    {
        public bool SetSaldoSaqueContaCorrente(double value)
        {
            if (saldo < value * 1.038)
                return false;

            this.saldo -=  value + (value * 0.038);
            return true;
        }
    }
}
