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
        string profissao;

        public Cliente()
        {
            Console.Write("Insira o nome do titular da conta: ");
            this.SetTitular(Console.ReadLine());
            Console.WriteLine(this.GetTitular());
            Console.Write("Insira o cpf do titular da conta (ex: 000.000.000-00): ");
            this.SetCpf(Console.ReadLine());
            Console.WriteLine(this.GetCpf());
            Console.Write("Insira a senha da conta: ");
            this.SetProfissao(Console.ReadLine());
            Console.WriteLine(this.GetProfissao());
        }

        public void SetTitular(string nome)
        {
            titular = nome;
        }

        public string GetTitular()
        {
            return titular;
        }

        public void SetCpf(string numeroCpf)
        {
            cpf = numeroCpf;
        }

        public string GetCpf()
        {
            return cpf;
        }

        public void SetProfissao(string clienteProfissao)
        {
            cpf = clienteProfissao;
        }

        public string GetProfissao()
        {
            return profissao;
        }
    }
}
