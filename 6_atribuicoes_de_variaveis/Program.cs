using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 6 - Atribuições de Variáveis");

        int idade = 34;
        int idadeRoberto = idade;

        Console.WriteLine(idadeRoberto);

        idade = 25;

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}