Console.Write("Введите первое число:"); // вводим первое число
int firstValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:"); // вводим второе число
int secondValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число:");  // вводим третье число
int thidValue = Convert.ToInt32(Console.ReadLine());

int maxValue = 0 ; // задаем начальное значение для сравнения
 
if (firstValue > maxValue) // проверка 1-го числа
{
    maxValue = firstValue; 
}
if (secondValue > maxValue) // проверка 2-го числа
{
    maxValue = secondValue;
}
if (thidValue > maxValue) // проверка 3-го числа
{
    maxValue = thidValue;
}

Console.WriteLine("Максимальное число равно  = " + maxValue); // вывод

// не работает для отрицательных значений