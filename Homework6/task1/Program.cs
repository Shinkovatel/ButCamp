﻿Console.Write("Введите числa : ");
String valueStr = Console.ReadLine(); // числа текстом
string[] values = valueStr.Split(","); // числа по отдельности

float[] PointA= new float[values.Length]; // определили новый массив, с длиной массива values
int j = 0;
foreach (string value in values)
    PointA[j++] = Convert.ToSingle(value);
 
int razmer=PointA.Length;

int count = 0;
for (int i = 0; i < razmer; i++)
{
    if (PointA[i]> 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество положительных чисел  {count}");

Console.WriteLine($"[{String.Join(";", PointA)}]");

