using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Investimento à Longo Prazo");

        for (int contadorLinha = 0; contadorLinha <= 10; contadorLinha++)
        {
            for (int contadorColuna = 0; contadorColuna <= 10; contadorColuna++)
            {
                Console.Write("*");

                if (contadorColuna >= contadorLinha)
                {
                    break;
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}