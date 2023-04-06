public static class MySort
{
    static void Main()
    {
        int[] array = { 5, -5, -10, 1, -9, 2, 0 };
        CountingSortDebag(array);
    }

    public static void CountingSortDebag(int[] inputArray)
    {
        Console.WriteLine("START");
        Console.WriteLine("inputArray = [" + string.Join(", ", inputArray)+"]");
        int min = inputArray[0];
        int max = inputArray[0];
        int val = 0;
        Console.WriteLine("Поиск мин и макс");
        Console.WriteLine();
        foreach (int element in inputArray)
        {
            val++;
            Console.WriteLine($"\t==========Итерация {val}==========");
            Console.WriteLine($"\tmin = {min}\n\tmax = {max}");
            Console.WriteLine($"\tЗначение элемента {element}");
            if (element > max)
            {
                Console.WriteLine($"\t{element} > {max}");
                max = element;
            }
            else if (element < min)
            {
                Console.WriteLine($"\t{element} < {min}");
                min = element;
            }
            Console.WriteLine();
        }
        Console.WriteLine("\tПоиск мин и макс завершен");
        Console.WriteLine($"\tmin = {min}\n\tmax = {max}");
        Console.WriteLine();
        Console.WriteLine("=====================================");
        Console.WriteLine();
        Console.WriteLine("Поправка");
        int correctionFactor = 0;
        if (min != 0)
        {
            Console.WriteLine($"min = {min}\n{min} != 0");
            correctionFactor = -min;
            Console.WriteLine($"correctionFactor = {-min}");
        }
        else
        {
            Console.WriteLine($"min = {min}\n{min} == 0");
            Console.WriteLine($"correctionFactor = {min}");
        }
        Console.WriteLine($"max = {max} + {correctionFactor}");
        max += correctionFactor;
        Console.WriteLine($"min = {min}\nmax = {max}");
        Console.WriteLine();
        Console.WriteLine("=====================================");
        Console.WriteLine();
        Console.WriteLine($"объявляем массив Count длина массива max({max}) + 1");
        Console.WriteLine();
        Console.WriteLine("=====================================");
        Console.WriteLine();
        val = 0;
        int[] count = new int[max + 1];
        for (int i = 0; i < inputArray.Length; i++)
        {
            val++;
            Console.WriteLine($"\t==========Итерация {val}==========");
            Console.WriteLine("\tcount = [" + string.Join(", ", count) + "]");
            Console.WriteLine("\t{");
            Console.WriteLine($"\t\tcount[inputArray[{i}] + {correctionFactor}] = {count[inputArray[i] + correctionFactor]}");
            Console.WriteLine($"\t\tcount[inputArray[{i}] + {correctionFactor}]++");
            Console.WriteLine($"\t\tcount[{inputArray[i]} + {correctionFactor}] = {count[inputArray[i] + correctionFactor] + 1}");
            Console.WriteLine("\t}");
            Console.WriteLine($"\tcount[{inputArray[i] + correctionFactor}] = {count[inputArray[i] + correctionFactor] + 1}");
            count[inputArray[i] + correctionFactor]++;
            Console.WriteLine();
        }
        Console.WriteLine("\tcount = [" + string.Join(", ", count) + "]");
        Console.WriteLine();
        Console.WriteLine("=====================================");
        Console.WriteLine();
        Console.WriteLine("============Начинаем Сортировку===============\n");
        int index = 0;
        for (int i = 0; i < count.Length; i++)
        {
            Console.WriteLine($"\t========Итерация {i + 1} из {count.Length} Индекс i {i}========\n");
            Console.WriteLine("\tinputArray = [" + string.Join(", ", inputArray) + "]");
            Console.Write($"\tj({0}) < count[{i}]({count[i]})");
            for (int j = 0; j < count[i]; j++)
            {
                Console.WriteLine(" ДА(true)");
                Console.WriteLine($"\t\t======Итерация {j + 1} Индекс j {j}======");
                Console.WriteLine("\t\tinputArray = [" + string.Join(", ", inputArray) + "]");
                Console.WriteLine("\t\tinputArray[index] = i - correctionFactor");
                Console.WriteLine($"\t\tinputArray[{index}] = {i} - {correctionFactor}");
                Console.WriteLine($"\t\tinputArray[{index}] = {i - correctionFactor}\n");
                inputArray[index] = i - correctionFactor;
                index++;
                Console.Write($"\tj({j + 1}) < count[{i}]({count[i]})");
            }
            Console.WriteLine(" НЕТ(false)\n");
        }
        Console.WriteLine("inputArray = [" + string.Join(", ", inputArray) + "]");
        Console.WriteLine("END");
    }

}