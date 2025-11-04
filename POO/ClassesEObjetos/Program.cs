// using ClassesEObjetos;

// Pessoa joao = new Pessoa();

// joao.Nome = "Joao Silva";

// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

// int novaIdade = joao.Envelhecer(17);

// Console.WriteLine($"{joao.Nome} tem {novaIdade} anos");

// novaIdade =joao.Envelhecer(-50);
// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

using System.Collections;
using ClassesEObjetos;

Console.WriteLine($"-- Agencia Bancaria --");
Console.WriteLine($"Digite o nome do titular da conta ");
string nomeT = Console.ReadLine();

AgenciaBancaria conta = new AgenciaBancaria(nomeT);

Console.WriteLine();
Console.WriteLine($"Bem-Vindo , {conta.Titular}");
Console.WriteLine($"Saldo, inicial: R$ {conta.Saldo:F2}");
Console.WriteLine();

int opcao = 0;
do
{
    Console.WriteLine($"\n Menu");
    Console.WriteLine($"1 - Depositar");
    Console.WriteLine($"2 - Sacar");
    Console.WriteLine($"0 - Sair");

    Console.WriteLine();

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Digite o valor do deposito: R$");
            double deposito = Convert.ToDouble(Console.ReadLine());
            conta.Depositar(deposito);
            break;



        case 2:
            Console.WriteLine($"Digite o valor de saque: R$");
            double saque = Convert.ToDouble(Console.ReadLine());
            conta.Sacar(saque);
            break;

        case 0:
            Console.WriteLine($"Saindo.");
            break;

        default:
            Console.WriteLine($"Opcao invalida, escolhe uma das opcoes acima.");
            break;

    }
} while (opcao != 0);
