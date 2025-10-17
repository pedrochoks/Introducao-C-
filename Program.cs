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
        switch (opcao)
        {
            case 1:
                Console.WriteLine("Digite o numero que deseja ver a tabuada: ");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("A tabuada deste numero é: ");
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i * numero);
                }
                break;

            case 2:
                Console.WriteLine("Digite ate o numero que deseja contar: ");
                int numeroContar = int.Parse(Console.ReadLine());

                for (int n = 0; n <= numeroContar; n++)
                {
                    Console.WriteLine(n);
                }
                break;

            case 3:
                Console.WriteLine("Voce saiu");
                break;
        }

        //* Sequencia de fibonacci
        int numeroAtual = 1;
        int numeroAnterior = 0;

        for (int i = 0; i < 11; i++)
        {
            int resultado = numeroAnterior + numeroAtual;
            numeroAnterior = numeroAtual;
            numeroAtual = resultado;
            Console.WriteLine(resultado);
        }
    }
}
