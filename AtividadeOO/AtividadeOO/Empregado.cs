using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AtividadeOO
{
    internal class Empregado
    {
        private string nome;
        private string endereco;
        private double salario;

        public void setNome(string nome) {
            this.nome = nome;
        }
        public string getNome() {
            return this.nome;
        }
        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }
        public string getEndereco()
        {
            return this.endereco;
        }
        public void setSalario(double salario)
        {
            this.salario = salario;
        }
        public double getSalario()
        {
            return this.salario;
        }
        public void calcularINSS() {
            if (this.salario > 1800) {
                double IRPF = this.salario * 0.10;
            }
            else
            {
                double IRPF = this.salario * 0.27;
            }
            double INSS = this.salario * 0.11;
        }
    }
}
