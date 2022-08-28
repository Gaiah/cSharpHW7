// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void NewRandomMatrix (int[,] matr)
{
    System.Console.WriteLine();
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 15);
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
    System.Console.WriteLine();
}


int GetMidMath (int[,] matr)
{
    int column = 0;
    int sum = 0;
    double midMath = 0;
    while (column < matr.GetLength(1))
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, column];
        }
        midMath = (double) sum / matr.GetLength(0);
        System.Console.WriteLine($"The {column +1} column arithmetic mean =  {midMath.ToString("F1")}");
        column += 1;
        sum = 0;
    } return sum;
}


int[,] matrix = new int[9, 5];

NewRandomMatrix(matrix);
GetMidMath(matrix);
