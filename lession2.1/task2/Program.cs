int Number = new Random().Next(10, 100); // по задаче нужно от 10, до 99, правая граниа на 1 больше

//int Number = new Random().Next(10); // первый параметр равен 0

//int Number = new Random().NextDouble() // возвращает от 0 до 1


int firstvalue = Number / 10;
int secondvalue = Number % 10; // 78 % 10 = 78 -7 * 10
// int maximumvalue = firstvalue;
// int minimumvalue = 0;

if (firstvalue > secondvalue)
{
    //maximumvalue = secondvalue;
    //minimumvalue = firstvalue;
    Console.WriteLine(" Maximum value " + Number + " this " + firstvalue);
    Console.WriteLine(" Minimum value " + Number + " this " + secondvalue);
}
else 
{
    Console.WriteLine(" Maximum value " + Number + " this " + secondvalue);
    Console.WriteLine(" Minimum value " + Number + " this " + firstvalue);
    
}
//Console.WriteLine(" максимальная цифра в числе " + Number + " это " + maximumvalue);
