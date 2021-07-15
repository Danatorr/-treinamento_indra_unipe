using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBufunfaGUI
{
    public class Conta : Cliente
    {
        Conta[] contas = { };
        protected double saldo = 10;
        public int numeroConta;
        public int numero;
        public string codigo;
        private double value;

        //TODO
        public void CriarConta()
        {
            Conta conta = new Conta();

            //Array append para cada conta nova
        }

        public void Inicializar()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("|        Banco Bufunfa       |");
            Console.WriteLine("==============================");
            Console.WriteLine("");
            Console.WriteLine("Insira o código da operação que deseja realizar: \n\n");
            Console.WriteLine("[1] Depósito\n[2] Saque\n[3] Transferência\n[4] Criar conta\n[5] Checar conta\n[6] Atualizar conta\n[7] Deletar conta");
            codigo = Console.ReadLine();

            //TODO
            switch (codigo)
            {
                case "1":
                    Console.Write("Insira o valor do depósito: R$");
                    value = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Insira o número da conta para depósito: ");
                    = (Console.ReadLine()); //Precisa pegar do usuário o número da conta para depositar

                    SetSaldoDeposito(value, /*precisa de um número de conta*/);
                    break;
                case "2":

                    break;
            }
        }

        public void SetNumeroConta(int numero)
        {
            this.numeroConta = numero;
        }

        public int GetNumeroConta()
        {
            return this.numeroConta;
        }

        public double GetSaldo()
        {
            return saldo;
        }

        public void SetSaldoDeposito(double value, Conta conta)
        {
            this.saldo += value;
        }

        //Virtual possibilita o override para as outras classes
        public virtual bool SetSaldoSaque(double value)
        {
            if (this.saldo < value)
                return false;

            this.saldo -= value;
            return true;
        }

        public bool Transferir(double value, Conta conta)
        {
            if (value > this.saldo)
            {
                Console.WriteLine("A transferência falhou, cheque seu saldo e tente novamente!");
                return false;
            }
            this.SetSaldoSaque(value);
            conta.SetSaldoDeposito(value, conta);
            Console.WriteLine($"Transferência de {value} para {conta.GetTitular()} feita com sucesso!");
            return true;
        }
    }
}
