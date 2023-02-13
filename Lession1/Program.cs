/* - открытие многострочного комментация 

// тип данных имя переменной = значение
Console.Write ("Введите число для которого мы ищем квадрат: ");
int numberA = Convert.ToInt32(Console.ReadLine()); 
// Математика
int result = numberA * numberA;
// rezult
Console.WriteLine("Квадрат числа равен = " + numberA + " равен " + result);

Console.Write("Введите 1-ое число:");
int firstValue = Convert.ToInt32(Console.ReadLine()); //camelcase 
Console.Write("Введите 2-ое число:");
int secondValue = Convert.ToInt32(Console.ReadLine());
// Точка с запятой не ставиться перед фигурными скобками "{"
if (firstValue == Math.Pow(secondValue,2)) // math.pow(secondValue,2) или secondValue*secondValue
{
    Console.WriteLine("Число " + firstValue + "является квадратом от" + secondValue);
}
else // что не является квадратом

{
Console.WriteLine(" Число " + firstValue + " не является квадратом от " + secondValue);
}
int result = firstValue + secondValue; // результат   
Console.WriteLine("", result);
*/
Console.Write("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
if (N<0)
{
    Console.WriteLine("Введено отрицательное число. Умножили его на -1:)" );
    N = N* (-1);
}
int negativeN = N * (-1);

while (negativeN <= N) // [-N; N]
    {
    Console.WriteLine(negativeN);
    negativeN++; //
    }
