Console.Write("Введите координату X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = default;
distance = Distance(x1, y1, z1, x2, y2, z2);

double Distance (int xa, int ya, int za, int xb, int yb, int zb)
{   
     double res = default;

    res = Math.Sqrt( (xb-xa)*(xb-xa) + (yb-ya)*(yb-ya) + (zb-za)*(zb-za) );
    res = Math.Round(res, 2, MidpointRounding.ToZero);
	return res;
}

Console.WriteLine($"Расстояние между точками составляет {distance}");


