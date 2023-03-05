int[,] GetMatrix(int rows, int cols, int minValue, int MaxValue) // , это двумерный массив, если ,, то трехмерный
{
    int[,] matrix = new int[rows, cols]; // первая всегда строчка потом столбцы
    for (int i = 0; i < matrix.GetLength(0); i++) // GetLength(0) - если ищем строчки и GetLength(1) - если ищем столбцы
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, MaxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
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

int[,] resultMatr = GetMatrix(3,4,0,100);
PrintMatrix(resultMatr);

// как инициализировать массив если незнаешь его длину

int[] arr;
int size = 10;

if (size != 0)
{
    arr = new int[size+1];
}

// элемент ищется по формуле (i + j), где i - номер строки и j - номер столбца

