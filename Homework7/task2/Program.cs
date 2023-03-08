int row = GetNumberConsole("Введите номер искомой строки:");
int col = GetNumberConsole("Введите номер искомого столбца:");

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

int [,] Checked (int [,] array)
{
 
        int i = array.GetLength(0);
        int j = array.GetLength(1);
            if ((i-1) >= row && (j-1) >= col)
            {
                i = row; 
                j = col;
                Console.WriteLine($"нужный элемент: {array[i,j]}");
        
            }
            else
            {
               Console.WriteLine("такого элемента нет в массиве");
            }
    
    return array;
    
}

int [,] NewArray = GetArray(4,4, 0, 10);
int [,] ResultArray = Checked(NewArray);
PrintArrayInt(ResultArray);