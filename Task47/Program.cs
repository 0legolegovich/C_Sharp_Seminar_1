Console.Write("Задайте количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[rows, columns];

FillArray(matrix);
PrintArray(matrix);

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}   ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(-100,100);
            matr[i,j] = matr[i,j]/10;
        }
        Console.WriteLine();
    }
}
