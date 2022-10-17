Console.WriteLine("Введите число, которое нужно возвести в степень: ");
double number = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Введите, в какую степень ввести число {number}: ");
int power = Convert.ToInt32(Console.ReadLine());


double result = RaiseToPower(number, power);
Console.WriteLine($"Результат операции: {result}");

double RaiseToPower(double num, int pow)
{
double res = 1;

for (int i = 1; i <= pow; i++)
    {
    res = res * num;
    }
return res;
}


