using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ExxemploFundamentos.Models
{
    public class ContaCorrente
    {
        public int Agencia { get; private set; }
        public int ContaComDigito { get; private set; }
        public decimal SaldoConta { get; private set; }
        
        
        public ContaCorrente(int agencia, int contaComDigito, decimal saldoConta)
        {
            Agencia = agencia;
            ContaComDigito = contaComDigito;
            SaldoConta = saldoConta;
        }
        

        public void Conta()
        {

            Console.WriteLine("Aqui esta a conta selecionada: \n" +
                "Agencia: " + Agencia + " \n" +
                "Conta corrente com Digito: " + ContaComDigito + "\n" +
                "Saldo em conta: " + SaldoConta);
        }
    }
}