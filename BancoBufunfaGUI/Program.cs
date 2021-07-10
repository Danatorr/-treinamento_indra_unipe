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

<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            ContaCorrente conta1 = new ContaCorrente();

            Console.WriteLine($"O número da conta é: {conta1.GetNumeroConta()}");
=======
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
            ContaCorrente contaCorrente1 = new ContaCorrente(0);
            ContaPoupanca contaPoupanca1 = new ContaPoupanca(0);

            contaPoupanca1.SetSaldoDeposito(100);
            Console.WriteLine($"O rendimento deste mês foi: {contaPoupanca1.GetRendimento()}");
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes

            Console.WriteLine(conta1.GetSaldo());

            Console.WriteLine("Digite um valor para o depósito: ");
            double value = Convert.ToDouble(Console.ReadLine());
            conta1.SetSaldoDeposito(value);

            Console.WriteLine($"O novo saldo da conta é: R${conta1.GetSaldo()}");

            Console.WriteLine("Digite um valor para o saque: ");
            value = Convert.ToDouble(Console.ReadLine());
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            conta1.SetSaldoSaque(value);
=======
            contaCorrente1.SetSaldoSaqueContaCorrente(value);
>>>>>>> Stashed changes
=======
            contaCorrente1.SetSaldoSaqueContaCorrente(value);
>>>>>>> Stashed changes
=======
            contaCorrente1.SetSaldoSaqueContaCorrente(value);
>>>>>>> Stashed changes
            Console.WriteLine($"O valor da CPMF foi de: R$ {value * 0.038}");

            Console.WriteLine($"O novo saldo da conta é: R$ {conta1.GetSaldo()}");
        }
    }
}
