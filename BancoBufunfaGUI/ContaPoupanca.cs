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
            Console.Write("Insira o nome do titular da conta: ");
            this.SetTitular(Console.ReadLine());
            Console.Write("Insira o cpf do titular da conta (ex: 000.000.000-00): ");
            this.SetCpf(Console.ReadLine());
            Console.Write("Insira a senha da conta: ");
            this.SetSenha(Console.ReadLine());
            Console.WriteLine($"A sua senha vai ser: {this.GetSenha()}");

            numero = random.Next(1, 999999999);
            this.SetNumeroConta(numero);
        }

        //Override para saque poupança
        public override bool SetSaldoSaque(double value)
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
