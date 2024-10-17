// Program.cs
using System;

namespace atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregado e = new Empregado();
            Mensalista m = new Mensalista();
            Horista h = new Horista();

            Console.WriteLine("Digite o nome do funcionário:");
            string nome = Console.ReadLine();
            e.setNome(nome);

            Console.WriteLine("Digite o endereço do funcionário:");
            string endereco = Console.ReadLine();
            e.setEndereco(endereco);

            Console.WriteLine("Seu funcionário é Mensalista(1) ou Horista(2)?");
            int cod = Convert.ToInt32(Console.ReadLine());

            if (cod == 1)
            {
                Console.WriteLine("Qual o cargo do funcionário?");
                string cargo = Console.ReadLine();
                m.setCargo(cargo);
                m.calcularSalario();
                Console.WriteLine("O salário do " + nome + " é igual a " + m.getSalario());
            }
            else if (cod == 2)
            {
                Console.WriteLine("Quantas horas o funcionário trabalha?");
                int ht = Convert.ToInt32(Console.ReadLine());
                h.setHorasTrabalhadas(ht);
                h.calcularSalario();
                Console.WriteLine("O funcionário " + nome + " tem o salário de " + h.getSalario());
            }
        }
    }
}
