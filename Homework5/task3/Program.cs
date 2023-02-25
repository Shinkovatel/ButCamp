Double[] RandomArray(int size)
{
    Double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble();
    }
    return result; //вернули массив на Size элементов, заполненный числами
}

Double[] realArray = RandomArray(5);
int size = realArray.Length;

var t = 100;

// for (int i = 0; i < size; i++) // умножили каждый элемент массива на 100
// {
//     realArray[i] = t * realArray[i];
// }
Console.WriteLine($"[{String.Join(";", realArray)}]"); // для проверки вывода

// преобразовали массив из Double в int, чтобы удобнее было считать
    int[] PsevdoArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        PsevdoArray[i] = (int)Math.Ceiling(realArray[i]*t);
    }

Console.WriteLine($"[{String.Join(";", PsevdoArray)}]"); // для проверки вывода

//  поиск максимального и минимального элемента массива
int size2 = PsevdoArray.Length;
int minValue = PsevdoArray[0];
int maxValue = PsevdoArray[0];
for (int i = 0; i < size2; i++)
{
    if (maxValue < PsevdoArray[i])
    {
        maxValue = PsevdoArray[i];
    }
    else if (minValue > PsevdoArray[i])
    {
        minValue = PsevdoArray[i];
    }

}

Console.WriteLine($"Минимальное значение массива {minValue}" + "\n" + $"Максимальное значение массива {maxValue}");