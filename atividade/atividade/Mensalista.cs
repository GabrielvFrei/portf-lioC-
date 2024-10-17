// Mensalista.cs
using System;

namespace atividade
{
    internal class Mensalista : Empregado
    {
        private string cargo;

        public void setCargo(string cargo)
        {
            this.cargo = cargo;
        }

        public string getCargo()
        {
            return cargo;
        }

        public void calcularSalario()
        {
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
                    throw new ArgumentException("Cargo inválido.");
            }
        }
    }
}
