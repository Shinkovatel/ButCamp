int[] Array = GetArray(5, -100, 100);
int size = Array.Length;

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result; //вернули массив на Size элементов, заполненный числами
}
int Number = Convert.ToInt32(Console.ReadLine());
bool IsMatch = false;
for (int i = 0; i < size; i++)
{
    if (Number == Array[i])
    {
        IsMatch = true;
        break;
    }

}

if (IsMatch)
{
    Console.WriteLine("Число найдено");
}
else
{
    Console.WriteLine("Число ненайдено");
}

Console.WriteLine($"Исходный массив: [{String.Join("; ", Array)}]");


int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int foundNumber = new Random().Next(11); // [0;10]
string isFind = "НЕ НАЙДЕНО"; // Число икскомое не найдено
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == foundNumber)
    {
        isFind = "НАЙДЕНО";// Число найдено
        break; // Ломает цикл при нахождении искомого числа
    }
}
Console.WriteLine($"Число {foundNumber}: {isFind}");