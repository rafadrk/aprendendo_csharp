using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Investimento à Longo Prazo");

        double fatorRendimento = 1.005;
        double investimento = 1000;

        for(int anos = 1; anos <= 5; anos++)
        {
            for(int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
                Console.WriteLine("No mês " + mes + " você terá: " + investimento.ToString("c"));
            }

            fatorRendimento += 0.001;
            Console.WriteLine();

        }
        Console.WriteLine("Depois de 5 anos você terá R$ " + investimento.ToString("c"));

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}