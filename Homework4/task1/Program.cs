Console.Write("Введете число А ");
int Number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введете степень в которую нужно возвести число  ");
int degree = Convert.ToInt32(Console.ReadLine());

int sum = 1;
for(int i = 0; i <= degree-1; i++) 
{
    sum = sum*Number;
    
}

Console.WriteLine(sum);