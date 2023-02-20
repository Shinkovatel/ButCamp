Console.Write("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

// int i = 1;
// while (i <= N)
// {
//     Console.Write(Math.Pow(i,2) + "\t");
//     // литерал "\t" - 4 пробела между элементами
//     // "\n"  - new перенос на новую строку  = заменяет Console.WriteLine();

//     i++;
// }   
// for (начало, условия, увеличение переменной  - счетчика)
for(int i = 0; i <= N; i+= 2)
{
    Console.Write(i + "\t");
} 

// i=i+2