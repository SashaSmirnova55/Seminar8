// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void Main()
{
    int row = ReadInt("Введите количество строк: ");
    int col = ReadInt("Введите количество столбцов: ");
    int dep = ReadInt("Введите количество чего-то там: ");

    if (row <= 1 || col <= 1 || dep <= 1)
    {
        System.Console.WriteLine("По введённым параметрам массив не является трёхмерным.");
    }
    else if (row * col * dep > 90)
    {
        System.Console.WriteLine("При введённых аргументах создание трехмерного массива с неповторяющимися двузначных чисел невозможно.");
    }
    else
    {
        int[,,] matrix = new int[row, col, dep];
        int count = 10;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                for (int k = 0; k < dep; k++)
                {
                    matrix[i, j, k] = count;
                    System.Console.Write($"\t{matrix[i, j, k]}, ({i} {j} {k})");
                    count++;
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }
    }
}


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


Main();