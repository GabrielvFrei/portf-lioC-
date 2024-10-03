using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1POO
{
    internal class Pessoa
    {
        public int idade, telefone;
        public string nome;
        public void cadastrar()
        {
            MessageBox.Show("Bem vindo: "+ nome);
        }
        public void exibir()
        {
            MessageBox.Show("o nome do usuario é " + nome);
            MessageBox.Show("a idade do usuario é " + idade);
            MessageBox.Show("o telefone do usuario é " + telefone);
        }
    }
}
