

Console.WriteLine("Введите число M, количество элементов массива: ");
int numberM = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numberM];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int result = NumberOfPositiveNumbers(array);
Console.WriteLine($"Вами было введено {result} положительных чисел");

void FillArray(int[] collection)
{
	int length = collection.Length;
	int index = 0;
	while (index < length)
	{
	    Console.Write("Введите элемент массива: ");
        int element = Convert.ToInt32(Console.ReadLine());
        collection[index] = element;
        index++;
	}
}

void PrintArray (int[] col)
{
	int count = col.Length;
	int position = 0;
	while (position < count)
	{
		Console.Write($"{col[position]}  ");
		position++;
	}
}

int NumberOfPositiveNumbers (int[] col)
{
	int count = col.Length;
	int position = 0;
    int counter = 0;
	while (position < count)
	{
		if (col[position] > 0) counter++;
		position++;
	}
return counter;
}