input1:
Console.Write("Введите сумму вклада в тыс. рублей: ");
bool check_money = double.TryParse(Console.ReadLine(), out Double money);
if (!check_money)
{
    Console.WriteLine("Введены не верные данные");
    goto input1;
}
double result = 0;
if (money < 100)
{
    result = money + (money * 0.05);
    Console.WriteLine($"Ваша сумма с процентами равна {result} тыс. руб");
}
else if (money > 100 && money < 200)
{
    result = money + (money * 0.07);
    Console.WriteLine($"Ваша сумма с процентами равна {result} тыс. руб");
}
else
{
    result = money + (money * 0.1);
    Console.WriteLine($"Ваша сумма с процентами равна {result} тыс. руб");
}