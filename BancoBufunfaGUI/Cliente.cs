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


        protected void SetTitular(string nome)
        {
            titular = nome;
        }

        protected string GetTitular()
        {
            return titular;
        }

        protected void SetCpf(string numeroCpf)
        {
            cpf = numeroCpf;
        }

        protected string GetCpf()
        {
            return cpf;
        }

        protected void SetSenha(string _senha)
        {
            senha = _senha;
        }

        protected string GetSenha()
        {
            return this.senha;
        }
    }
}
