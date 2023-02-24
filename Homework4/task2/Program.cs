
input1:
Console.Write("Введите число : ");
bool check_Number = int.TryParse(Console.ReadLine(), out int Number);
if (!check_Number)
{
    Console.WriteLine("Введены не верные данные");
    goto input1;
}
int sum=0;

while (Number != 0) 
{
    sum+= Number % 10;
    Number = Number / 10;
}

Console.WriteLine($"Сумма чисел равна {sum}");

// int result = Number.ToString().Sum(c=> c- '0');
// Console.WriteLine($"Сумма чисел равна {result}");