using System;
using System.Linq;

int row = GetNumberConsole("Введите количество строк в двухмерном массиве: ");
int col = GetNumberConsole("Введите количество столбцов в двухмерном массиве: ");
int minValue = GetNumberConsole("Введите минимальное значение в массиве: ");
int maxValue = GetNumberConsole("Введите максимальное значение в массиве: ");
int[,] GetArray(int rows, int cols, int minValue, int MaxValue)
{
    int[,] array = new int[rows, cols]; 
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, MaxValue + 1);
        }
    }
    return array;
}

void PrintArrayInt(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t ");

        }
        Console.WriteLine();
    }
}

int GetNumberConsole(string message)
{
input1:
    Console.Write(message);
    bool check_Number = int.TryParse(Console.ReadLine(), out int Number);
    if (!check_Number)
    {
        Console.WriteLine("Введены не верные данные");
        goto input1;
    }
    return Number;
}

int[,] MatrixArray = GetArray(row, col, minValue, maxValue);
PrintArrayInt(MatrixArray);

 
double[] sum = new double[col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
        sum[j] += MatrixArray[i,j]/col;
        }
    }
Console.WriteLine($" Среднее арифметическое значение столбцов [{String.Join(";", sum) }]");

// double result = 0;
// foreach (double element in sum)
// {
//     result = element / col;
//     Console.WriteLine($" Среднее арифметическое значение столбцов [{String.Join(";", result) }]");
// }
 // int [,] GetSummCol(int [,] array)
// {
//     var sum = Enumerable.Range(0, col).Select(x => array.GetColumn(x).Sum()/col);
// }

// Console.WriteLine($" Среднее арифметическое значение столбцов [{String.Join(";", sum) }]");


// static class Program
// {
    
//  public static T [] GetColumn<T>(this T[,] data, int i) 
// {
//     return Enumerable.Range(0, data.GetLength(0)).Select(j => data [j,i]).ToArray();
// }
// }