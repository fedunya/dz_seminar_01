Console.WriteLine("Определение max из трех чисел");
Console.Write("Введите первое число: ");
string? numberString1 = Console.ReadLine();
int number1 = int.Parse(numberString1!);
Console.Write("Введите второе число: ");
string numberString2 = Console.ReadLine()!;
int number2 = int.Parse(numberString2);
Console.Write("Введите третье число: ");
string numberString3 = Console.ReadLine()!;
int number3 = int.Parse(numberString3);
int max = number1;
if (number2 > max)
    {max = number2;}
else if (number3 > max)
    {max = number3;}
Console.WriteLine("Max = " + max);
