using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCPoo3
{
    internal class B : A
    {
        private int privateB = 4;
        protected int protectedB = 5;
        public int publicB = 6;

        public void ExibirValoresB()
        {
            Console.WriteLine("Valores B");
            //Console.WriteLine($"privateA: {privateA}"); É private, dai não mostra
            Console.WriteLine($"protectedA: {protectedA}");
            Console.WriteLine($"publicA: {publicA}");
            Console.WriteLine($"protectedB: {protectedB}");
            Console.WriteLine($"privateB: {privateB}");
            Console.WriteLine($"publicB: {publicB}");
        }
    }
}
