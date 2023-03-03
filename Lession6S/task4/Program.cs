input1:
Console.Write("Введите число : ");
bool check_Number = int.TryParse(Console.ReadLine(), out int Number);
if (!check_Number)
{
    Console.WriteLine("Введены не верные данные");
    goto input1;
}
int NumberTwo = Number; 

    int count = 0;
    for (int i = 0; 0 < Number; i++)
{
    Number = Number / 2;
    count++;
} 

int size = count;

int[] Binary (int Number) 
{
    int[] result = new int[size];
    for (int i = 0; 0 < NumberTwo; i++)
    {
        if (NumberTwo % 2 == 0)
        {
            result[i] = NumberTwo % 2;
            NumberTwo = NumberTwo / 2; 
        }
        else if(NumberTwo % 2 == 1)
        {
            result[i] = NumberTwo % 2;
             NumberTwo = NumberTwo / 2;
        }
    }
    int[] result2 = Enumerable.Reverse(result).ToArray();
    return result2;
} 
int [] array = Binary(Number);
// static void Cat (ref int[] array, int newSize)
// {
//     int[] newArray = new int[newSize];

//     for (int i = 0; array[i] > 0; i++)

//     {
//         newArray[i] = array[i];
//     }
//     array = newArray;
//     //return newArray;
// }

//int [] FinalArray = Cat(array,count);
Console.WriteLine($"[{String.Join(";", array)}]");