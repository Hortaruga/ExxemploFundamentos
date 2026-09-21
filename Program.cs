using System.ComponentModel;
using ExxemploFundamentos.Models;

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Daniel";
pessoa1.Idade = 30;
pessoa1.Cpf = "00000000000";
pessoa1.Senha = "a2m8";
//pessoa1.Apresentar();

ContaCorrente ContaCorrente = new ContaCorrente();
//ContaCorrente.Conta();
//ContaCorrente.Painel();
string? opcao = ""; 
string? cpf = "0";
string? senha = "";

Console.Write("||||||||||||||||||||||||||||||||||  Banco da Telecon  ||||||||||||||||||||||||||||||||||\n\n\n\n"+
            "Selecione uma das opções: \n\n"+
            "1 - Acessar conta existente. \n"+
            "2 - Cadastrar conta. \n"+
            "3 - Mostrar conta cadastrada. \n"+
            "0 - Sair do sistema. \n\n\n\n"+
            "||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||\n\n"+
            "Informe a opção selecionada: "+ opcao );
opcao = Console.ReadLine();
Console.Clear();

switch (opcao)
{
    case "1":
    Console.Write("||||||||||||||||||||||||||||||||||  Tela de login!  ||||||||||||||||||||||||||||||||||\n\n"+
    "Informe os dados de acesso: \n\n"+
    "CPF: "); cpf = Console.ReadLine();
    Console.Write("Senha: "); senha = Console.ReadLine();
        if (cpf == pessoa1.CPF && senha == pessoa1.Senha)
        {
            Console.WriteLine("Acesso realizado!");
        }
        else
        {
            Console.WriteLine("Usuário ou senha incorreto!");
        }
    break;

    case "2":
        Console.WriteLine("Cadastro de contas!!");
        Console.Write("Informe os dados para cadastro:\n\n" +
        "Agência: "); ContaCorrente.Agencia = int.Parse(Console.ReadLine()!);
        Console.Write("Conta com digito: "); ContaCorrente.ContaComDigito = int.Parse(Console.ReadLine()!);
        Console.Write("Saldo em conta:\nR$"); ContaCorrente.SaldoConta = decimal.Parse(Console.ReadLine()!);
        Console.Clear();
        Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||\n"+
        "                          Cadastro realizado com sucesso!\n"+
        "||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
    break;

    case "3":
        ContaCorrente.Conta();
    break;

    default:
    Console.WriteLine("Opção invalida!");
    break;
}