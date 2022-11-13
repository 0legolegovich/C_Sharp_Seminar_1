Console.Write("Задайте количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

FillArray(matrix);
PrintArray(matrix);
double[] result = ColumnAverage(matrix);

Console.WriteLine("Среднее арифметическое каждого стобца:");
for (int i = 0; i < result.GetLength(0); i++)
{
    Console.Write($"{Math.Round(result[i], 2)}  ");
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}    ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(10, 100);
        }
        Console.WriteLine();
    }
}

double[] ColumnAverage(int[,] matr)
{
    double[] avg = new double[matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            avg[j] = avg[j] + matr[i, j];
        }
        //        Console.WriteLine();
    }
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        avg[j] = avg[j] / (matr.GetLength(0));
    }
    return avg;
}
