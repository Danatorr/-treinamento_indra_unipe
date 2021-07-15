﻿using System;

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
            Cliente - V
            Transferência entre contas - V

            */

            Console.WriteLine("==============================");
            Console.WriteLine("|        Banco Bufunfa       |");
            Console.WriteLine("==============================");
            Console.WriteLine("");
            Console.WriteLine("Insira o código da operação que deseja realizar: \n\n");
            Console.WriteLine("[1] Depósito\n[2] Saque\n[3] Transferência\n[4] Criar conta\n[5] Checar conta\n[6] Atualizar conta\n[7] Deletar conta");

            ContaCorrente contaCorrente1 = new ContaCorrente(0);
            ContaPoupanca contaPoupanca1 = new ContaPoupanca(0);

            contaPoupanca1.SetSaldoDeposito(100);
            Console.WriteLine($"O rendimento da poupança deste mês foi de: {contaPoupanca1.GetRendimento()}");

            Console.WriteLine($"O número da conta é: {contaCorrente1.GetNumeroConta()}");
            Console.WriteLine($"O número da conta é: {contaPoupanca1.GetNumeroConta()}");

            contaPoupanca1.Transferir(10, contaCorrente1);
            Console.WriteLine(contaPoupanca1.Transferir(10, contaCorrente1));

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