// See https://aka.ms/new-console-template for more information
using System.Numerics;

int[] numeros = new int[5];
int r = 0, soma = 0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite um numero:");
    r = Convert.ToInt32(Console.ReadLine());
    numeros[i] = r;
    if ((i % 2) == 0)
    {
        soma = soma + numeros[i];
        Console.WriteLine(numeros[i]);
    }
};
Console.WriteLine(soma);
