using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ExxemploFundamentos.Models
{
    public class ContaCorrente
    {
        public int Agencia { get; set; }
        public int ContaComDigito { get; set; }
        public decimal SaldoConta { get; set; }
        public void Conta()
        {
            
            Console.WriteLine("Aqui esta a conta selecionada: \n" +
                "Agencia: "+ Agencia + " \n" + 
                "Conta corrente com Digito: " + ContaComDigito + "\n" +
                "Saldo em conta: "+SaldoConta );
        }

// string? opcao = ""; 
//         public void Painel()
//         {
//             Console.Write("||||||||||||||||||||||||||||||||||  Banco da Telecon  ||||||||||||||||||||||||||||||||||\n\n\n\n"+
//             "Selecione uma das opções: \n\n"+
//             "1 - Acessar conta existente. \n"+
//             "2 - Cadastrar conta. \n"+
//             "3 - Mostrar conta cadastrada.  \n\n\n\n"+
//             "||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||\n\n"+
//             "Informe a opção selecionada: "+ opcao );
//         }
    }
}