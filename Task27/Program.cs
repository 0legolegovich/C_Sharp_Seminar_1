Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int result = SumOfDigits(number);
Console.WriteLine($"Сумма цифр введенного числа: {result}");

int SumOfDigits(int num)
{
int res = default;
int currentDigit = default;

while (num > 0)
{
    currentDigit = num%10;
    num = num/10;
    res = res + currentDigit;

}
return res;
}
