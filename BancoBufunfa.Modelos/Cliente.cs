using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBufunfaGUI
{
    public class Cliente
    {
        string titular;
        string cpf;
        string senha;

        public Cliente()
        {
            Console.Write("Insira o nome do titular da conta: ");
            this.setTitular(Console.ReadLine());
            Console.Write("Insira o cpf do titular da conta (ex: 000.000.000-00): ");
            this.setCpf(Console.ReadLine());
            Console.Write("Insira a senha da conta: ");
            this.SetSenha(Console.ReadLine());
            Console.WriteLine($"A senha da conta vai ser: {this.getSenha()}");
        }

        public void setTitular(string nome)
        {
            titular = nome;
        }

        public string getTitular()
        {
            return titular;
        }

        public void setCpf(string numeroCpf)
        {
            cpf = numeroCpf;
        }

        public string GetCpf()
        {
            return cpf;
        }

        public void SetSenha(string Senha)
        {
            senha = Senha;
        }

        public string getSenha()
        {
            return senha;
        }
    }
}
