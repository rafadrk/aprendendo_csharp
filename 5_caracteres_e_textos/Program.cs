using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e Textos...");

        char letra = 'R';
        Console.WriteLine(letra);

        letra = (char)97;
        Console.WriteLine(letra);

        letra = (char)102;
        Console.WriteLine(letra);

        letra = (char)97;
        Console.WriteLine(letra);

        letra = (char)101;
        Console.WriteLine(letra);

        letra = (char)108;
        Console.WriteLine(letra);



        letra = (char)82;
        Console.Write(letra);

        letra = (char)97;
        Console.Write(letra);

        letra = (char)102;
        Console.Write(letra);

        letra = (char)97;
        Console.Write(letra);

        letra = (char)101;
        Console.Write(letra);

        letra = (char)108;
        Console.WriteLine(letra);

        string primeirafrase = "SENAI - Cursos de Tecnologia ";
        Console.WriteLine(primeirafrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        string cursos = @"Cursos Disponíveis:
-c  
-c++  
-c#";
        Console.WriteLine(cursos);

        Console.WriteLine(vazia);

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}