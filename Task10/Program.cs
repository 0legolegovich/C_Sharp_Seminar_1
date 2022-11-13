Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = default;
if (number < 100 || number > 999)
    Console.Write("Вы ввели не трехзначное число!");
secondDigit = (number / 10) % 10;
Console.Write($"Вторая цифра введенного числа: {secondDigit} ");

