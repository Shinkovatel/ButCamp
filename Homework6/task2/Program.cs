input1:
Console.Write("Введите K1 : ");
bool check_koff1 = int.TryParse(Console.ReadLine(), out int koff1);
if (!check_koff1)
{
    Console.WriteLine("Введены не верные данные");
    goto input1;
}

input1:
Console.Write("Введите число K2: ");
bool check_koff2 = int.TryParse(Console.ReadLine(), out int koff2);
if (!check_koff2)
{
    Console.WriteLine("Введены не верные данные");
    goto input1;
}

input1:
Console.Write("Введите число B1: ");
bool check_B1 = int.TryParse(Console.ReadLine(), out int B1);
if (!check_B1)
{
    Console.WriteLine("Введены не верные данные");
    goto input1;
}
input1:
Console.Write("Введите число B2 : ");
bool check_B2 = int.TryParse(Console.ReadLine(), out int B2);
if (!check_B2)
{
    Console.WriteLine("Введены не верные данные");
    goto input1;
}

int equation_x = (B2 - B1) / (koff1 - koff2);

int equation_y = koff1 * equation_x + B1;


