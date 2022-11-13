Console.Write("Задайте количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

FillArray(matrix);          // Метод заполняет двумерный массив случайными числами
PrintArray(matrix);         // Метод выводит двумерный массив      
BubbleSortArray(matrix);    // Метод сортирует двумерный массив методом сортировки пузырьком
Console.WriteLine();        // Отступ для эстетики
PrintArray(matrix);         // Выводит отсортированный двумерный массив

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
            matr[i, j] = new Random().Next(10, 100);
        }
        Console.WriteLine();
    }
}

void BubbleSortArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - j - 1; k++)
            {
                if (matr[i, k] < matr[i, k+1])
                {
                    int temp = matr[i, k];
                    matr[i, k] = matr[i, k+1];
                    matr[i, k+1] = temp;
                }
            }
        }
    }
}