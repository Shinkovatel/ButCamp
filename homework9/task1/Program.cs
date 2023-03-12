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
///  Вывод на печать и рекурсия
/// </summary>
/// <param name="end"> вводимое число с клавиатуры </param>
/// <param name="start"> число  завадаемое в параметре  </param>
/// <returns></returns>
string PrintNumber(int end, int start)
{
    if(end == start) return end.ToString(); //  преобразует число в формата "Число"

    return (end + "," + PrintNumber(end-1, start));
}
int Number = GetNumberConsole("Введите число: ");
Console.WriteLine(PrintNumber(Number,1));