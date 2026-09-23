using System.ComponentModel;
using ExxemploFundamentos.Models;

// List<Pessoa> pessoas = new List<Pessoa>();  



Pessoa pessoa1 = new Pessoa("Daniel", 30, "1.456.78923-00", "a2m8");

string? opcao = "";

while (opcao != "0")
{
    
    Console.Write("||||||||||||||||||||||||||||||||||  Banco da Telecon  ||||||||||||||||||||||||||||||||||\n\n\n\n" +
                "Selecione uma das opções: \n\n" +
                "1 - Acessar conta existente. \n" +
                "2 - Cadastrar conta. \n" +
                "3 - Mostrar conta cadastrada. \n" +
                "0 - Sair do sistema. \n\n\n\n" +
                "||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||\n\n" +
                "Informe a opção selecionada: " + opcao);
    opcao = Console.ReadLine();
    Console.Clear();
    
    switch (opcao)
    {
        case "1":
            string? cpf = "0";
            string? senha = "";
    
    
            Console.Write("||||||||||||||||||||||||||||||||||  Tela de login!  ||||||||||||||||||||||||||||||||||\n\n" +
            "Informe os dados de acesso: \n\n" +
            "CPF: "); cpf = Console.ReadLine();
            Console.Write("Senha: "); senha = Console.ReadLine();
            if (cpf == pessoa1.Cpf?.NumeroCpf && senha == pessoa1.Senha)
            {
                Console.WriteLine("Acesso realizado!");
            }
            else
            {
                Console.WriteLine("Usuário ou senha incorreto!");
            }
            break;
    
        case "2":
            int agencia = 0;
            int contaComDigito = 0;
            decimal saldoConta = 0;
    
            Console.WriteLine("Cadastro de contas!!");
            Console.Write("Informe os dados para cadastro:\n\n" +
            "Agência: "); agencia = int.Parse(Console.ReadLine()!);
            Console.Write("Conta com digito: "); contaComDigito = int.Parse(Console.ReadLine()!);
            Console.Write("Saldo em conta:\nR$"); saldoConta = decimal.Parse(Console.ReadLine()!);
    
            ContaCorrente contaCorrente = new ContaCorrente(agencia, contaComDigito, saldoConta);
    
            Console.Clear();
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||\n" +
            "                          Cadastro realizado com sucesso!\n" +
            "||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
    
            pessoa1.AtribuirContaCorrente(contaCorrente);
    
            break;
    
        default:
            Console.WriteLine("Opção invalida!");
            break;
    }
}
