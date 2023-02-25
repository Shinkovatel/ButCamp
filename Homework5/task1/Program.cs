﻿int[] GetArray(int size) 
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

int SumEvenNumber =0;

int size = EvenArray.Length;

for (int i = 0; i < size; i++)
{
    if (EvenArray[i] % 2 == 0)
    {
        SumEvenNumber+= EvenArray[i];
    }
}
Console.WriteLine($"Сумма четных чисел {SumEvenNumber}");