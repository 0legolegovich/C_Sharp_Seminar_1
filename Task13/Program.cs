Console.Write("Введите заданное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = default;
if (number<100 )
    Console.WriteLine("Третьей цифры у введенного числа нет!");
else {
    thirdDigit = (number/100)%10;
Console.Write($"Третья цифра введенного числа: {thirdDigit} ");
     }
