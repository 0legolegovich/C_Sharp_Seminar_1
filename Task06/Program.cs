Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number % 2 == 0)
{
    Console.WriteLine($"Вы ввели число {number}. Оно четное. ");
}
else
{
    Console.WriteLine($"Вы ввели число {number}. Оно нечетное. ");
}