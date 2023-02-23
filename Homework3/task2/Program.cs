Console.Write("Введите координату точки А по оси х ");
 int x1 = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введите координату точки А по оси y ");
 int y1 = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введите координату точки А по оси Z ");
 int z1 = Convert.ToInt32(Console.ReadLine());
 
 Console.Write("Введите координату точки B по оси х ");
 int x2 = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введите координату точки B по оси y ");
 int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки B по оси z ");
 int z2 = Convert.ToInt32(Console.ReadLine());

 var result = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
 //Console.WriteLine(Math.Round(result,3));
Console.WriteLine($"Результат: {result:f2}"); // f2 -2 знака после запятой в переменной result
