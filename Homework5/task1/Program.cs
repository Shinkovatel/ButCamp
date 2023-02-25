int[] GetArray(int size) 
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100,999);
    }
    return result; //вернули массив на Size элементов, заполненный числами
}

int[] EvenArray = GetArray(5);

Console.WriteLine($"[{String.Join(";" , EvenArray)}]");

int CountNumber =0;

int size = EvenArray.Length;

for (int i = 0; i < size; i++)
{
    if (EvenArray[i] % 2 == 0)
    {
        CountNumber++;
    }
}
Console.WriteLine($"Количество четных чисел в массиве: {CountNumber}");