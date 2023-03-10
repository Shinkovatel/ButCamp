/// <summary>
/// 
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="cols">Количество столбцов</param>
/// <param name="minValue">Минимальное число для рандома </param>
/// <param name="MaxValue">Максимальное число для рандома </param>
/// <returns></returns>

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
/// <summary>
/// Метод печатает двумерный массив переданный на вход
/// </summary>
/// <param name="matr"> Входная матрица </param>
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

int[,] resultArray = GetArray(3,3,0,10); // 3 стр, 3 столбца, числа от 0 до 10 включительно

PrintArrayInt(resultArray);
/// <summary>
/// 
/// </summary>
/// <param name="inputArray"></param>//
void ChangeRows (int[,] inputArray)
{
    
    int lastRow = inputArray.GetLength(0) - 1; // Индекс последней строчки
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
    int temp = inputArray[0,i]; // Элемент таблицы из нулевой строчки и i столбца
    inputArray[0,i] = inputArray[lastRow,i]; // Элемент из нулевой строчки и i столбца = элементу из посл строчки и i столбца
    inputArray[lastRow, i] = temp;
    }
}

ChangeRows(resultArray);
Console.WriteLine("Измененный массив");
PrintArrayInt(resultArray);