Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NumbersRecursion(1, n));

string NumbersRecursion(int a, int b)
{
    if (a <= b) return NumbersRecursion(a + 1, b) + $"{a} ";
    else return string.Empty;
}
