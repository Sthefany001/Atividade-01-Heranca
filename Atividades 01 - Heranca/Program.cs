using Atividades_01___Heranca.classes;

public class Program
{
	static void Main(string[] args)
	{
        int opcao = 1;

        while (opcao != 0)
		{
            Console.WriteLine("\n0 - Fechar programa");
            Console.WriteLine("1 - Conta");
            Console.WriteLine("2 - Conta estudante");
            Console.WriteLine("3 - Conta empresarial");
            Console.Write("Opção escolhida: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                //Conta
                Conta a = new Conta();
                a.Nconta = 1;
                a.Agencia = "a";
                a.Titular = "Sthefany";
                a.Saldo = 1000;

                Console.Write("\nDigite o valor do saque: ");
                double saque = Convert.ToDouble(Console.ReadLine());
                a.Sacar(saque);

                Console.Write("\nDigite o valor do depósito: ");
                double deposito = Convert.ToDouble(Console.ReadLine());
                a.Depositar(deposito);
            }
            else if (opcao == 2)
            {
                //Conta Estudante
                ContaEstudante b = new ContaEstudante();
                b.LimiteChequeEspecial = 500;
                b.Cpf = "111.111.111-11";
                b.NomeInstituicao = "IFRO";
                b.Nconta = 2;
                b.Agencia = "b";
                b.Titular = "Natalia";
                b.Saldo = 100;

                Console.Write("\nDigite o valor do emprestimo: ");
                double emprestimo = Convert.ToDouble(Console.ReadLine());
                b.Sacar(emprestimo);
            }
            else if (opcao == 3)
            {
                //Conta Empresarial
                ContaEmpresarial c = new ContaEmpresarial();
                c.Anuidade = 0;
                c.LimiteEmprestimo = 10000;
                c.TotalEmprestimo = 100;
                c.Nconta = 3;
                c.Agencia = "c";
                c.Titular = "Paulo";
                c.Saldo = 10000;

                Console.Write("\nDigite o valor do emprestimo: ");
                double emprestimo = Convert.ToDouble(Console.ReadLine());
                c.FazerEmprestimo(emprestimo);

                Console.Write("\nDigite o valor do saque: ");
                double saque = Convert.ToDouble(Console.ReadLine());
                c.Sacar(saque);
            }
            else if(opcao == 0)
            {
                Console.WriteLine("\nObrigada por usar o programa! XD");
            }
            else
            {
                Console.WriteLine("\nOpção inválida!");
            }
        }
				
    }
}