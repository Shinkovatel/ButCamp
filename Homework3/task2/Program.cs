
input1:
Console.Write("Введите координату точки А по оси х ");
 bool check_x1 = int.TryParse(Console.ReadLine(), out int x1);
 if(!check_x1) 
 {
    Console.WriteLine("неверный ввод данных");
 goto input1;
 }

 input2:
Console.Write("Введите координату точки А по оси y ");
 bool check_y1 = int.TryParse(Console.ReadLine(), out int y1);
 if(!check_y1) 
 {
    Console.WriteLine("неверный ввод данных");
 goto input2;
 }

input3:
Console.Write("Введите координату точки А по оси z ");
 bool check_z1 = int.TryParse(Console.ReadLine(), out int z1);
 if(!check_z1) 
 {
    Console.WriteLine("неверный ввод данных");
 goto input3;
 }

input4:
Console.Write("Введите координату точки B по оси х ");
 bool check_x2 = int.TryParse(Console.ReadLine(), out int x2);
 if(!check_x2) 
 {
    Console.WriteLine("неверный ввод данных");
 goto input4;
 }

input5:
Console.Write("Введите координату точки B по оси y ");
 bool check_y2 = int.TryParse(Console.ReadLine(), out int y2);
 if(!check_y2) 
 {
    Console.WriteLine("неверный ввод данных");
 goto input5;
 }

 input6:
Console.Write("Введите координату точки B по оси z ");
 bool check_z2 = int.TryParse(Console.ReadLine(), out int z2);
 if(!check_z2) 
 {
    Console.WriteLine("неверный ввод данных");
 goto input6;
 }


 var result = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));

Console.WriteLine($"Результат: {result:f2}"); // f2 -2 знака после запятой в переменной result

