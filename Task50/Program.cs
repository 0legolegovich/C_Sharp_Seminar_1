Console.Write("Задайте количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

FillArray(matrix);
PrintArray(matrix);

Console.Write("Задайте индекс строки требуемого элемента в массиве: ");
int elementRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте индекс столбца требуемого элемента в массиве: ");
int elementColumn = Convert.ToInt32(Console.ReadLine());

if (elementRow < matrix.GetLength(0) && elementColumn < matrix.GetLength(1))
    Console.WriteLine($"Требуемый элемент в заданном массиве: {matrix[elementRow, elementColumn]}");
else
    Console.WriteLine("Элемента с таким индексами строки и столбца в заданном массиве не существует");
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");
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
            matr[i,j] = new Random().Next(10,100);
        }
        Console.WriteLine();
    }
}

