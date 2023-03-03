Console.Write("Введите числa через запятую ',' : ");
String valueStr = Console.ReadLine(); // числа текстом
string[] values = valueStr.Split(","); // числа по отдельности

float[] PointA= new float[values.Length]; // определили новый массив, с длиной массива values
int j = 0;
foreach (string value in values) // перебираем элементы массива и записываем с преобразованием
    PointA[j++] = Convert.ToSingle(value);
 
int razmer=PointA.Length;

int count = 0;
for (int i = 0; i < razmer; i++) // проверяем элементы массива на положительные числа
{
    if (PointA[i]> 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество положительных чисел  {count}");

Console.WriteLine($"[{String.Join(";", PointA)}]");

