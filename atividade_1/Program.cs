using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Atividade 1");

        double n1, n2, n3, n4, resultado;
        resultado = n1 = n2 = n3 = n4 = 0;

        Console.WriteLine("Digite a nota 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 2: ");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 3: ");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 4: ");
        n4 = int.Parse(Console.ReadLine());

        resultado = n1 + n2 + n3 + n4;
        double media = resultado / 4;

        if(media > 6)
        {
            Console.WriteLine("Você foi aprovado");
        }
        if(media == 5)
        {
            Console.WriteLine("Você está de recuperação");
        }
        if(media <= 4)
        {
            Console.WriteLine("Você foi reprovado");
        }

        Console.WriteLine("O resultado de todas as notas é: " + resultado);

        Console.WriteLine("A média de todas as notas é: " + media);


        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}
