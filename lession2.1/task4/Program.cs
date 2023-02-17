Console.Write("Введите число ");
int firstnumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число ");
// int firstnumber = Convert.ToInt32(Console.ReadLine());

// && Оператор логического  (И) и яблоки и апельсины одновременно
// || Оператор логического  (ИЛИ) или яблоки или апельсины

if (firstnumber % 7 == 0 && firstnumber % 23 ==0)
{
    Console.WriteLine("Число кратно 7 и 23 одновременно");
} 
else 
{
    Console.WriteLine("Число не кратно 7 и 23 ");
    Console.WriteLine($"Остаток от деления на 7 равен {firstnumber % 7} ");
    Console.WriteLine($"Остаток от деления на 23 равен {firstnumber % 23} ");
    
}
