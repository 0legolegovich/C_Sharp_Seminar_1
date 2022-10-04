Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int counter = 1;

while (counter <= number)
{
    if(counter%2 == 0)
    {
        Console.Write($"{counter} ");
    }
    counter++;
}