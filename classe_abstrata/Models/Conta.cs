using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classe_abstrata.Models
{
    public abstract class Conta
    {
        protected decimal saldo = 500;

        public abstract void Creditar(decimal valor); 

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é: {saldo}");
        }
    }
}