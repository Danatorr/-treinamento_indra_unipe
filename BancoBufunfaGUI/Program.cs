using System;

namespace BancoBufunfaGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            TODO:

            Saque - V
            Deposito - V
            CPMF - V
            Rendimentos Poupança
            Cadastro número conta - V

            */

            ContaCorrente contaCorrente1 = new ContaCorrente();
            ContaPoupanca contaPoupanca1 = new ContaPoupanca();

            contaPoupanca1.SetSaldoDeposito(100);
            Console.WriteLine(contaPoupanca1.GetRendimento());

            Console.WriteLine($"O número da conta é: {contaCorrente1.GetNumeroConta()}");
            Console.WriteLine($"O número da conta é: {contaPoupanca1.GetNumeroConta()}");

            Console.WriteLine("Digite um valor para o depósito: ");
            double value = Convert.ToDouble(Console.ReadLine());
            contaCorrente1.SetSaldoDeposito(value);

            Console.WriteLine($"O novo saldo da conta é: R${contaCorrente1.GetSaldo()}");

            Console.WriteLine("Digite um valor para o saque: ");
            value = Convert.ToDouble(Console.ReadLine());
            contaCorrente1.SetSaldoSaque(value);
            Console.WriteLine($"O valor da CPMF foi de: R$ {value * 0.038}");

            Console.WriteLine($"O novo saldo da conta é: R$ {contaCorrente1.GetSaldo()}");
        }
    }
}
