Console.Write("Введите семизначное число:"); // вводим первое число
int Value = Convert.ToInt32(Console.ReadLine()); // вносим в переменную

if ((Value/100) < 1 ) // Проверка что число трехзначное
{
    Console.WriteLine("Нет третьей цифры");   
    return;
}

Console.Write("Ищем третью цифру с начала (нажмите 1) или с конца (нажмите 2) :"); // определяем условие выбора
int Valuevariant = Convert.ToInt32(Console.ReadLine()); // вносим в переменную

 if (Valuevariant == 1)
 {
    int result = (Value / 10000) - ((Value / 100000)*10);
    Console.WriteLine (result); 
 }
 else
 {
    int result = (Value / 100) - ((Value / 1000)*10);
    Console.WriteLine (result); 
 }
