using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace aula10
{
    internal class Pessoa
    {
        private string nome;
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return nome;
        }
        public Pessoa()
        {
            this.nome = "invalido";

        }
    }

}

