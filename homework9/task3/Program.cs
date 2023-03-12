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
///  Вывод на печать и рекурсии функции Аккермана
/// </summary>
/// <param name="end"> вводимое число с клавиатуры </param>
/// <param name="start"> число  завадаемое в параметре  </param>
/// <returns></returns>
int PrintNumber(int start, int end)
{
    if(start == 0) return end + 1; 
    if(end == 0 && start != 0) return PrintNumber(start-1, 1);
    return PrintNumber(start-1, PrintNumber(start, end-1));
}

int NumberN = GetNumberConsole("Введите число N: "); 
int NumberM = GetNumberConsole("Введите число M: ");

Console.WriteLine($"А({NumberN},{NumberM}) = {PrintNumber(NumberN, NumberM)}");