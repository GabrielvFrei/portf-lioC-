// Empregado.cs
using System;

namespace atividade
{
    internal class Empregado
    {
        private string nome;
        private string endereco;
        private double salario;

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return nome;
        }

        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public string getEndereco()
        {
            return endereco;
        }

        public void setSalario(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario + calcularIRPF() + calcularINSS();
        }

        public double calcularINSS()
        {
            return (salario * 0.18);
        }

        public double calcularIRPF()
        {
            return salario < 1800 ? salario * 0.10 : salario * 0.27;
        }
    }
}
