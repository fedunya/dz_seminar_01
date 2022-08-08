Console.WriteLine("Проверка число на четность");
Console.Write("Введите число: ");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString!);
if (number%2 == 0)
    {Console.WriteLine("Число четное");}
else {Console.WriteLine("Число нечетное");}