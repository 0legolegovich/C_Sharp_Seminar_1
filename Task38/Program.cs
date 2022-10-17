double[] array = new double[8];

FillArray(array);
PrintArray(array);
double result = Max(array) - Min(array);
Console.WriteLine();
Console.WriteLine ($"В заданном массиве разница между максимальным и минимальным элементом составила {result}");


void FillArray(double[] collection)
{
	int length = collection.Length;
	int index = 0;
	while (index < length)
	{
	collection[index] = new Random().Next(10, 1000);
    collection[index] = collection[index]/10;
	index++;
	}
}

double Max (double[] col)
{
	int count = col.Length;
	int position = 0;
    double max = col[0];
	while (position < count)
	{
		if (col[position] > max) max = col[position];             
        position++;
	}
return max;
}

double Min (double[] col)
{
	int count = col.Length;
	int position = 0;
    double min = col[0];
	while (position < count)
	{
		if (col[position] < min) min = col[position];             
        position++;
	}
return min;
}


void PrintArray (double[] col)
{
	int count = col.Length;
	int position = 0;
	while (position < count)
	{
		Console.Write($"{col[position]}  ");
		position++;
	}
}
