namespace ConsoleApp1
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Введіть розмірність матриці: ");
            int n = int.Parse(Console.ReadLine());

            int[,] adjacencyMatrix = new int[n, n];

            Console.WriteLine("Введіть матрицю суміжності:");
            for (int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    adjacencyMatrix[i, j] = int.Parse(row[j]);
                }
            }

            int[,] pathMatrix = CalculatePathMatrix(adjacencyMatrix, n);

            Console.WriteLine("Матриця існування шляхів:");
            PrintMatrix(pathMatrix, n);

            Console.WriteLine("Матриця суміжності в квадраті:");
            PrintMatrix(MatrixPower(adjacencyMatrix, n, 2), n);

            Console.WriteLine("Матриця суміжності в кубі:");
            PrintMatrix(MatrixPower(adjacencyMatrix, n, 3), n);

            Console.WriteLine("Матриця суміжності в четвертому степені:");
            PrintMatrix(MatrixPower(adjacencyMatrix, n, 4), n);
        }

        static int[,] MatrixPower(int[,] matrix, int n, int power)
        {
            int[,] result = (int[,])matrix.Clone();
            int[,] temp = new int[n, n];

            for (int p = 1; p < power; p++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        temp[i, j] = 0;
                        for (int k = 0; k < n; k++)
                        {
                            temp[i, j] += result[i, k] * matrix[k, j];
                        }
                    }
                }
                result = (int[,])temp.Clone();
            }

            return result;
        }

        static int[,] CalculatePathMatrix(int[,] matrix, int n)
        {
            int[,] pathMatrix = (int[,])matrix.Clone();

            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        pathMatrix[i, j] = pathMatrix[i, j] | (pathMatrix[i, k] & pathMatrix[k, j]);
                    }
                }
            }

            return pathMatrix;
        }

        static void PrintMatrix(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }


}