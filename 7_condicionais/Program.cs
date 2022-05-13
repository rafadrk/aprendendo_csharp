using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeRafael = 17;
        int qtdpessoas = 2;

        if (idadeRafael >= 18)
        {
            Console.WriteLine("Você pode entrar pois tem + de 18 anos");
        }
        else
        {
            if (qtdpessoas > 1)
            {
                Console.WriteLine("Está acompanhado, pode entrar");
            }
            else
            {
                Console.WriteLine("Você não pode entrar seu cocudo");
            }
        }

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}