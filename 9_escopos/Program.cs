using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 9 - Escopos");

        int idadeRafael = 17;
        int qtdpessoas = 2;

        bool acompanhado = qtdpessoas > 1;

        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "Rafael está acompanhado";
        }
        else
        {
            textoAdicional = "Rafael não está acompanhado";
        }
        if(idadeRafael >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar cocudo");
        }
        else
        {
            Console.WriteLine("Não pode emtrar!");
        }

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}