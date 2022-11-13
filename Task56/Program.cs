Console.Write("Задайте количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

FillArray(matrix);          // Метод заполняет двумерный массив случайными числами
PrintArray(matrix);         // Метод выводит двумерный массив      
int result = RowWithMinSum(matrix);
Console.WriteLine($"Сумма элементов в строке с индексом {result} наименьшая");

void PrintArray(int[,] matr)
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

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
        Console.WriteLine();
    }
}

int RowWithMinSum(int[,] matr)
{
    int[] sum = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum[i] = sum[i] + matr[i,j];            // Сумма элементов в каждой строке
            
        }
    }
    
    int min = sum[0];
    int minRowNumber = 0;
    for (int i = 1; i < sum.Length; i++)
    {
        if (sum[i] < min) 
        {
            min = sum[i];
            minRowNumber = i;
        }
    }
    return minRowNumber;
}