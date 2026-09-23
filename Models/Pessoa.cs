using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExxemploFundamentos.Models;

namespace ExxemploFundamentos.Models
{
    public class Pessoa
    {
        public ContaCorrente? ContaCorrente { get; private set; }
        public string? Nome { get; private set; }
        public int Idade { get; private set; }
        public CPF? Cpf { get; private set; }
        public string? Senha { get; private set; }

        public Pessoa(string nome, int idade, string cpf, string senha)
        {
            Nome = nome;
            Idade = idade;
            Senha = senha;
            Cpf = new CPF(cpf);
        }

        public void AtribuirContaCorrente(ContaCorrente contaCorrente)
        {
            ContaCorrente = contaCorrente;
        }
    }
}