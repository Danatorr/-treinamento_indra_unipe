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

        public ContaCorrente()
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
            Console.WriteLine($"O número da sua conta vai ser: {numero}, guarde este número para poder fazer as operações no futuro.");
        }

        //Override para saque conta corrente
        public override bool SetSaldoSaque(double value)
        {
            if (this.saldo < value * 1.038)
                return false;

            this.saldo -=  value + (value * 0.038);
            return true;
        }
    }
}
