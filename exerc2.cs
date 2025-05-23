namespace projeto2;

class Program
{
    public static void Main(string[] args)
    {
        double nota1, nota2, nota3, media;

        Console.Write("Digite a primeira nota: ");
        nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        nota3 = Convert.ToDouble(Console.ReadLine());

        media = (nota1 + nota2 + nota3) / 3;

        if (media >= 7.0)
        {
            Console.WriteLine($"Média: {media:F2} - Aluno Aprovado!");
        }
        else
        {
            Console.WriteLine($"Média: {media:F2} - Aluno Reprovado.");
        }
    }
}
