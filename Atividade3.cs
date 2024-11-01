using System;
using BibliotecaMatriz;

    public class Atividade3
    {
    public static int EncontreX(int[,] matrix, int x)
    {
        int cont = 0;
        int linhas = matrix.GetLength(0); // pega linhas
        int cols = matrix.GetLength(1); // pega colunas

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == x)
                {
                    cont = cont + 1;
                }
            }
        }
        return x;
    }
    static void Main()
        {

            Console.WriteLine("Digite a quantidade de linhas e a quantidade de colunas: ");

            int linha = int.Parse(Console.ReadLine());
            int coluna = int.Parse(Console.ReadLine());

            int[,] matrix = new int[linha, coluna]; // criando a matriz

            Matrizes.gera(matrix);

            Console.WriteLine("Digite um número X para contar quantas vezes ele aparece: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Matriz Gerada: ");
            Console.WriteLine("Digite o valor para busca: ");
            int busca = int.Parse(Console.ReadLine());
            int qntd = EncontreX(matrix,busca);

            Console.WriteLine("Matriz Gerada: ");
            Matrizes.mostra(matrix);
            Console.ReadKey();
        }
    }
