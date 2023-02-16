// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся
//  на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();
Console.WriteLine();

int[,] GetMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

int FindSumMainDiagonal(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        sum = sum + matr[i, i];  
    }
    return sum;
}

void PrintMatrix(int[,] matr)
{
    Console.WriteLine();
    Console.WriteLine("Матрица:");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] > 100) Console.Write($"{matr[i, j]}   ");
            else if (matr[i, j] > 10) Console.Write($" {matr[i, j]}   ");
            else if (matr[i, j] > 0) Console.Write($"  {matr[i, j]}   ");
        }
        Console.WriteLine();
    }
}

void PrintMainDiagonal(int[,] matrix)
{
    Console.WriteLine();
    Console.WriteLine("Главная диагональ:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) Console.Write(matrix[i, j]);
            else Console.Write("      ");
        }
        Console.WriteLine();
    }
}

int row = 7;
int col = 10;
int min = 1;
int max = 1000;

int[,] matrix = GetMatrix(row, col, min, max);
PrintMatrix(matrix);
PrintMainDiagonal(matrix);
int sumDiagonal = FindSumMainDiagonal(matrix);
Console.WriteLine();
Console.WriteLine($"Сумма элементов главной диагонали матрицы составляет: {sumDiagonal}");
Console.WriteLine();