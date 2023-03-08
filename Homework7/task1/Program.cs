double[,] GetArray(int rows, int cols)
{

    double[,] array = new double[rows, cols];
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            array[row, col] = new Random().NextDouble();
        }
    }
    return array;
}

int[,] Transform(double[,] array)
{
var t = 100; 
    int[,] PseudoArray = new int[array.GetLength(0),array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            PseudoArray[i, j] = (int)Math.Ceiling(array[i, j] * t);
        }
    }
    return PseudoArray;
}

void PrintArrayDouble(double[,] matr)
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

double[,] result = GetArray(3,4);
PrintArrayDouble(result);
int[,] FinalArray = Transform(result);
PrintArrayInt(FinalArray);