class exerc5
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        double numero = double.Parse(Console.ReadLine());

        double dobro = numero * 2;

        Console.WriteLine("O dobro de " + numero + " é " + dobro + ".");
    }
}