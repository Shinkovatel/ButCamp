/* - открытие многострочного комментация 

// тип данных имя переменной = значение
Console.Write ("Введите число для которого мы ищем квадрат: ");
int numberA = Convert.ToInt32(Console.ReadLine()); 
// Математика
int result = numberA * numberA;
// rezult
Console.WriteLine("Квадрат числа равен = " + numberA + " равен " + result);
*/
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