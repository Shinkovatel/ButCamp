/// <summary>
/// проверка на число, если нет то возвращает сообщение
/// </summary>
/// <param name="message">вывод сообщения</param>
/// <returns></returns>

int GetNumberConsole(string message)
{
input1:
    Console.Write(message);
    bool check_Number = int.TryParse(Console.ReadLine(), out int Number);
    if (!check_Number)
    {
        Console.WriteLine("Введены не верные данные");
        goto input1;
    }
    return Number;
}
/// <summary>
/// Вывод на печать результатов расчета рекурсии
/// </summary>
/// <param name="start"> Начальное задаваемое значение </param>
/// <param name="end"> Конечное задаваемое значение </param>
/// <returns></returns>
int PrintNumber(int start, int end)
{
    if(start == end+1) return 0; //  возвращаем 0 как достигаем следующего числа за конечным

    return (start + PrintNumber(start+1, end));
}

int NumberN = GetNumberConsole("Введите число N: "); //$"cумма чисел {NumberN} и {NumberM}"
int NumberM = GetNumberConsole("Введите число M: ");
Console.WriteLine($"cумма чисел {NumberN} и {NumberM} равна = {PrintNumber(NumberN, NumberM)}");