using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classe_abstrata.Models
{
    public sealed class ClasseSelada
    {
        public void MetodoNormal()
        {
            Console.WriteLine("Método Normal");
        }

        public void MetodoSelado()
        {
            Console.WriteLine("Método Selado");
        }
    }
}