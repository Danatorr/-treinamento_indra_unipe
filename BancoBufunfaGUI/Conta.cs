using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBufunfaGUI
{
    public class Conta : Cliente
    {
        protected double saldo = 10;
        public int numeroConta;
        public int numero;


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

        public void SetSaldoDeposito(double value)
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
            conta.SetSaldoDeposito(value);
            Console.WriteLine($"Transferência de {value} para {conta.GetTitular()} feita com sucesso!");
            return true;
        }
    }
}
