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

        public virtual void Sacar(double valor)
        {

            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"\nSaque realizado com sucesso! Seu saldo atual = {Saldo}");
            }
            else
            {
                Console.WriteLine($"\nSaldo insuficiente! Seu saldo atual = {Saldo}");
            }
        }

        public void Depositar(double valor)
        {
            if(valor >= 0)
            {
                Saldo += valor;
                Console.WriteLine($"\nDepósito realizado com sucesso! Seu saldo atual = {Saldo}");
            }
            else
            {
                Console.WriteLine($"\nOperação inválida!");
            }
        }
    }
}
