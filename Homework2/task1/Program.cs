Console.Write("Введите трехзначное число:"); // вводим первое число
int Value = Convert.ToInt32(Console.ReadLine()); // вносим в переменную

if ((Value/100) < 1 || ((Value/100) > 10)) // Проверка что число трехзначное
{
    Console.WriteLine("введенное число не является трехзначным");   
    return;
}

int result = (Value / 10) - ((Value / 100)*10);
Console.WriteLine (result); 

