using System;
using BibliotecaMatriz;

    internal class Atividade11
    {
        public static int DiagonalPrincipal(int[,] matrix)
        {
            int linhas = matrix.GetLength(0);
            int soma = 0;
            for (int i = 0; i < linhas; i++)
            {
                Console.Write($"{matrix[i, i]} |");
                soma = matrix[i, i] + soma;
            }return soma;
        }
        public static int DiagonalSecundaria(int[,] matrix)
        {
            int linhas = matrix.GetLength(0);
            int colunas = matrix.GetLength(1);
            int j = colunas - 1;
            int soma = 0;
            for (int i = 0; i < linhas; i++)
            {
                Console.Write($"{matrix[i, j]} |");
                soma = soma + matrix[i, j];
                j--;
            }return soma;
        }
    static void Main()
    {

        Console.WriteLine("Digite a quantidade de linhas e a quantidade de colunas: ");

        int linha = int.Parse(Console.ReadLine());
        int coluna = int.Parse(Console.ReadLine());

        int[,] matrix = new int[linha, coluna]; // criando a matriz

        Matrizes.gera(matrix);

        Console.WriteLine("Matriz Gerada: ");

        Console.WriteLine("Matriz Gerada: ");
        Matrizes.mostra(matrix);
        Console.ReadKey();
    }
}
