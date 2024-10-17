using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    internal class Cachorro : Animal
    {
        public void enterrarOsso(){
            System.Console.WriteLine("Enterrar Osso");
        }
        public void exibir() {
        System.Console.WriteLine(nome);
        System.Console.WriteLine(peso);
        }

}
}
