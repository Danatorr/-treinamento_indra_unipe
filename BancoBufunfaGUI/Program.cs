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

            ContaCorrente conta1 = new ContaCorrente();

            Console.WriteLine($"O número da conta é: {conta1.GetNumeroConta()}");

            Console.WriteLine(conta1.GetSaldo());

            Console.WriteLine("Digite um valor para o depósito: ");
            double value = Convert.ToDouble(Console.ReadLine());
            conta1.SetSaldoDeposito(value);

            Console.WriteLine($"O novo saldo da conta é: R${conta1.GetSaldo()}");

            Console.WriteLine("Digite um valor para o saque: ");
            value = Convert.ToDouble(Console.ReadLine());
            conta1.SetSaldoSaque(value);
            Console.WriteLine($"O valor da CPMF foi de: R$ {value * 0.038}");

            Console.WriteLine($"O novo saldo da conta é: R$ {conta1.GetSaldo()}");
        }
    }
}
