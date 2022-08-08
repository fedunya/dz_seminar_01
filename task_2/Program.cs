Console.WriteLine("Определение max и min из двух чисел");
Console.Write("Введите первое число: ");
string? numberString1 = Console.ReadLine();
int number1 = int.Parse(numberString1!);
Console.Write("Введите второе число: ");
string numberString2 = Console.ReadLine()!;
int number2 = int.Parse(numberString2);
if (number1 > number2)
    {Console.WriteLine("Max = " + number1);
     Console.WriteLine("Min = " + number2);}
else if (number1 < number2)
    {Console.WriteLine("Max = " + number2);
     Console.WriteLine("Min = " + number1);}
else {Console.WriteLine("Числа равны");}