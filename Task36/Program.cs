int[] array = new int[8];

FillArray(array);
PrintArray(array);
int result = SumOddPositionElements(array);
Console.WriteLine();
Console.WriteLine ($"В заданном массиве сумма элементов, находящихся на нечетной позиции, составила {result}");

void FillArray(int[] collection)
{
	int length = collection.Length;
	int index = 0;
	while (index < length)
	{
	collection[index] = new Random().Next(-100, 100);
	index++;
	}
}

int SumOddPositionElements (int[] col)
{
	int count = col.Length;
	int position = 0;
    int sum = 0;
	while (position < count)
	{
		if (position%2 == 0) sum=sum + col[position];             
        // Проверку пройдут элементы с индексами 0, 2, 4, ..., то есть позиции первая, третья, пятая... 
        // Можно сделать наоборот, поставив условие position%2 == 1
		position++;
	}
return sum;
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
