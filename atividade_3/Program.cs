using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Atividade 3");


        for(int numero = 1; numero <= 99; numero++)
        {
            numero = numero + 2;
            Console.WriteLine(numero);
        }

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}