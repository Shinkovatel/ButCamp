// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введете число для расчета числа Фибоначи: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] Fibonishi(int size)
{
    int[] result = new int[size];
    result[0] = 0;
    result[1] = 1;
    for (int i = 2; i < size; i++)
    {

        result[i] = result[i - 1] + result[i - 2];

    }
    return result;
}
int[] array = Fibonishi(N);

Console.WriteLine($"числа Фибоначи [{String.Join(",", array)}]");

