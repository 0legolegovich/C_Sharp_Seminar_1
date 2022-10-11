Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Cube(number);

void Cube (int num)
{
	int count = 1;
	while (count <= num)
	{
		int cube = count * count * count;
		Console.WriteLine($"{count}  |  {cube}");
		count++;
	}
}