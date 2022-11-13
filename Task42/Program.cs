// Перевод из десятичной в двоичную

Console.WriteLine("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Binary(int num)
{
    int temp = 0;
    int count = 1;
    while (num > 0)
    {
        temp = temp + num % 2 * count;
        num = num / 2;
        count = count * 10;
    }
    return temp;
}
int binary = Binary(number);
Console.WriteLine($"{number}  ->  {binary}");

// Вариант через строку, + можно потом сконвертировать

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// string DecToBin (int number)
// {
//     string result = String.Empty;
//     while (number > 0)
//     {
//         result = Convert.ToString(number % 2) + result;
//         number = number / 2;
//     }
//     return result;
// }

// string binaryNum = DecToBin(num);
// Console.WriteLine(binaryNum);
