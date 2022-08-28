// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

//Пример не соответствует условию. Напишу решение к условию 
//так как похожая задача, которой соответствовал бы пример уже была решена.

void NewRandomMatrix (int[,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(10, 100);
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// Сначала объединила эти два метода, но потом передумала и вернула как было

void FindTheElement (int str, int col, int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if (str - 1 >= matr.GetLength(0) || col - 1 >= matr.GetLength(1))
        {
            System.Console.WriteLine("There is no such position in this matrix");
            break;
        }    
    
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == str - 1 && j == col - 1)
            {
                System.Console.WriteLine($"The element at the selected position is: {matr[i, j]}");
            }
        }
    
    } 
}

System.Console.WriteLine("What string is the element on? : ");
int str = int.Parse(Console.ReadLine() ?? "0");

System.Console.WriteLine("Which column is the element in? : ");
int col = int.Parse(Console.ReadLine() ?? "0");
System.Console.WriteLine();

int[,] matrix = new int[6, 6];
NewRandomMatrix(matrix);
FindTheElement(str, col, matrix);