using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 - Conversões e outros tipos...");

        double salario = 5000.15;
        Console.WriteLine(salario);

        int salariointeiro = (int)salario;
        Console.WriteLine(salariointeiro);
        //o long é um tipo de variável de 64 bits
        long x;
        x = 20000000000000;
        Console.WriteLine(x);

        short y;
        y = 150;
        Console.WriteLine(y);

        float altura = 1.72f;
        Console.WriteLine(altura);

        Console.WriteLine("Pressione ENTER para encerrar");
    }
}
