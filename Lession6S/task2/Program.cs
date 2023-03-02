// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Write("Введете число А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введете число B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введете число C: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a + b > c && a + c >b && b + c > a)
{
    Console.WriteLine("Треугольник получился");
}
else 
{
    Console.WriteLine("Треугольник не получается");
}
