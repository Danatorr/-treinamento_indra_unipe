using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBufunfaGUI
{
    public class Inicio : Conta
    {
        //Inicializando o programa
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
    }
}
