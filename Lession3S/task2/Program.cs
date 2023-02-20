//  Console.Write("Введите координату по оси х ");

//  int x = Convert.ToInt32(Console.ReadLine());

//  Console.Write("Введите координату по оси y ");

//  int y = Convert.ToInt32(Console.ReadLine());

// // if (x == 0 || y == 0) 
// // {
// //    Console.WriteLine($"нулевое значение");
// //    return;
// // }

// if (x > 0 && y > 0)
// {
//     Console.WriteLine("Четверть 1");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("Четверть 2");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("Четверть 3");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("Четверть 4");
// }
// else
// {
//     Console.WriteLine("Попадание на ось");
// }

 // Корень(х1-х2)^2+(y1-y2)^2)

Console.Write("Введите координату точки А по оси х ");
 int x1 = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введите координату точки А по оси y ");
 int y1 = Convert.ToInt32(Console.ReadLine());
 
 Console.Write("Введите координату точки B по оси х ");
 int x2 = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введите координату точки B по оси y ");
 int y2 = Convert.ToInt32(Console.ReadLine());

// AB = sqrt(xb-xa)^2 + (yb-ya)^2
 var result = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));
 //Console.WriteLine(Math.Round(result,3));
Console.WriteLine($"Результат: {result:f2}"); // f2 -2 знака после запятой в переменной result

