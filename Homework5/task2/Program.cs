int[] RandomArray(int size) 
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(1000, 9999);
    }
    return result; //вернули массив на Size элементов, заполненный числами
}
input1:
Console.Write("Введите число соответствующее длине массива: ");
bool Check_Length = int.TryParse(Console.ReadLine(), out int Length);
if (!Check_Length)
{
    Console.WriteLine("Введены не верные данные");
    goto input1;
}
int[] Array = RandomArray(Length);

Console.WriteLine($"[{String.Join(";" , Array)}]");

int sumOddNumber = 0;
int size = Array.Length;

for (int i = 1; i <size; i+=2)
{
    sumOddNumber += Array[i];
}

Console.WriteLine($"Cумма элеменов на нечетных позициях в массиве: {sumOddNumber}");