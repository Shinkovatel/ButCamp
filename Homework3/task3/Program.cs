input1:
Console.Write("Введите число N: ");
bool check_N = int.TryParse(Console.ReadLine(), out int N);
if (!check_N)
{
    Console.WriteLine("Введены не верные данные");
    goto input1;
}

for(int i = 1; i <= N; i+=1)
{
    Console.Write(Math.Pow(i,3) + "\t");
} 
