using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExxemploFundamentos.Models
{
    public class CPF
    {
        public string NumeroCpf { get; private set; }

        public CPF(string numeroCpf)
        {
            this.NumeroCpf = numeroCpf.Replace(".", "").Replace("-", "");
        }
    }
}