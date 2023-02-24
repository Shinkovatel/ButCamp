input1:
Console.Write("Введете число А ");
bool check_Number = int.TryParse(Console.ReadLine(), out int Number);
if (!check_Number)
{
    Console.WriteLine("Введены не верные данные");
    goto input1;
}
input2:
Console.Write("Введете степень в которую нужно возвести число  ");
bool check_degree = int.TryParse(Console.ReadLine(), out int degree);
if (!check_degree)
{
    Console.WriteLine("Введены не верные данные");
    goto input2;
}
int sum = 1;
for(int i = 0; i <= degree-1; i++) 
{
    sum = sum*Number;
    
}

Console.WriteLine(sum);