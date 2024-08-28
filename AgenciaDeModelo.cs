

using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
//     Uma agência de publicidade pediu à agência de modelos Luz & Beleza para encontrar uma modelo que tenha
// idade entre 18 e 20 anos para participar de uma campanha publicitária milionária de produtos de beleza. Foram
// inscritas 20 candidatas e, ao se inscreverem, forneceram nome e idade. Tais informações foram armazenadas em
// 2 vetores distintos. Faça um programa para imprima o vetor que contém os nomes das candidatas aptas a
// concorrer a uma vaga para a campanha milionária.
    string [] nomes = new String[20];
    int [] idades = new int[20];
    
    for(int i = 0; i < 20; i++){
        Console.WriteLine("Digite sua idade");
        int idade = Int32.Parse(Console.ReadLine());
        if(idade >= 18 && idade <= 20){
            idades[i] = idade;
            Console.WriteLine("Digite seu Nome: ");
            nomes[i] = Console.ReadLine();
        }else{
            Console.WriteLine("Você não está entre a idade requisitada na campanha");
        };
    };
    for(int i = 0; i < 20; i++){
        Console.WriteLine((i+1)+" Candidata");
        Console.WriteLine("Nome: "+nomes[i]);
        Console.WriteLine("Idade: "+idades[i]);
        Console.WriteLine("------------------");
    }
    
  }
}