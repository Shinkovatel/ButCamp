// int[,] GetMatrix(int rows, int cols, int minValue, int MaxValue) // , это двумерный массив, если ,, то трехмерный
// {
//     int[,] matrix = new int[rows, cols]; // первая всегда строчка потом столбцы
//     for (int i = 0; i < matrix.GetLength(0); i++) // GetLength(0) - если ищем строчки и GetLength(1) - если ищем столбцы
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(minValue, MaxValue + 1);
//         }
//     }
//     return matrix;
// }

// int[,] changeMatrix(int[,] InputMatrix)
// {
//     for (int i = 0; i < InputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < InputMatrix.GetLength(1); j++)
//         {
//             if(i % 2 == 0 && j % 2 == 0 && i!= 0 && j!= 0)
//             {
//                 InputMatrix[i,j] *=  InputMatrix[i,j];
//             }
//         }
//     }
//     return InputMatrix;
// }


// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write(matr[i, j] + "\t ");

//         }
//         Console.WriteLine();
//     }
// }

// int[,] resultMatr = GetMatrix(3,4,0,10);
// PrintMatrix(resultMatr);
// PrintMatrix(changeMatrix(resultMatr));

// //Console.WriteLine($"Результат ")

// string CompareValue (int A, int B)
// {
//     if (A > B)
//     {
//         return "Число А больше, чем В";
//     }
//     else if (A < B)
//     {
//         return "Число B больше, чем A";
//     }
//     return "Error";
//}
 // Вариант проверки с помощью метода
int GetNumberConsole (string message)
{
    int Number = 0;
    Console.Write(message);
    string? strValue = Console.ReadLine();
    if (!int.TryParse(strValue, out Number))
    {
        Console.WriteLine("Введите числовое значение");
        Environment.Exit(-1);
    }
    return Number;
}

int A = GetNumberConsole("Введите значение А: ");

