Console.Write("Введите день недели от 1 до 7: "); // вводим первое число
int Day = Convert.ToInt32(Console.ReadLine()); // вносим в переменную

if (Day == 6 || Day == 7)
{
    Console.WriteLine("Это выходной день");
    return;
}
Console.WriteLine("Это рабочий день");