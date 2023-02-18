Console.Write("Введите семизначное число:"); // вводим первое число
int Value = Convert.ToInt32(Console.ReadLine()); // вносим в переменную

if ((Value/100) < 1 ) // Проверка что число трехзначное
{
    Console.WriteLine("Нет третьей цифры");   
    return;
}
int result = (Value / 10000) - ((Value / 100000)*10);
Console.WriteLine (result); 