﻿// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void Main()
{
    System.Console.WriteLine("Сейчас, друг, тебе придётся ввести количество строк и столбцов для двух матриц для последующего их перемножения. Помни о том, чтобы произведение состоялось, необходимо чтобы количество строк первой матрицы совпадали с количеством столбцов второй и наоборот. Удачи!");
    System.Console.WriteLine();
    int row1 = ReadInt("Введите количество строк первой матрицы: ");
    int col1 = ReadInt("Введите количество столбцов первой матрицы: ");
    int row2 = ReadInt("Введите количество строк второй матрицы: ");
    int col2 = ReadInt("Введите количество столбцов второй матрицы: ");

    int[,] matrix1 = FillMatrix(row1, col1, 1, 5);
    int[,] matrix2 = FillMatrix(row2, col2, 1, 5);

    System.Console.WriteLine("Первая матрица:");
    PrintMatrix(matrix1);
    System.Console.WriteLine();
    System.Console.WriteLine("Вторая матрица:");
    PrintMatrix(matrix2);
    System.Console.WriteLine();

    if (matrix1.GetLength(0) != matrix2.GetLength(1))
    {
        System.Console.WriteLine("Ты ввёл такие значения строк и столбцов, что матрицы перемножить невозможно...");
    }
    else
    {
        int[,] newMatrix = MultiplicationMatrix(matrix1, matrix2);
        System.Console.WriteLine("Результат перемножения матриц:");
        PrintMatrix(newMatrix);
    }
}


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return tempMatrix;
}


void PrintMatrix(int[,] matrixToPrint)
{
    for (int i = 0; i < matrixToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixToPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixToPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] tempMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int x = 0; x < matrix1.GetLength(1); x++)
                {
                    tempMatrix[i, j] += matrix1[i, x] * matrix2[x, j];
                }
            }
        }

    }
    return tempMatrix;
}


Main();