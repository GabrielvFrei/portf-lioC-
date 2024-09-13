// See https://aka.ms/new-console-template for more information
/*double med, men = 10000, mai = 0, temp = 0, temptotal = 0;
int c = 1, opc = 1;

do {
    Console.WriteLine("Digite uma temperatura");
    temp = Convert.ToDouble(Console.ReadLine());
    temptotal = temp + temptotal;
    med = temptotal / c;
    if (men > temp){
        men = temp;
    };
    if(mai < temp) {
        mai = temp;
    };
    Console.WriteLine("Quer adicionar mais uma temperatura? SIM(1) NÃO(2)");
    opc = Convert.ToInt32(Console.ReadLine());
    c++;
} while(opc == 1);
Console.WriteLine("A media das temperaturas é: "+med);
Console.WriteLine("A menor temperatura foi: "+men);
Console.WriteLine("A maior temperatura foi: "+ mai)*/

/*string user, senha;

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Digite um usuario");
    user = Console.ReadLine();
    Console.WriteLine("Digite um senha");
    senha = Console.ReadLine();
    if (user == "etec" && senha == "123") {
        Console.WriteLine("Entrou na conta");
        break;
    }
};*/
/*double i, idade, fatorial;
Console.WriteLine("Informe a idade");
idade = double.Parse(Console.ReadLine());

fatorial = idade;
for (i = idade - 1; i >= 1; i--)
{
   fatorial = fatorial * i;
}
Console.WriteLine(fatorial);*/

/*using System;
using System.Numerics;

int num1, num2 = 0, soma = 0; 
Console.WriteLine("Digite um numero");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite um outro numero");
num2 = Convert.ToInt32(Console.ReadLine());

for (int i = num1; i < num2; i++)
{
    if (i % 2 == 0)
    {
        soma = i + soma;
    };
    Console.WriteLine(soma);
};
Console.WriteLine(soma);*/