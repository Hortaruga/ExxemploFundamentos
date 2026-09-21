using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExxemploFundamentos.Models;

CPF cpf = new CPF();

namespace ExxemploFundamentos.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public CPF? Cpf {get; private set;}
        public string? Senha { get; set; }

       public void AtribuiCpf()
        {
            
        }

    }
}