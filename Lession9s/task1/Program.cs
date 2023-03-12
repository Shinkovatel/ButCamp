// унарные операторы - 1 операнд

internal a = 5; 



// бинарные операторы - 2 операнда

int a = 5 + 2;
int b = 5 % 3;

// посфикс: "после"

a++; 

// Префикс

++ a; -  // у префиксного оператора наибольший приоритет


// Тернарный оператор, оперирует с 3-мя операндами

// условие 1 - операнд, 2 - значение для истины, 3 - значение для лжи

int dreamSalary = int.MaxValue;
int realSalary = 20000;
var result = realSalary < dreamSalary ? "Пока что не такая большая" : "Наша зарплата огромна"; // для простого действия

Console.WriteLine(result);

Рекурсия

string SayHello()
{
    SayHello();
    return "hi";
}

SayHello();

while(1>0) 
{
    Console.WriteLine("Hi");
}

int Factorial(int value)
{
    // базовый случай - случай выхода из рекурсии

    // рекурсивный случай (вызов функции внутри функции)

    //int result = 0;
    // for (int i = 0; i < value; i++)
    // {
    if (value == 1) return 1;
    return value * Factorial(value-1);
}
Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
/// <summary>
/// 
/// </summary>
/// <param name="start">числа от одного</param>
/// <param name="end">переменная Numder</param>
/// <returns></returns>
string PrintNumber(int start, int end)
{
    if(start == end) return end.ToString(); //  преобразует число в формата "Число"

    return (start + "," + PrintNumber(start+1, end));
}
Console.WriteLine(PrintNumber(1,Number));


Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

int SumNumber (int Num)
{
if (Num == 0) return 0; // num % 10 = делит число на 10 если 1000 то прервется  

return(Num % 10 + SumNumber(Num / 10));
}
Console.WriteLine(SumNumber(Number));

Console.Write("Введите число А: ");
int NumberА = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень числа: ");
int degree = Convert.ToInt32(Console.ReadLine());

int GetCalc(int Number, int power)
{
    if (power == 0) return 1; // можно так, но нужна доп проверка на ввод 0 (power = 1) return Number
    return (Number * GetCalc(Number, power-1));
}

Console.WriteLine(GetCalc(NumberА,degree));