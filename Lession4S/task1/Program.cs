// // void : нет оператора return

// // тип возращаемого значения или (параметры)

//  int Calculate(int a, int b, char sign) // Два числа: a,b и знак(* \ )
//  {
//     //int result = a+b;
//     int result = 0;
//     if (sign == '*')
//     {
//         result = a * b ;
//     }
//     else if (sign == '+')
//     {
//         result = a + b;
//     }
//     else if (sign == '-')
//     {
//         result = a - b;
//     }
//     // else  (sign == '/')
//     // { 
//     //     result = a / b; 
//     // }
//     return result;
//  }


// Console.WriteLine(Calculate(3,5, '+'));
// Console.WriteLine(Calculate(3,5, '-'));
// Console.WriteLine(Calculate(3,5, '*'));
// Console.WriteLine(Calculate(3,5, '_'));
// // string - массив символов
// // char - один символ

Console.Write("Введете число  ");
int limit = Convert.ToInt32(Console.ReadLine());

// int sum = 0;

// for (int i = 0; i <= limit; i++)
// {
//     sum += i; // a = a+5 = (a+=5) ; a = a*200 = (a*=200); f=f/400 = (f/=400)
// }
 
// Console.WriteLine($"Сумма числа от 1 до {limit} = {sum}");
// pascalcase - каждое слово с большой буквы
int GetSum(int A)
{
    A+=100;
    int sum = 0;

    for (int i = 0; i <= A; i++)
    {
    sum += i; 
    }
    return sum;
}

Console.WriteLine($"Сумма числа от 1 до {limit} = {GetSum(limit)}");
Console.WriteLine($"Сумма числа от 1 до {4} = {GetSum(4)}");