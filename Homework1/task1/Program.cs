Console.Write("Введите первое число:");
int firstValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:");
int secondValue = Convert.ToInt32(Console.ReadLine());

 int rezult = 0;

if (firstValue == secondValue)
{
    Console.WriteLine(" Первое число " + firstValue + " равно второму числу " + secondValue);
}
else
{
    if (firstValue > secondValue)
    { 
    rezult = firstValue - secondValue;
    Console.WriteLine(" Первое число " + firstValue + " больше второго числа " + secondValue + " на " + rezult);
    }
    else
    {
    rezult = secondValue - firstValue;
    Console.WriteLine(" Второе Число " + secondValue + " больше первого числа " + firstValue + " на " + rezult);  
    }
}