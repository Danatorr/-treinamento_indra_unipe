using System;

namespace BancoBufunfaGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            TODO:

            Saque Conta Corrente - V
            Saque - V
            Deposito - V
            CPMF - V
            Rendimentos Poupança - V
            Cadastro número conta - V
            Cliente - 

            */

            ContaCorrente contaCorrente1 = new ContaCorrente(0);
            ContaPoupanca contaPoupanca1 = new ContaPoupanca(0);

            /*
            Console.Write("Insira o nome do titular da conta corrente: ");
            contaCorrente1.SetTitular(Console.ReadLine());
            Console.WriteLine(contaCorrente1.GetTitular());
            Console.Write("Insira o cpf do titular da conta corrente (ex: 000.000.000-00): ");
            contaCorrente1.SetCpf(Console.ReadLine());
            Console.WriteLine(contaCorrente1.GetCpf());
            Console.Write("Insira a profissão do titular da conta corrente: ");
            contaCorrente1.SetProfissao(Console.ReadLine());
            Console.WriteLine(contaCorrente1.GetProfissao());


            Console.Write("Insira o nome do titular da conta corrente: ");
            contaCorrente1.SetTitular(Console.ReadLine());
            Console.WriteLine(contaCorrente1.GetTitular());
            Console.Write("Insira o cpf do titular da conta corrente (ex: 000.000.000-00): ");
            contaCorrente1.SetCpf(Console.ReadLine());
            Console.WriteLine(contaCorrente1.GetCpf());
            Console.Write("Insira a profissão do titular da conta corrente: ");
            contaCorrente1.SetProfissao(Console.ReadLine());
            Console.WriteLine(contaCorrente1.GetProfissao());
            */

            contaPoupanca1.SetSaldoDeposito(100);
            Console.WriteLine($"O rendimento da poupança deste mês foi de: {contaPoupanca1.GetRendimento()}");

            Console.WriteLine($"O número da conta é: {contaCorrente1.GetNumeroConta()}");
            Console.WriteLine($"O número da conta é: {contaPoupanca1.GetNumeroConta()}");

            Console.WriteLine("Digite um valor para o depósito: ");
            double value = Convert.ToDouble(Console.ReadLine());
            contaCorrente1.SetSaldoDeposito(value);

            Console.WriteLine($"O novo saldo da conta é: R$ {contaCorrente1.GetSaldo()}");

            Console.WriteLine("Digite um valor para o saque: ");
            value = Convert.ToDouble(Console.ReadLine());
            contaCorrente1.SetSaldoSaque(value);
            Console.WriteLine($"O valor da CPMF foi de: R$ {(value * 0.038):N2}");

            Console.WriteLine($"O novo saldo da conta é:  {contaCorrente1.GetSaldo():C}");
        }
    }
}
