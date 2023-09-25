using Atividades_01___Heranca.classes;

public class Program
{
	static void Main(string[] args)
	{
        int nConta = 1;
        string agencia = "Jipa";
        while (true)
        {

            try
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Conta");
                Console.WriteLine("2 - Conta Empresarial");
                Console.WriteLine("3 - Conta Estudante");
                Console.WriteLine("Digite o número da opção: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o nome do titular: ");
                string titular = Console.ReadLine();

                if (opcao == 1)
                {
                    Conta c = new Conta(nConta, agencia, titular, 0);


                    while (true)
                    {
                        Console.WriteLine("Escolha uma opção: ");
                        Console.WriteLine("1 - Sacar");
                        Console.WriteLine("2 - Depositar");
                        Console.WriteLine("3 - Fechar");
                        int opcao1 = Convert.ToInt32(Console.ReadLine());

                        if (opcao1 == 1)
                        {
                            Console.WriteLine("Digite o valor: ");
                            double valor = Convert.ToDouble(Console.ReadLine());
                            c.Sacar(valor);
                            Console.WriteLine($"Saldo: {c.Saldo}");
                        }
                        else if (opcao1 == 2)
                        {
                            Console.WriteLine("Digite o valor: ");
                            double valor = Convert.ToDouble(Console.ReadLine());
                            c.Depositar(valor);
                            Console.WriteLine($"Saldo: {c.Saldo}");
                        }
                        else if (opcao1 == 3)
                        {
                            Console.Clear();
                            break;
                        }
                    }

                }
                else if (opcao == 2)
                {
                    ContaEmpresarial cEmp = new ContaEmpresarial(0, 5001, 2000,  nConta, agencia, titular, 0);
                    nConta += 1;

                    while (true)
                    {
                        Console.WriteLine("Escolha uma opção: ");
                        Console.WriteLine("1 - Deposito");
                        Console.WriteLine("2 - Sacar");
                        Console.WriteLine("3 - Emprestimo");
                        Console.WriteLine("4 - Fechar");
                        int opcao1 = Convert.ToInt32(Console.ReadLine());

                        if (opcao1 == 1)
                        {
                            Console.WriteLine("Digite o valor: ");
                            double valor = Convert.ToDouble(Console.ReadLine());
                            cEmp.Depositar(valor);
                            Console.WriteLine($"Saldo: {cEmp.Saldo}");
                        }
                        else if (opcao1 == 2)
                        {
                            Console.WriteLine("Digite o valor: ");
                            double valor = Convert.ToDouble(Console.ReadLine());
                            cEmp.Sacar(valor);
                            Console.WriteLine($"Saldo: {cEmp.Saldo}");
                        }
                        else if (opcao1 == 3)
                        {
                            Console.WriteLine("Digite o valor: ");
                            double valor = Convert.ToDouble(Console.ReadLine());
                            cEmp.FazerEmprestimo(valor);
                            Console.WriteLine($"Saldo: {cEmp.Saldo}");
                        }
                        else if (opcao1 == 4)
                        {
                            break;
                        }
                    }
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Digite o cpf do estudante: ");
                    string cpf = Console.ReadLine();
                    Console.WriteLine("Informe a instituição: ");
                    string instituicao = Console.ReadLine();
                    ContaEstudante cEst = new ContaEstudante(100, cpf, instituicao, nConta, agencia, titular, 0);
                    nConta += 1;

                    while (true)
                    {
                        Console.WriteLine("Escolha uma opção: ");
                        Console.WriteLine("1 - Sacar");
                        Console.WriteLine("2 - Deposito");
                        Console.WriteLine("3 - Fechar");
                        int opcao1 = Convert.ToInt32(Console.ReadLine());

                        if (opcao1 == 1)
                        {
                            Console.WriteLine("Digite o valor: ");
                            double valor = Convert.ToDouble(Console.ReadLine());
                            cEst.Sacar(valor);
                            Console.WriteLine($"Saldo: {cEst.Saldo}");
                        }
                        else if (opcao1 == 2)
                        {
                            Console.WriteLine("Digite o valor: ");
                            double valor = Convert.ToDouble(Console.ReadLine());
                            cEst.Depositar(valor);
                            Console.WriteLine($"Saldo: {cEst.Saldo}");
                        }
                        else if (opcao1 == 3)
                        {
                            break;
                        }
                    }

                }
            }
            finally
            {
                Console.WriteLine("Tchau");
            }
        }

        /*int opcao = 1;

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
        }*/
    }

}
