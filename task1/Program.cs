/*Задача 1. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GenerateArray2D(int cols, int rows)
{
    double[,] array = new double[cols, rows];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * (9 - (-9)) + -9;
        }
    }
    return array;
}

void PrintArray2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write("{0:0.0}", array[i, j]);
            System.Console.Write("   ");
        }
        System.Console.WriteLine();
    }
}

int rows = ReadInt("Введите количество строк => ");
int cols = ReadInt("Введите количество столбцов => ");

double[,] arrayone = GenerateArray2D(cols, rows);
PrintArray2D(arrayone);