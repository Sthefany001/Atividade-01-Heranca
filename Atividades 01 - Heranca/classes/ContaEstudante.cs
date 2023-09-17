using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades_01___Heranca.classes
{
    internal class ContaEstudante : Conta
    {

        public double LimiteChequeEspecial { get; set; }
        public string Cpf { get; set; }
        public string NomeInstituicao { get; set; }

        public ContaEstudante() { }

        public ContaEstudante
        (double limiteChequeEspecial, string cpf, string nomeInstituicao, int nconta, string agencia, string titular, double saldo)
        :base(nconta, agencia, titular, saldo)
        {
            LimiteChequeEspecial = limiteChequeEspecial;
            Cpf = cpf;
            NomeInstituicao = nomeInstituicao;
        }

        public override void Sacar(double valor)
        {
            double soma = Saldo + LimiteChequeEspecial;

            if(valor <= soma)
            {
                Saldo -= valor;
                Console.WriteLine($"\nSaque realizado com sucesso! Seu saldo atual = {Saldo}");
            }
            else
            {
                Console.WriteLine($"\nSaque não pode ser realizado! Seu saldo atual = {Saldo}");
            }
        }
    }
}
