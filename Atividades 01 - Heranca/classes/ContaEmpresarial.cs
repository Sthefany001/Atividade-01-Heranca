using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades_01___Heranca.classes
{
    internal class ContaEmpresarial : Conta
    {
        public double Anuidade { get; set; }
        public double LimiteEmprestimo { get; set; }
        public double TotalEmprestimo { get; set; }

        public ContaEmpresarial() { }

        public ContaEmpresarial
        (double anuidade, double limiteEmprestimo, double totalEmprestimo,int nconta, string agencia, string titular, double saldo)
        :base(nconta, agencia, titular, saldo)
        {
            Anuidade = anuidade;
            LimiteEmprestimo = limiteEmprestimo;
            TotalEmprestimo = totalEmprestimo;
        }

        public void FazerEmprestimo(double valor)
        {
            if(valor <= LimiteEmprestimo - TotalEmprestimo)
            {
                Saldo += valor;
                TotalEmprestimo += valor;


                Console.WriteLine($"\nEmpréstimo realizado com sucesso! Seu saldo atual = {Saldo}");
            }
            else
            {
                Console.WriteLine($"\nO valor de empréstimo não pode ser concedido! Seu saldo atual = {Saldo}");
            }

        }

        public override void Sacar(double valor)
        {
        
            if (Saldo >= valor)
            {
               
                if(valor >= 5000)
                {
                    double taxa = 5;
                    Anuidade += taxa;

                    Saldo -= valor;
                    Saldo -= Anuidade;
                    Console.WriteLine($"\nSaque realizado com sucesso! Seu saldo atual = {Saldo}");
                }
                else
                {
                    Saldo -= valor;
                    Console.WriteLine($"\nSaque realizado com sucesso! Seu saldo atual = {Saldo}");
                }
                             
            }
            else
            {
                Console.WriteLine($"\nSaldo insuficiente! Seu saldo atual = {Saldo}");
            }


        }
    }
}
