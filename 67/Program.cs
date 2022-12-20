// 67.	Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] Random2DArray(int n, int m, int min=0, int max=10)
{
    int[,] a = new int[n,m];
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            a[i,j] = random.Next(min,max+1);
        }
    }
    return a;
}

void Print2DArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            System.Console.Write($"{a[i,j], 4}");
        }
        System.Console.WriteLine();
    }
}

double[] SrAr(int[,] a)
{
    
    double[] b = new double[a.GetLength(1)];
    for (int j = 0; j < a.GetLength(1); j++)
    {
        double c = 0;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            c = c + a[i,j];
        }
        b[j] = c/a.GetLength(0);
    }
    return b;
}

void PrintArray(double[] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        System.Console.WriteLine($"Среднее арифметическое {i+1} столбца - {a[i]}");
    }
}

int[,] a = Random2DArray(3,5);
Print2DArray(a);
System.Console.WriteLine();
double[] b = SrAr(a);
PrintArray(b);
