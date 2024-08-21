// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;
int soma = 0;
int c = 1;
while (c != 0)
{
    Console.WriteLine("Digite um valor(Pressione 0 para cancelar)");
    c = int.Parse(Console.ReadLine());
    soma = soma + c;
};
Console.WriteLine(soma);
