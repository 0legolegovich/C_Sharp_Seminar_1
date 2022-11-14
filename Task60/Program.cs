Console.Write("Задайте первый размер трехмерного массива: ");
int dimension1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте второй размер трехмерногомассива: ");
int dimension2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте третий размер трехмерного массива: ");
int dimension3 = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[dimension1, dimension2, dimension3];

int[] randomArray = RandomNonRepetetiveArray(dimension1, dimension2, dimension3); // Вспомогательный одномерный массив 
                                                                                  //из случайных неповторяющихся чисел

FillArray(array, randomArray);          // Метод заполняет трехмерный массив случайными числами
PrintArray(array);         // Метод выводит трехмерный массив из элементов вспомогательного одномерного массива      


void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}({i},{j},{k})   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void FillArray(int[,,] matr, int[] rand)        // Заполняем трехмерный массив случайными неповторяющимися числами 
                                                //с помощью вспомогательного массива
{
    int m = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = rand[m++];
            }
        }
    }
}

int[] RandomNonRepetetiveArray(int d1, int d2, int d3)      // Создаем вспомогательный одномерный массив 
                                                            //с неповторяющимися двухзначными значениями
{
    int[] arr = new int[d1 * d2 * d3];
    for (int i = 0; i < arr.Length; i++)
    {
        int num = new Random().Next(10, 100);
        if (arr.Contains(num))
        {
            i--;
        }
        else
        {
            arr[i] = num;
        }
    }
    return arr;
}