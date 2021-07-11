using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBufunfaGUI
{
    public class ContaCorrente : Conta
    {

        Random random = new Random();

        public ContaCorrente(int numero)
        {
            numero = random.Next(1, 999999999);
            this.SetNumeroConta(numero);
        }

        public bool SetSaldoSaqueContaCorrente(double value)
        {
            if (this.saldo < value * 1.038)
                return false;

            this.saldo -=  value + (value * 0.038);
            return true;
        }
    }
}
