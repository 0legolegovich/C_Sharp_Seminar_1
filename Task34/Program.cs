int[] array = new int[8];

FillArray(array);
PrintArray(array);
int result = NumberOfEvenNumbers(array);
Console.WriteLine();
Console.WriteLine ($"В заданном массиве {result} четных чисел");

void FillArray(int[] collection)
{
	int length = collection.Length;
	int index = 0;
	while (index < length)
	{
	collection[index] = new Random().Next(100, 1000);
	index++;
	}
}

int NumberOfEvenNumbers (int[] col)
{
	int count = col.Length;
	int position = 0;
    int counter = 0;
	while (position < count)
	{
		if (col[position]%2 == 0) counter++;
		position++;
	}
return counter;
}

void PrintArray (int[] col)
{
	int count = col.Length;
	int position = 0;
	while (position < count)
	{
		Console.Write($"{col[position]} ");
		position++;
	}
}
