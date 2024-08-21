// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string nome, senha;
float tent = 3;

while (tent > 0){
    Console.WriteLine("Escreva um usuario");
    nome = Console.ReadLine();
    Console.WriteLine("Escreva uma senha");
    senha = Console.ReadLine();
    if (nome.Equals("etecitaquera") && senha.Equals.("etec"))
    {
        Console.WriteLine("Bem vindo ao sistema ETEC");
        break;
    }
    else {
        Console.WriteLine("Conta não encontrada, restam "+tent+" tentativas");
        tent--;
    }
};