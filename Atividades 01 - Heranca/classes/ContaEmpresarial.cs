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

        public void FazerEmprestimo()
        {
            Console.Write("\nDigite o valor do emprestimo: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            if(valor <= LimiteEmprestimo)
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

        public override void Sacar()
        {
            Console.Write($"\nDigite o valor do saque: ");
            double saque = Convert.ToDouble(Console.ReadLine());
        
            if (Saldo <= saque)
            {
                Saldo -= saque;
               
                if (saque >= 5.000)
                {
                    double taxa = 5.00;
                    Anuidade += taxa;

                    Saldo -= Anuidade;
                    Console.WriteLine($"\nSaque realizado com sucesso! Seu saldo atual = {Saldo}");
                }

                Console.WriteLine($"\nSaque realizado com sucesso! Seu saldo atual = {Saldo}");
            }
            else
            {
                Console.WriteLine($"\nSaldo insuficiente! Seu saldo atual = {Saldo}");
            }


        }
    }
}
