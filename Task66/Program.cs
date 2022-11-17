Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumRecursion(m, n));

int SumRecursion(int m, int n)
{
    if (m == n) return 0;
    else if (m < n) return n + SumRecursion(m, n - 1);
    else return n + SumRecursion(m - 1, n);
    
}

