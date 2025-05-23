using System;

class exerc8
{
    static void Main()
    {
        int contador = 0;
        int pares = 0;

        while (contador < 10)
        {
            Console.Write("Digite o " + (contador + 1) + "º número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                pares++;
            }

            contador++;
        }

        Console.WriteLine("Quantidade de números pares: " + pares);
    }
}