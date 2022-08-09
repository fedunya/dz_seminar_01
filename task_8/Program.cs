Console.WriteLine("Вывод всех четных чисел в диаппазоне от 1 до N");
Console.Write("Введите N: ");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString!);
int i = 2;
if (number < 2)
    {Console.WriteLine("Число должно быть больше 1");}
else {while (i <= number)
        {Console.Write(i + " ");
         i = i + 2;}
}
Console.WriteLine();
