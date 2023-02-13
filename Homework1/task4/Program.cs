Console.Write("Введите число:"); // вводим первое число
int firstValue = Convert.ToInt32(Console.ReadLine()); // вносим в переменную

if (firstValue < 0)
{
    firstValue = -firstValue; // боремся с отрицательными значениями
}

int count = 0; // устанавливаем счетчик

while (count < firstValue) // цикл пока не достигнет значения переменной
{
    if (firstValue % 2 == 0) // проверка на четность
    {
        Console.WriteLine(firstValue);
        firstValue = firstValue - 2; // вычисляем четные числа
        
    }
    else
    {
        firstValue = firstValue - 1; // если не четное отнимаем единицу и идем дальше
                    
    }
    count=+1;
}