
int size = 123;
int[] array = GetArray(size);
int[] GetArray(int size)
{
        int[] rndArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                rndArray[i] = new Random().Next(0, 500);
            }
            return rndArray;}
int countArray(int[] array, int minValue, int maxValue)
{
    int sizeArray = array.Length;
    int count = 0;
        for (int i = 0; i < sizeArray; i++)
        {        
            if (array[i] >= minValue && array[i] <= maxValue)
            {            
                count++;
            }
        } 
        return count;
}
Console.WriteLine($"Исходный массив: [ {string.Join("; ", array)} ]\n\n");
Console.WriteLine($"Кол-во элементов: { countArray(array, 10, 99)}");
 // альтернатива

int size = 123;
int[] array = new int[size];

int count = 0; // Количество чисел в д-е от 10 до 99 включительно

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(200); // [0,999]
    if (array[i] >= 10 && array[i] <= 99)
    {
        count++; // Инкремент: count =  count + 1
        // count += 1
    }
}
Console.WriteLine($"Массив: [{String.Join("; ", array)}]");
Console.WriteLine($"Число элементов, входящих в диапазон [10,99]: {count}");