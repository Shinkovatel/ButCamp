// int Number = new Random().Next(100, 1000);

// int result = (Number / 100) * 10 + (Number % 10); // это четыре  

// Console.WriteLine( "Исходное число " + Number + "  1 и 3 цифра " + result);

// string message = Console.ReadLine(); // input number

// Console.WriteLine(message[0] + "" + message[2]);


Console.Write(" Введите первое число" );

int firstvalue = Convert.ToInt32(Console.ReadLine()); // first value

Console.Write(" Введите второе число" );
int secondvalue = Convert.ToInt32(Console.ReadLine()); // second value
int Result  = firstvalue % secondvalue;

if (secondvalue == 0)
{
    return;
}


if (firstvalue %  secondvalue == 0) // проверка на деление без остатка
{
    Console.WriteLine(" Первое число  " + firstvalue + " кратно числу " + secondvalue);
}
else //
{
   // Console.WriteLine(" Первое число " + firstvalue + " не кратно второму числу " + secondvalue + "  Остаток " + Result);
   Console.WriteLine($" Первое число {firstvalue} не кратно второму числу {secondvalue} остаток {Result}"); //Вариант записи чеоез вставление 

     Console.WriteLine($" Первое число не кратное  \n Остаток"); // вариант с переносом строки

}

