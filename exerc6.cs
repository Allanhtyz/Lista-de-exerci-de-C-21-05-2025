class exerc6
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 3 == 0)
        {
            Console.WriteLine("O número é divisível por 3.");
        }
        else
        {
            Console.WriteLine("O número não é divisível por 3.");
        }
    }
}