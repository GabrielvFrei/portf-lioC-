using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeOO
{
    internal class Mensalista : Empregado
    {
        private string cargo;

        public void calcularSalario()
        {
                Console.WriteLine("Qual o cargo do Empregado?");
                cargo = Console.ReadLine();
            switch (cargo)
            {
                case "Junior":
                    setSalario(2500);
                    break;

                case "Pleno":
                    setSalario(3500);
                    break;

                case "Senior":
                    setSalario(5500);
                    break;
                default:
                    Console.WriteLine("Invalido");
                    break;
            }
        }
    }
}