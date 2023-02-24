// Заполнение массива методом

int[] GetBinaryArray(int size)
{
    int [] array = new int[size]; // массив на 8 элементов из нулей
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2); // заполняем 0 и 1 случайно
    }
    return array;
}

int[] resultArray = GetBinaryArray(8);
double[] testArray = new double[10];

for (int i = 0; i < resultArray.Length; i++)
{
    Console.Write(resultArray[i]+ "\t");
}

// Console.WriteLine(testArray);
// Console.WriteLine(resultArray);
 
 Console.WriteLine($"Массив [{String.Join("\t", resultArray)}]");