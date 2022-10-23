Console.Write("Прямая 1 задается выражением y1 = k1*x + b1. Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Прямая 1 задается выражением y1 = k1*x + b1. Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Прямая 2 задается выражением y2 = k1*x + b2. Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Прямая 2 задается выражением y2 = k2*x + b2. Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

double[] result = new double[2];

if (k1==k2 & b1==b2 )
    Console.WriteLine("Прямые 1 и 2 совпадают");
else {
         if (k1==k2 & b1!=b2 )
         Console.WriteLine("Прямые 1 и 2 параллельны");
         else {
                    result = Intersection(k1, b1, k2, b2);
                    Console.WriteLine($"Координаты точки пересечения прямых 1 и 2: X={result[0]}, Y={result[1]}");
              }
     }

double[] Intersection (double ka, double ba, double kb, double bb)
{   
    double[] res = new double[2];
    double resX = (bb-ba)/(ka-kb);      // проверку на ka = kb, чтобы избежать деление на ноль, выполнена условиями if-else выше.
    double resY = ka*resX + ba;
    res[0] = resX;
    res[1] = resY;
	return res;
}