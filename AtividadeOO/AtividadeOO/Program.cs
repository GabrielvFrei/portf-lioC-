// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using AtividadeOO;

Empregado e = new Empregado();

Console.WriteLine("Qual o nome do empregado?");
string nome = Console.ReadLine();
e.setNome(nome);
Console.WriteLine("Qual o endereço do funcionario?");
string endereco = Console.ReadLine();
e.setEndereco(endereco);
Console.WriteLine("O seu empregado é:\r\n1 - Horista\r\n2-Mensalista");
int empregado = Convert.ToInt16(Console.ReadLine());
switch (empregado)
{
    case 1:
        Horista h = new Horista();
        h.setNome(nome);
        h.setEndereco(endereco);
        h.calcularSalario();
        Console.WriteLine("O salário do empregado horista é: " + h.getSalario());
        break;
    case 2:
        Mensalista m = new Mensalista();
        m.setNome(nome);
        m.setEndereco(endereco);
        m.calcularSalario()
        Console.WriteLine("O salário do empregado mensalista é: " + m.getSalario());
        break;
    default:
        Console.WriteLine("Invalido");
        return;
}