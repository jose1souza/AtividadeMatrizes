using System;
using BibliotecaMatriz;
using System.IO;
class Program
{
     static void Main()
    {
        int linhas, colunas;

        // tipo[,] nomedamatriz = new tipo {linha,coluna}

        Console.WriteLine("*** Matrizes ***");

        Console.WriteLine("Quantidade de linhas e colunas");

        linhas = int.Parse(Console.ReadLine());
        colunas = int.Parse(Console.ReadLine());

        int[,] matrix = new int[linhas, colunas]; // criando

       // Console.WriteLine("Entre com dados para a matriz: ");
        //Matrizes.leia(matrix);

       // Console.WriteLine("Dados da matriz: ");
        //Matrizes.mostra(matrix);

        Console.WriteLine("Entre com os dados para a matriz");
        Matrizes.gera(matrix);

        Console.WriteLine("Dados da matriz: ");
        Matrizes.mostra(matrix);

        Console.ReadKey();
    }
}
