using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades_01___Heranca.classes
{
    internal class Conta
    {
        public int Nconta { get; set; }
        public string Agencia { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta() { }

        public Conta(int nconta, string agencia, string titular, double saldo)
        {
            Nconta = nconta;
            Agencia = agencia;
            Titular = titular;
            Saldo = saldo;
        }

        public virtual void Sacar()
        {
            Console.Write($"\nDigite o valor do saque: ");
            double saque = Convert.ToDouble(Console.ReadLine());

            if (Saldo >= saque)
            {
                Saldo -= saque;
                Console.WriteLine($"\nSaque realizado com sucesso! Seu saldo atual = {Saldo}");
            }
            else
            {
                Console.WriteLine($"\nSaldo insuficiente! Seu saldo atual = {Saldo}");
            }
        }

        public void Depositar()
        {
            Console.Write($"\nDigite o valor que deseja depositar: ");
            double valorDeposito = Convert.ToDouble(Console.ReadLine());

            Saldo += valorDeposito;
            Console.WriteLine($"\nDepósito realizado com sucesso! Seu saldo atual = {Saldo}");
        }
    }
}
