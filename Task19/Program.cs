Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool res = default;
res = ifPalindrome(number);

if (res)
{
    Console.WriteLine("Введенное число - палиндром");
}
else
{
    Console.WriteLine("Введенное число - не является палиндромом");
}

bool ifPalindrome(int num)
{
    int firstDigit = default;
    int secondDigit = default;
    int thirdDigit = default;
    int fourthDigit = default;
    int fifthDigit = default;
    // Цифры считаю справа налево, то есть единицы - firstDigit, десятки - secondDigit ...    
    firstDigit = num % 10;
    secondDigit = (num % 100) / 10;
    thirdDigit = (num % 1000) / 100;
    fourthDigit = (num % 10000) / 1000;
    fifthDigit = num / 10000;

    if (firstDigit == fifthDigit && secondDigit == fourthDigit) return true;
    return false;
}



