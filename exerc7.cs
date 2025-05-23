class exerc7
{
    static void Main()
    {
        Console.Write("Digite um número inteiro positivo: ");
        int N = int.Parse(Console.ReadLine());

        if (N <= 0)
        {
            Console.WriteLine("Por favor, digite um número inteiro positivo maior que zero.");
            return;
        }

        int soma = 0;

        for (int i = 1; i <= N; i++)
        {
            soma += i;
        }

        Console.WriteLine("A soma dos números de 1 até " + N + " é: " + soma);
    }
}