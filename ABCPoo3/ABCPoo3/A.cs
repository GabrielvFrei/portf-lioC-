using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCPoo3
{
    internal class A
    {
        private int privateA = 1;
        protected int protectedA = 2;
        public int publicA = 3;

        public void ExibirValoresA()
        {
            Console.WriteLine("Valoras A");
            Console.WriteLine($"privateA: {privateA}");
            Console.WriteLine($"protectedA: {protectedA}");
            Console.WriteLine($"publicA: {publicA}");
        }
    }
}

