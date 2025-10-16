namespace Introducao_C_;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem Vindo(a) ao sistema.");

        //Entrada de dados
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nOla, {nome}! Voce tem {idade} anos.");

        if (idade < 18)
        {
            Console.WriteLine("Voce ainda de e menor de idade");
        }
        else
        {
            Console.WriteLine("Voce ja e maior de idade");
        }

        // Menu
        Console.WriteLine("\nEscolha uma opcao: ");
        Console.WriteLine("1 - Ver a tabuada de um numero: ");
        Console.WriteLine("2 - Contar ate um numero: ");
        Console.WriteLine("3 - Sair");
        Console.WriteLine("Digite a sua opcao:");
        int opcao = int.Parse(Console.ReadLine());
    }
}
