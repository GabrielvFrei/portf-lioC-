// See https://aka.ms/new-console-template for more information
using atividadeVinho;

Vinho v = new Vinho();
int opc;
do {
    Console.WriteLine("Menu: \r\n" +
        "1 - Cadastrar Vinho\r\n" +
        "2 - Verificar Preço\r\n" +
        "3 - Mostrar Vinhor\r\n" +
        "4 - Sair");
    opc = Convert.ToInt16(Console.ReadLine());
    switch (opc)
    {
        case 1:
            Console.WriteLine("digite um nome");
            string nome = Console.ReadLine();
            v.setNome(nome);
            Console.WriteLine("digite um tipo");
            string tipo = Console.ReadLine();
            v.setTipo(tipo);
            Console.WriteLine("digite um preco");
            double preco = Convert.ToInt16(Console.ReadLine());
            v.setPreco(preco);
            Console.WriteLine("digite uma safra");
            int safra = Convert.ToInt16(Console.ReadLine());
            v.setSafra(safra);
            break;

        case 2:
            if (v.verificaPreco() == true)
            {
                Console.WriteLine("Produto em oferta!");
            }
            else
            {
                Console.WriteLine("Produto com preço normal");
            }
            break;

        case 3:
            Console.WriteLine(v.mostrarVinho());
            break;

        case 4:
            Console.WriteLine("");
            break;
        default:
            Console.WriteLine("opção invailda");
            break;
    };
}while (opc != 4);

