Console.Write("Введите пятизначное число");
var firstNumber = Console.ReadLine();

int Number; // если строчка состоит из чисел, то сюда попадает наше число

bool isNumber = int.TryParse(firstNumber, out Number); 

if (isNumber == true) // проверка что введено число
{

if (Number > 9999 && Number < 100000) // проверка что число пятизначное
{
    string NumberB = Number.ToString(); // преобразуем число в строку
    int[] arrayNumber = new int[NumberB.Length]; // обьявляем новый массив
    for (int i=0; i<NumberB.Length; i++) // добавляем элементы в массив
    {
        arrayNumber[i] = int.Parse(NumberB[i].ToString()); // заполняем массив
    }
    int [] returnArray = Enumerable.Reverse(arrayNumber).ToArray(); // получаем обратный массив
    
    bool isCompare = Enumerable.SequenceEqual(arrayNumber, returnArray); // сравнение массивов на соответствие
    if (isCompare == true)
    {
        Console.WriteLine($"Введенное число {firstNumber} является палиндромом");
    } 
    else
    {
        Console.WriteLine($"Введенное число {firstNumber} не полиндром");
    }

return;
}

}

Console.WriteLine($"введенные данные {firstNumber} не являются пятизначным числом");


