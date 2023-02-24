﻿// int size = 12;
// int [] array = new int[size];

//метод создания массива
// 1 параметр - size
// 2 параметр - нижняя граница рандома (-9)
// 3 параметр - верхняя граница рандома (9)
int[] GetArray(int size, int minValue, int maxValue) 
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result; //вернули массив на Size элементов, заполненный числами
}

int[] array = GetArray(12, -9,9);

Console.WriteLine($"[{String.Join(";" , array)}]");

int sumPositive = 0;
int sumNegative = 0;
int size = array.Length;
for (int i = 0; i < size; i++)
{
    if (array[i] > 0)
    {
        sumPositive+=array[i];
    }
    else 
    {
        sumNegative+=array[i];
    }
}   

Console.WriteLine($"Сумма положительные чисел {sumPositive}, отрицательных чисел {sumNegative}");

int[] InverseArray(int[] inputArray)
{
    for (int i = 0; i < inputArray.Length; i++)
    {
        inputArray[i] *= (-1); // inputArray[i] = inputArray[i] * (-1)
    }
    return inputArray;
}

Console.WriteLine($"Исходный массив: [{String.Join("; ", array)}]");
Console.WriteLine($"Перевернутый массив:: [{String.Join("; ", InverseArray(array))}]");