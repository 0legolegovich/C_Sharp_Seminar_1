Console.WriteLine("Условие умножения матриц: число столбцов первой матрицы должно быть равно числу строк второй.");
Console.Write("Задайте количество строк первой матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов первой матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[rows1, columns1];

Console.Write("Задайте количество строк второй матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов второй матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
int[,] matrix2 = new int[rows2, columns2];

Console.WriteLine();
FillMatrix(matrix1);
PrintMatrix(matrix1);

Console.WriteLine();
FillMatrix(matrix2);
PrintMatrix(matrix2);

Console.WriteLine();
int[,] result = MatrixMultiplication(matrix1, matrix2);
PrintMatrix(result);

void PrintMatrix(int[,] matr)
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

void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(10, 100);
        }
    }
}

int[,] MatrixMultiplication(int[,] matr1, int[,] matr2)
{
    int[,] resultMatr = new int[matr1.GetLength(0),matr2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr2.GetLength(0); k++)
            {
                resultMatr[i, j] = resultMatr[i, j] + matr1[i, k] * matr2[k, j] ;
            }
        }
    }
    return resultMatr;
}
