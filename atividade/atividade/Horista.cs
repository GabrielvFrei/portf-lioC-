// Horista.cs
using System;

namespace atividade
{
    internal class Horista : Empregado
    {
        private int horasTrabalhadas;

        public void setHorasTrabalhadas(int horasTrabalhadas)
        {
            this.horasTrabalhadas = horasTrabalhadas;
        }

        public int getHorasTrabalhadas()
        {
            return horasTrabalhadas;
        }

        public void calcularSalario()
        {
            setSalario(50 * horasTrabalhadas);
        }
    }
}
