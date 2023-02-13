Console.Write("Введите число:"); // вводим первое число
int firstValue = Convert.ToInt32(Console.ReadLine()); // вносим в переменную


if (firstValue % 2 != 0) // проверка если число не делиться на 2 без остатка
{
    Console.WriteLine(" число " + firstValue + " нечетное ");
}
else
{
    Console.WriteLine(" число " + firstValue + " четное ");
}
