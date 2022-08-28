// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

System.Console.WriteLine("Input the number of strings: ");
int str = int.Parse(Console.ReadLine() ?? "0");

System.Console.WriteLine("Input the number of columns: ");
int col = int.Parse(Console.ReadLine() ?? "0");

double[,] matrix = new double[str, col];

void NewRandomMatrix (double[,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.NextDouble() * 30 - 10;
            Console.Write("{0,8:F2}", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

NewRandomMatrix(matrix);