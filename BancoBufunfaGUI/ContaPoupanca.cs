using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBufunfaGUI
{
    class ContaPoupanca
    {
<<<<<<< Updated upstream
=======
        private double rendimento;
        Random randomId = new Random();
        
        //Construtor Conta Poupanca
        public ContaPoupanca(int numero)
        {
            Console.WriteLine("Gerando o número da conta... ");
            numero = randomId.Next(1, 999999999);
            this.SetNumeroConta(numero);
        }

        //Juros compostos de 0.02% ao mês
        public double GetRendimento()
        {
            rendimento = this.GetSaldo() * 0.002;
            return rendimento;
        }
>>>>>>> Stashed changes
    }
}
