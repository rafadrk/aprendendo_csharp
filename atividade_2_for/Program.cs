using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula Poupança");

        double investimento = 1000;
        //rendimento de 0,5% (0,005) ao mês

        int mes = 12;
        int numerosoma = 1;

        for (int i = 1; i <= mes; i++)
        {
            investimento *= 1.005;
            Console.WriteLine("No mes " + numerosoma + " você tem: ");
            Console.WriteLine("R$" + investimento);
            numerosoma += 1; //incremento com valor maior de 1 um se usa += (mes = mes + 1)
        }

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}