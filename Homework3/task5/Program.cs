using System.Collections.Generic;
using System;
using System.Linq;

// static int IndexOf(int[] arrayNumber, int value)
// {
//     for (int i = 0; i < arrayNumber.Length; i++)
//     {
//         if (arrayNumber[i] == value)
//         {
//             return i;
//         }

//     }
//     return -1;
// }

input1:
Console.Write("Введите число 3-х ,5-ти ,7-ми значное: ");
bool check_Number = int.TryParse(Console.ReadLine(), out int Number);
if (!check_Number)
{
    Console.WriteLine("Введены не верные данные");
    goto input1;
}
int result;
if (Number > 99 && Number < 1000 || Number > 9999 && Number < 100000 || Number > 999999 && Number < 10000000) // проверка что число попадает в диапазон
{
    string NumberB = Number.ToString(); // преобразуем число в строку
    int[] arrayNumber = new int[NumberB.Length]; // обьявляем новый массив
    for (int i=0; i<NumberB.Length; i++) // добавляем элементы в массив
    {
        arrayNumber[i] = int.Parse(NumberB[i].ToString()); // заполняем массив
    }
    int firstNumber = arrayNumber[0]; // ищем первый элемент
    int LastNumber  = arrayNumber.Last(); // ищем последний элемент
    
    result = Math.Abs(firstNumber - LastNumber); // ищем разницу 1 и последнего элемента по модулю
    //int FindNumber = IndexOf(arrayNumber,result); // проверяем есть ли число в массиве и какой в его индекс.
   int FindNumber = arrayNumber.ToList().LastIndexOf(result); // проверяем есть ли число в массиве и смотрим его последний индекс.
        // проверяю конретные индексы для 3, 5, 7 значных цифр
     if (arrayNumber.Length == 3 && FindNumber == 1 || arrayNumber.Length == 5 && FindNumber ==2 || arrayNumber.Length == 7 && FindNumber == 3) 
     {
        Console.WriteLine($"Число {Number} красивое");
        return;
     }

        Console.WriteLine($"Число {Number} некрасивое");

   Console.WriteLine(result);
   Console.WriteLine(FindNumber);
   
   return;
}



Console.WriteLine($"введенные данные {Number} не попадают в заданный диапазон");