/*Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого числа в массиве нет
1,2 -> 4*/

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateArray2D(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0,9);
        }
    }
    return array;
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void ItemPosition(int[,] array)
{
    int row = ReadInt("Введите позицию строки => ");
    int col = ReadInt("Введите позицию столбца => ");
    if (row < 0 || col < 0)
    {
        System.Console.WriteLine("Позиция не может быть отрицательным числом");
    }
    else if (row >= array.GetLength(0) || col >= array.GetLength(1))
    {
        System.Console.WriteLine("Такого числа в массиве нет");
    }
    else
    {
        System.Console.WriteLine($"{row}, {col} => {array[row, col]}");
    }
}

int[,] currentarray = GenerateArray2D(5, 6);
PrintArray2D(currentarray);
ItemPosition(currentarray);
