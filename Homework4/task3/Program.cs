input1:
Console.Write("Введите число : ");
bool check_Number = int.TryParse(Console.ReadLine(), out int Number);
if (!check_Number)
{
    Console.WriteLine("Введены не верные данные");
    goto input1;
}
 string SecondNumber = Number.ToString();
 int[] resultArray = new int[SecondNumber.Length];

for (int i = 0; i < resultArray.Length; i++)
{
    resultArray[i] = int.Parse(SecondNumber[i].ToString());

}

 Console.WriteLine($"Массив [{String.Join("; ", resultArray)}]");