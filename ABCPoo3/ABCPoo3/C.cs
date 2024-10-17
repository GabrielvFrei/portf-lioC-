using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCPoo3
{
    internal class C : B
    {
        private int privateC = 7;
        protected int protectedC = 8;
        public int publicC = 9;

        public void ExibirValoresB()
        {
            Console.WriteLine("Valores B");
            //Console.WriteLine($"privateA: {privateA}"); É private, dai não mostra
            Console.WriteLine($"protectedA: {protectedA}");
            Console.WriteLine($"publicA: {publicA}");
            Console.WriteLine($"protectedB: {protectedB}");
            Console.WriteLine($"publicB: {publicB}");
            Console.WriteLine($"protectedB: {protectedC}");
            Console.WriteLine($"privateB: {privateC}");
            Console.WriteLine($"publicB: {publicC}");
        }
    }
}
