using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeOO
{
    internal class Horista : Empregado
    {
        private int horasTrabalhadas;

        public void calcularSalario()
        {
            Console.WriteLine("Quantas horas o empregado trabalha?");
            horasTrabalhadas = Convert.ToInt16(Console.ReadLine());
            setSalario(horasTrabalhadas * 150);
        }
    }
}
