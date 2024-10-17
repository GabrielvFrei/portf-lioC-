using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    internal class Animal
    {
        public double peso;
        public string comida;
        public string nome;

        public void comer() {
            System.Console.WriteLine("comer");
        }
        public void dormir()
        {
            System.Console.WriteLine("dormiu");
        }

        public void fazerBarulho()
        {
            System.Console.WriteLine("Barulho");
        }
    }
}
