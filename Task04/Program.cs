Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());


if(number1 > number2)
{
    if(number1 > number3)
    {
        Console.WriteLine($"Max = {number1}");
    }
    else
    {
        Console.WriteLine($"Max = {number3}");
    }
}
else
{
    if (number2 > number3)
    {
        Console.WriteLine($"Max = {number2}");
    }   
    else
    {
        Console.WriteLine($"Max = {number3}");
    }    
}
