//  //input1:
//  try{
//  Console.Write("Введите число");
//  int Number = Convert.ToInt32(Console.ReadLine());
// // bool check_Number = int.TryParse(Console.ReadLine(), out int Number);
// // if (!check_Number)
// // {
// //     Console.WriteLine("Введены не верные данные");
// //     goto input1;
// //}
// int count =0;
 
// if (Number < 0)
// {
//     Number*= -1;
// }
// if (Number !=0)
// {
//     while (Number % 10 > 0)
//     {
//     Number = Number / 10;
//     count++;
//     }
//   }
//   else
//   {
//     count = 1; 
//   }
// Console.WriteLine(count);
//  }
//  catch(System.FormatException m) // альтернативный вариант проверки введения информации
//  {
//     Console.WriteLine("Error");
//  }

 // решение с функцией

 Console.Write("Введите число");
 int Number = Convert.ToInt32(Console.ReadLine());

 int GetCountNumber(int Number)
 {
    int count = 0; // количество цифр в числе
    while(Number>0)
    {
        count++;
        Number = Number/=10;
    }
    return count;
 }

 Console.WriteLine($"Количество цифр: {GetCountNumber(Number)} ");