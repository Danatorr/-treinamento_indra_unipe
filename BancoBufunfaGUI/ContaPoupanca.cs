using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBufunfaGUI
{
    public class ContaPoupanca : Conta
    {
        private double rendimento;

        Random random = new Random();

        public ContaPoupanca(int numero)
        {
            numero = random.Next(1, 999999999);
            this.SetNumeroConta(numero);
        }

        public bool SetSaldoSaquePoupanca(double value)
        {
            if (this.saldo < value)
                return false;

            this.saldo -= value;
            return true;
        }

        //Juros compostos de 0.02% ao mês
        public double GetRendimento()
        {
            rendimento = this.saldo * 0.002;
            return rendimento;
        }
    }
}
