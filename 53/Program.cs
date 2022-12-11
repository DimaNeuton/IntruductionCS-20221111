// 53.	Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

void Intersection(int k1, int b1, int k2, int b2, ref double x, ref double y)
{
    if (b1 == b2 && k1 != k2)
    {
        y = b1;
        x = 0;
    }
    else
    {
        x = (k1 - k2) / (b2 - b1);
        y = k1 * x + b1;
    }
}

double x = 0, y = 0;
System.Console.Write("Write k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Write b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Write k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Write b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2 && b1 == b2)
{
    System.Console.WriteLine($"Эти прямые совпадают");
    return;
}
    if (k1 == k2 && b1 != b2)
    {
        System.Console.WriteLine($"Эти прямые не пересекаются"); 
    }
        else
        {
            Intersection(k1, b1, k2, b2, ref x, ref y);
            System.Console.WriteLine($"Координаты точки пересечения: {x}, {y}");
        }


    
        
    